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
        public double SigmaL { get; set; }
        public double SigmaD { get; set; }
        public double A1 { get; set; }
        public double A2 { get; set; }
        public double Ksm { get; set; }
        public double ResidualOperatingTime { get; set; }
        public string Result { get; set; }
        public string Date { get; set; }
        public double SDelta { get; set; }
        public DateTime getDate()
        {
            return DateTime.Parse(Date);
        }

        public Log() { }

        public Log(int MaterialId, double r, double k, double v, double a, double mNI, double SigmaL, double SigmaD, double A1, double A2, double SDelta, double Ksm, double ResidualOperatingTime, string Result, DateTime Date)
        {
            this.MaterialId = MaterialId;
            R = r;
            K = k;
            V = v;
            A = a;
            MNI = mNI;
            this.SigmaL = SigmaL;
            this.SigmaD = SigmaD;
            this.A1 = A1;
            this.A2 = A2;
            this.Ksm = Ksm;
            this.ResidualOperatingTime = ResidualOperatingTime;
            this.Result = Result;
            this.SDelta = SDelta;
            this.Date = Date.ToString("d", CultureInfo.CreateSpecificCulture("de-DE"));
        }

    }
}
