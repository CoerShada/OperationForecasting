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

        /// <summary>
        /// Амплитуда полей внутренних напряжений.
        /// </summary>
        /// <param name="R">время задержки поверхностной акустической волны, нс.</param>
        public abstract double GetAmplitudeOfInternalStressFields(double R);

        /// <summary>
        /// Касательные напряжения.
        /// </summary>
        /// <param name="R">время задержки поверхностной акустической волны, нс.</param>
        public abstract double GetShearStresses(double R);

        /// <summary>
        /// Доля деформации, накопленная в образце до появления устойчивой зоны лока-лизации деформации, от всей деформации материала до разрушения.
        /// </summary>
        /// <param name="K">коэффициент затухания поверхностной акустической волны, 1/мкс.</param>
        public abstract double GetDeformationIndicator1(double K);

        /// <summary>
        /// Доля деформации, накопленная в образце до появления устойчивой зоны лока-лизации деформации, до начала падающей части кривой нагружения (коллапса автоволны) 
        /// </summary>
        /// <param name="K">коэффициент затухания поверхностной акустической волны, 1/мкс.</param>
        public abstract double GetDeformationIndicator2(double K);

        /// <summary>
        /// Отношение предела текучести к удлинению 
        /// </summary>
        /// <param name="K">коэффициент затухания поверхностной акустической волны, 1/мкс.</param>
        public abstract double GetRatioOfYieldStrengthToElongation(double K);

        public double GetCoefStructuralMechanical(double R, double K)
        {
            double tl = GetAmplitudeOfInternalStressFields(R);
            double td = GetShearStresses(R);
            double a1 = GetDeformationIndicator1(K);
            double a2 = GetDeformationIndicator2(K);

            return (tl / td) * ((a2 - a1) / (a1 + a2) * Math.Log(GetRatioOfYieldStrengthToElongation(K)));
        }

        /*public sealed double RemainingRunningTime()
        {
            return 
        }*/

    }
}
