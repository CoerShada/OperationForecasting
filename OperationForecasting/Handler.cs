using System;
using System.Collections.Generic;
using System.Linq;

namespace OperationForecasting
{
    class Handler
    {
        public static readonly Handler Instance = new Handler();

        public static int currentMaterialId = -1;
        public static double currentSigmaL, currentSigmaD, currentA1, currentA2, currentKsm, currentSGamma ,currentRrt, currentR, currentKzat, currentA, currentV, currentMNI;


        private Dictionary<string, Material> _Materials;
        public Handler()
        {
            UpdateMaterials();
        }

        public void UpdateMaterials()
        {
            _Materials = new Dictionary<string, Material>();
            List <Material> materials = DBHandler.Instance.GetActualMaterials();
            foreach (Material material in materials)
            {
                _Materials.Add(material.GetName(), material);
            }
        }

        public Dictionary<string, Material> GetMaterials()
        {
            return _Materials;
        }

        public double GetResidualOperatingTime(Material material, double currentTime, double V, double MNI, double A = -100)
        {
            SaveParameters(material, V, MNI, A);
            return material.RemainingRunningTime(currentTime, currentSigmaL, currentSigmaD, currentA1, currentA2, MNI);
        }

        public string GetOutMessage(Material material, double currentTime, double V, double MNI, double A = -100)
        {
            string[] readyStrings =
            {
                "Остаточный срок эксплуатации не рекомендуется продлять в связи исчер-панием ресурса работоспособности. ",
                "Остаточный срок эксплуатации рекомендуется продлить на 25 тыс. часов. ",
                "Остаточный срок эксплуатации рекомендуется продлить на 50 тыс. часов. ",
                "Ошибка! Некорректный ввод данных."
            };
            string outstring;
            currentRrt = GetResidualOperatingTime(material, currentTime, V, MNI, A);
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
            Log record = new Log(currentMaterialId, currentR, currentKsm, currentV, currentA, currentMNI, currentSigmaL, currentSigmaD, currentA1, currentA2, currentSGamma,currentKsm, currentRrt, outstring, DateTime.Today);
            DBHandler.Instance.AddLog(record);
            return outstring;
        }

        public void SaveParameters(Material material, double V, double MNI, double A = -100)
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
            currentMaterialId = material.GetId();
            currentSigmaL = material.GetAmplitudeOfInternalStressFields(V);
            currentSigmaD = material.GetShearStresses(A);
            currentA1 = material.GetDeformationIndicator1(MNI);
            currentA2 = material.GetDeformationIndicator2(MNI);
            currentSGamma = material.GetRatioOfYieldStrengthToElongation(MNI);
            currentKsm = material.CoefStructuralMechanical(currentSigmaL, currentSigmaD, currentA1, currentA2, currentSGamma);
        }

        public double CoefStructuralMechanical(Material material, double V, double MNI, double A = -100)
        {
            SaveParameters(material, V, MNI, A);
            return currentKsm;
        }

        public Log[] Logs(DateTime from, DateTime to, bool allVisible)
        {
            List<Log> allLogs = DBHandler.Instance.GetActualLogs();
            List<Log> logs = new List<Log>();

            foreach (Log log in allLogs)
            {

                if (allVisible || (log.getDate() >= from.AddDays(-1) && log.getDate() <= to.AddDays(1)))
                {
                    logs.Add(log);
                }
            }
            return logs.ToArray();
        }
    }
}
