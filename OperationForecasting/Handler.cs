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

        public double GetResidualOperatingTime(Steel steel, double currentTime, double R, double K)
        {
            return steel.RemainingRunningTime(currentTime, R, K);
        }

        public string GetOutMessage(Steel steel, double currentTime, double R, double K)
        {
            string[] readyStrings =
            {
                "Остаточный срок эксплуатации не рекомендуется продлять в связи исчер-панием ресурса работоспособности. ",
                "Остаточный срок эксплуатации рекомендуется продлить на 25 тыс. часов. ",
                "Остаточный срок эксплуатации рекомендуется продлить на 50 тыс. часов. "
            };
            string outstring;
            double rrt = GetResidualOperatingTime(steel, currentTime, R, K);
            if(rrt>=0 && rrt < 25000)
            {
                outstring = readyStrings[0];
            }
            else if(rrt >= 25000 && rrt < 50000)
            {
                outstring = readyStrings[1];
            }
            else
            {
                outstring = readyStrings[2];
            }
            return outstring;
        }
    }
}
