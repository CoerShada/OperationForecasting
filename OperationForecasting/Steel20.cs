using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationForecasting
{
    class Steel20 : Steel
    {

        public Steel20(double CoefRatio) : base(CoefRatio) { }
      

        public override double GetAmplitudeOfInternalStressFields(double R)
        {
            return -2371.44 + 0.7080649 * (R * 0.018);
        }

        public override double GetShearStresses(double R)
        {
            return 535.56 - 0.744254329 * R;//Добавить коэфициент к R
        }

        public override double GetDeformationIndicator1(double K)
        {
            return 2.04 - 0.0049163803 * K;
        }

        public override double GetDeformationIndicator2(double K)
        {
            return 2.25-0.005016609 * K;
        }

        public override double GetRatioOfYieldStrengthToElongation(double K)
        {
            return 0.04807765*K - 12.6526;
        }


    }
}
