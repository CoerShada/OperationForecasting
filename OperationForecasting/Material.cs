using MathParser;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OperationForecasting
{
    class Material
    {
        [Key]
        public int Id { get; set; }
        public double K { get; set; }
        public string Name { get; set; }
        public string FSigmaL { get; set; }
        public string FSigmaD { get; set; }
        public string FA1 { get; set; }
        public string FA2 { get; set; }
        public string FSDelta { get; set; }

        public Material() { }

        public Material(double K, string Name, string FSigmaL, string FSigmaD, string FA1, string FA2, string FSDelta)
        {
            this.K = K;
            this.Name = Name;
            this.FSigmaL = FSigmaL;
            this.FSigmaD = FSigmaD;
            this.FA1 = FA1;
            this.FA2 = FA2;
            this.FSDelta = FSDelta;
        }

        //Важно! Добавлять в значения в порядке убывания размера названия перменной


        /// <summary>
        /// Амплитуда полей внутренних напряжений.
        /// </summary>
        /// <param name="V">скорость распространения поверхностной акустической волны, м/с.</param>
        public double GetAmplitudeOfInternalStressFields(double V)
        {
            Dictionary<string, double> values = new Dictionary<string, double>();
            if (FSigmaL.Contains("R"))
            {
                double R = Math.Round(ConvertHelper.VtoR(V), 5);
                values.Add("R", R);

            }
            else
            {
                V = Math.Round(V, 5);
                values.Add("V", V);
            }
            values.Add("K", K);

            return Parser.LoadAndCalculate(FSigmaL, values);
        }

        /// <summary>
        /// Касательные напряжения.
        /// </summary>
        /// <param name="A">размах амплитуды принятого сигнала, б.в</param>
        public double GetShearStresses(double A)
        {
            Dictionary<string, double> values = new Dictionary<string, double>();
            if (FSigmaD.Contains("R"))
            {
                double R = Math.Round(ConvertHelper.AtoR(A), 5);

                values.Add("R", R);
            }
            else
            {
                A = Math.Round(A, 5);
                values.Add("A", A);
            }
            values.Add("K", K);

            return Parser.LoadAndCalculate(FSigmaD, values);
        }

        /// <summary>
        /// Доля деформации, накопленная в образце до появления устойчивой зоны локализации деформации, от всей деформации материала до разрушения.
        /// </summary>
        /// <param name="MNI">интенсивность магнитного шума, б.в</param>
        public double GetDeformationIndicator1(double MNI)
        {
            Dictionary<string, double> values = new Dictionary<string, double>();
            if (FA1.Contains("Kzat"))
            {
                double Kzat = Math.Round(ConvertHelper.MNItoK(MNI), 5);
                values.Add("Kzat", Kzat);
            }
            else
            {
                MNI = Math.Round(ConvertHelper.MNItoK(MNI), 5);
                values.Add("MNI", MNI);
            }
            values.Add("K", K);

            return Parser.LoadAndCalculate(FA1, values);
        }

        /// <summary>
        /// Доля деформации, накопленная в образце до появления устойчивой зоны лока-лизации деформации, до начала падающей части кривой нагружения (коллапса автоволны) 
        /// </summary>
        /// <param name="MNI">интенсивность магнитного шума, б.в</param>
        public double GetDeformationIndicator2(double MNI)
        {
            Dictionary<string, double> values = new Dictionary<string, double>();
            if (FA2.Contains("Kzat"))
            {
                double Kzat = Math.Round(ConvertHelper.MNItoK(MNI), 5);
                values.Add("Kzat", Kzat);
            }
            else
            {
                MNI = Math.Round(ConvertHelper.MNItoK(MNI), 5);
                values.Add("MNI", MNI);
            }
            values.Add("K", K);

            return Parser.LoadAndCalculate(FA2, values);
        }

        /// <summary>
        /// Отношение предела текучести к удлинению 
        /// </summary>
        /// <param name="MNI">интенсивность магнитного шума, б.в</param>
        public double GetRatioOfYieldStrengthToElongation(double MNI)
        {
            Dictionary<string, double> values = new Dictionary<string, double>();
            if (FSDelta.Contains("Kzat"))
            {
                double Kzat = Math.Round(ConvertHelper.MNItoK(MNI), 5);
                values.Add("Kzat", Kzat);
            }
            else
            {
                MNI = Math.Round(ConvertHelper.MNItoK(MNI), 5);
                values.Add("MNI", MNI);
            }
            values.Add("K", K);

            return Parser.LoadAndCalculate(FSDelta, values);
        }

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
            return (CurrentTime * (this.K - Kcm)) / Kcm;
        }

        public string GetName()
        {
            return Name;
        }

        public int GetId()
        {
            return Id;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
