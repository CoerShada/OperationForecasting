using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationForecasting
{
    class Steel12H1MF : Steel
    {
        public Steel12H1MF(double CoefRatio) : base(CoefRatio) { }

        public override double GetAmplitudeOfInternalStressFields(double V)
        {
            double R = ConvertHelper.VtoR(V);
            return -28663.05 + 12.7609 * R - 0.0014 * Math.Pow(R, 2);
        }

        public override double GetShearStresses(double A)
        {
            double R = ConvertHelper.AtoR(A);
            return -2.276 * Math.Pow(10, -5) + 95.7175 * R - 0.01 * Math.Pow(R, 2);
        }

        public override double GetDeformationIndicator1(double MNI)
        {
            double K = ConvertHelper.MNItoK(MNI);
            if (K < 0) 
            {
                return 0.52 - 3.1536 * K - 64.692 * Math.Pow(K, 2);
            }
            else if (K>0)
            {
                return 0.78 - 2.46726 * K;
            }
            return -1;
        }

        public override double GetDeformationIndicator2(double MNI)
        {
            double K = ConvertHelper.MNItoK(MNI);
            if (K < 0)
            {
                return 0.75 - 4.355 * K - 95.4879 * Math.Pow(K, 2);
            }
            else if (K > 0)
            {
                return 0.94 - 3.341855 * K;
            }
            return -1;
        }

        public override double GetRatioOfYieldStrengthToElongation(double MNI)
        {
            double K = ConvertHelper.MNItoK(MNI);
            if (K < 0)
            {
                return 1.28 + 20.67 * K + 459.62 * Math.Pow(K, 2);
            }
            else if (K > 0)
            {
                return 2.31 + 15.7951 * K;
            }
            return -1;
        }

        public override string GetSteelName()
        {
            return "Сталь 12Х1МФ";
        }

    }
}
