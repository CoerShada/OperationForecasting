using System;
using System.Collections.Generic;
using System.Linq;

namespace OperationForecasting
{
    class Handler
    {
        public static string currentSteelName = "";
        public static double currentSigmaL, currentSigmaD, currentA1, currentA2, currentKsm, currentSGamma ,currentRrt, currentR, currentKzat, currentA, currentV, currentMNI;

        public ApplicationContext context;

        private Steel[] steels;
        public Handler()
        {
            this.steels = new Steel[]{
                new Steel20(0.17),
                new Steel12H1MF(0.19)
            };
            context = new ApplicationContext();
        }

        public Steel[] GetSteels()
        {
            return steels;
        }

        public double GetResidualOperatingTime(Steel steel, double currentTime, double V, double MNI, double A= -100)
        {
            SaveParameters(steel, V, MNI, A);
            return steel.RemainingRunningTime(currentTime, currentSigmaL, currentSigmaD, currentA1, currentA2, MNI);
        }

        public string GetOutMessage(Steel steel, double currentTime, double V, double MNI, double A = -100)
        {
            string[] readyStrings =
            {
                "Остаточный срок эксплуатации не рекомендуется продлять в связи исчер-панием ресурса работоспособности. ",
                "Остаточный срок эксплуатации рекомендуется продлить на 25 тыс. часов. ",
                "Остаточный срок эксплуатации рекомендуется продлить на 50 тыс. часов. ",
                "Ошибка! Некорректный ввод данных."
            };
            string outstring;
            currentRrt = GetResidualOperatingTime(steel, currentTime, V, MNI, A);
            if(currentRrt >= 0 && currentRrt < 25000)
            {
                outstring = readyStrings[0];
            }
            else if(currentRrt >= 25000 && currentRrt < 50000)
            {
                outstring = readyStrings[1];
            }
            else if(currentRrt >= 50000)
            {
                outstring = readyStrings[2];
            }
            else
            {
                outstring = readyStrings[3];
            }
            Console.WriteLine(currentA1);
            Log record = new Log(currentSteelName, currentR, currentKsm, currentV, currentA, currentMNI, currentSigmaL, currentSigmaD, currentA1, currentA2, currentSGamma,currentKsm, currentRrt, outstring, DateTime.Today);
            context.Logs.Add(record);
            context.SaveChanges();
            return outstring;
        }

        public void SaveParameters(Steel steel, double V, double MNI, double A = -100)
        {

            if (A == -100)
            {
                A = V;
                currentR = ConvertHelper.VtoR(V);
                currentKzat = ConvertHelper.MNItoK(MNI);
                currentA = 0;
                currentV = 0;
                currentMNI = 0;
            }
            else
            {
                currentR = 0;
                currentKzat = 0;
                currentA = A;
                currentV = V;
                currentMNI = MNI;
            }
            currentSteelName = steel.GetSteelName();
            currentSigmaL = steel.GetAmplitudeOfInternalStressFields(V);
            currentSigmaD = steel.GetShearStresses(A);
            currentA1 = steel.GetDeformationIndicator1(MNI);
            currentA2 = steel.GetDeformationIndicator2(MNI);
            currentSGamma = steel.GetRatioOfYieldStrengthToElongation(MNI);
            currentKsm = steel.CoefStructuralMechanical(currentSigmaL, currentSigmaD, currentA1, currentA2, currentSGamma);
        }

        public double CoefStructuralMechanical(Steel steel, double V, double MNI, double A = -100)
        {
            SaveParameters(steel, V, MNI, A);
            return currentKsm;
        }

        public Log[] Logs(DateTime from, DateTime to, bool allVisible)
        {
            List<Log> allLogs = context.Logs.ToList();
            List<Log> logs = new List<Log>();


            foreach (Log log in allLogs)
            {

                if (allVisible|| (log.getDate().AddDays(1) >= from && log.getDate() <= to.AddDays(1)))
                {
                    logs.Add(log);
                }
            }


            return logs.ToArray();
        }
    }
}
