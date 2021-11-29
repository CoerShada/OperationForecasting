using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationForecasting
{
    class ConvertHelper
    {

        public static double MNItoK(double MNI)
        {
            return (MNI - 365.5519) / 1735.5715;
        }

        public static double KtoMNI(double K)
        {
            return 356.5519 + 1735.5715 * K;
        }

        public static double RtoV(double R)
        {
            return R / 0.018; //Константа расстояния (у нас 18мм)
        }

        public static double VtoR(double V)
        {
            return 0.018/V ; //Константа расстояния (у нас 18мм)
        }

        public static double RtoA(double A)
        {
            return (5836.3148 - A)/1.1573;
        }

        public static double AtoR(double R)
        {
            return 5836.3148 - 1.1573 * R;
        }
    }
}
