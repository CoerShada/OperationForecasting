namespace OperationForecasting
{
    class Steel20 : Steel
    {

        public Steel20(double CoefRatio) : base(CoefRatio) { }
      

        public override double GetAmplitudeOfInternalStressFields(double V)
        {
            return -2371.44 + 0.7080649 * V;
        }

        public override double GetShearStresses(double A)
        {
            return 535.56 - 0.744254329 * A;
        }

        public override double GetDeformationIndicator1(double MNI)
        {
            return 2.04 - 0.0049163803 * MNI;
        }

        public override double GetDeformationIndicator2(double MNI)
        {
            return 2.25-0.005016609 * MNI;
        }

        public override double GetRatioOfYieldStrengthToElongation(double MNI)
        {
            return 0.04807765 * MNI - 12.6526;
        }

        public override string GetSteelName()
        {
            return "Сталь 20";
        }
    }
}
