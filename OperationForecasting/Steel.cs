using System;


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
        /// <param name="V">скорость распространения поверхностной акустической волны, м/с.</param>
        public abstract double GetAmplitudeOfInternalStressFields(double V);

        /// <summary>
        /// Касательные напряжения.
        /// </summary>
        /// <param name="A">размах амплитуды принятого сигнала, б.в</param>
        public abstract double GetShearStresses(double A);

        /// <summary>
        /// Доля деформации, накопленная в образце до появления устойчивой зоны лока-лизации деформации, от всей деформации материала до разрушения.
        /// </summary>
        /// <param name="MNI">интенсивность магнитного шума, б.в</param>
        public abstract double GetDeformationIndicator1(double MNI);

        /// <summary>
        /// Доля деформации, накопленная в образце до появления устойчивой зоны лока-лизации деформации, до начала падающей части кривой нагружения (коллапса автоволны) 
        /// </summary>
        /// <param name="MNI">интенсивность магнитного шума, б.в</param>
        public abstract double GetDeformationIndicator2(double MNI);

        /// <summary>
        /// Отношение предела текучести к удлинению 
        /// </summary>
        /// <param name="MNI">интенсивность магнитного шума, б.в</param>
        public abstract double GetRatioOfYieldStrengthToElongation(double MNI);

        /// <summary>
        /// Структурно-механический критерий
        /// </summary>
        /// <param name="MNI">интенсивность магнитного шума, б.в</param>
        public double CoefStructuralMechanical(double sigmaL, double sigmaD, double a1, double a2, double SGamma)
        {

            return (sigmaL / sigmaD) * ((a2 - a1) / (a1 + a2) * Math.Log(SGamma));
        }

        public double RemainingRunningTime(double CurrentTime, double sigmaL, double sigmaD, double a1, double a2, double SGamma)
        {
            double Kcm = CoefStructuralMechanical(sigmaL, sigmaD, a1, a2, SGamma);
            return (CurrentTime * (this._CoefRatio - Kcm)) / Kcm;
        }

        public abstract string GetSteelName();

    }
}
