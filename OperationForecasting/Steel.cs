using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationForecasting
{
    abstract class Steel
    {

        private double _CoefRatio;

        public Steel(double CoefRatio)
        {
            _CoefRatio = CoefRatio;
        }

        public abstract double GetAmplitudeOfInternalStressFields();

        public abstract double GetShearStresses();

        public abstract double GetDeformationIndicator1();

        public abstract double GetDeformationIndicator2();

        public abstract double GetRatioOfYieldStrengthToElongation();

        public double GetCoefStructuralMechanical()
        {
            double tl = GetAmplitudeOfInternalStressFields();
            double td = GetShearStresses();
            double a1 = GetDeformationIndicator1();
            double a2 = GetDeformationIndicator2();

            return (tl / td) * ((a2 - a1) / (a1 + a2) * Math.Log(GetRatioOfYieldStrengthToElongation());
        }

        /*public sealed double RemainingRunningTime()
        {
            return 
        }*/

    }
}
