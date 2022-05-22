using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace OperationForecasting
{
    class Log
    {
        [Key]
        public int Id { get; set; }
        public int MaterialId { get; set; }
        public double R { get; set; }
        public double K { get; set; }
        public double V { get; set; }
        public double A { get; set; }
        public double MNI { get; set; }
        public double AmplitudeOfOnternalStressFields { get; set; }
        public double ShearStresses { get; set; }
        public double DeformationIndicator1 { get; set; }
        public double DeformationIndicator2 { get; set; }
        public double CoefStructuralMechanical { get; set; }
        public double ResidualOperatingTime { get; set; }
        public string Result { get; set; }
        public string Date { get; set; }
        public double RatioOfYieldStrengthToElongation { get; set; }
        public DateTime getDate()
        {
            return DateTime.Parse(Date);
        }

        public Log() { }

        public Log(int MaterialId, double r, double k, double v, double a, double mNI, double AmplitudeOfOnternalStressFields, double ShearStresses, double DeformationIndicator1, double DeformationIndicator2, double RatioOfYieldStrengthToElongation, double CoefStructuralMechanical, double ResidualOperatingTime, string Result, DateTime Date)
        {
            this.MaterialId = MaterialId;
            R = r;
            K = k;
            V = v;
            A = a;
            MNI = mNI;
            this.AmplitudeOfOnternalStressFields = AmplitudeOfOnternalStressFields;
            this.ShearStresses = ShearStresses;
            this.DeformationIndicator1 = DeformationIndicator1;
            this.DeformationIndicator2 = DeformationIndicator2;
            this.CoefStructuralMechanical = CoefStructuralMechanical;
            this.ResidualOperatingTime = ResidualOperatingTime;
            this.Result = Result;
            this.RatioOfYieldStrengthToElongation = RatioOfYieldStrengthToElongation;
            this.Date = Date.ToString("d", CultureInfo.CreateSpecificCulture("de-DE"));
        }

    }
}
