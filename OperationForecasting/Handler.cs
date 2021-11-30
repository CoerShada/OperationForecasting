using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationForecasting
{
    class Handler
    {
        private Steel[] steels;
        public Handler()
        {
            this.steels = new Steel[]{
                new Steel20(0.17),
                new Steel12H1MF(0.19)
            };
        }

        public Steel[] GetSteels()
        {
            return steels;
        }

        public double GetResidualOperatingTime(Steel steel, double currentTime, double V, double MNI, double A= -100)
        {
            return steel.RemainingRunningTime(currentTime, V, MNI, A);
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
            double rrt = GetResidualOperatingTime(steel, currentTime, V, MNI, A);
            if(rrt>=0 && rrt < 25000)
            {
                outstring = readyStrings[0];
            }
            else if(rrt >= 25000 && rrt < 50000)
            {
                outstring = readyStrings[1];
            }
            else if(rrt >= 50000)
            {
                outstring = readyStrings[2];
            }
            else
            {
                outstring = readyStrings[3];
            }
            return outstring;
        }

        public double CoefStructuralMechanical(Steel steel, double V, double MNI, double A = -100)
        {
            return steel.GetCoefStructuralMechanical(V, MNI, A);
        }
    }
}
