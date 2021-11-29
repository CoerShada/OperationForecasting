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
        public abstract double GetAmplitudeOfInternalStressFields(double V);

        /// <summary>
        /// Касательные напряжения.
        /// </summary>
        /// <param name="R">время задержки поверхностной акустической волны, нс.</param>
        public abstract double GetShearStresses(double A);

        /// <summary>
        /// Доля деформации, накопленная в образце до появления устойчивой зоны лока-лизации деформации, от всей деформации материала до разрушения.
        /// </summary>
        /// <param name="K">коэффициент затухания поверхностной акустической волны, 1/мкс.</param>
        public abstract double GetDeformationIndicator1(double MNI);

        /// <summary>
        /// Доля деформации, накопленная в образце до появления устойчивой зоны лока-лизации деформации, до начала падающей части кривой нагружения (коллапса автоволны) 
        /// </summary>
        /// <param name="K">коэффициент затухания поверхностной акустической волны, 1/мкс.</param>
        public abstract double GetDeformationIndicator2(double MNI);

        /// <summary>
        /// Отношение предела текучести к удлинению 
        /// </summary>
        /// <param name="K">коэффициент затухания поверхностной акустической волны, 1/мкс.</param>
        public abstract double GetRatioOfYieldStrengthToElongation(double MNI);

        public double GetCoefStructuralMechanical(double V, double MNI, double A)
        {
            double tl = GetAmplitudeOfInternalStressFields(V);
            if (A == -100)
            {
                A = V;
            }

            double td = GetShearStresses(A);
            double a1 = GetDeformationIndicator1(MNI);
            double a2 = GetDeformationIndicator2(MNI);

            //Console.WriteLine(td);
            //Console.WriteLine(MNI);
            Console.WriteLine((tl / td) * ((a2 - a1) / (a1 + a2) * Math.Log(GetRatioOfYieldStrengthToElongation(MNI))));

            return (tl / td) * ((a2 - a1) / (a1 + a2) * Math.Log(GetRatioOfYieldStrengthToElongation(MNI)));
        }

        public double RemainingRunningTime(double CurrentTime, double V, double MNI, double A)
        {
            double Kcm = GetCoefStructuralMechanical(V, MNI, A);
            return (CurrentTime * (this._CoefRatio - Kcm)) / Kcm;
        }

        public abstract string GetSteelName();

    }
}
