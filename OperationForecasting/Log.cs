using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace OperationForecasting
{
    class Log
    {
        [Key]
        public int id { get; set; }
        public string steel_name { get; set; }
        public double R { get; set; }
        public double K { get; set; }
        public double V { get; set; }
        public double A { get; set; }
        public double MNI { get; set; }
        public double amplitude_of_internal_stress_fields { get; set; }
        public double shear_stresses { get; set; }
        public double deformation_indicator_1 { get; set; }
        public double deformation_indicator_2 { get; set; }
        public double coef_structural_mechanical { get; set; }
        public double residual_operating_time { get; set; }
        public string result { get; set; }
        public string date { get; set; }
        public double ratio_of_yield_strength_to_elongation { get; set; }
        public DateTime getDate()
        {
            return DateTime.Parse(date);
        }

        public Log() { }

        public Log(string steel_name, double r, double k, double v, double a, double mNI, double amplitude_of_internal_stress_fields, double shear_stresses, double deformation_indicator_1, double deformation_indicator_2, double ratio_of_yield_strength_to_elongation, double coef_structural_mechanical, double residual_operating_time, string result, DateTime date)
        {
            this.steel_name = steel_name;
            R = r;
            K = k;
            V = v;
            A = a;
            MNI = mNI;
            this.amplitude_of_internal_stress_fields = amplitude_of_internal_stress_fields;
            this.shear_stresses = shear_stresses;
            this.deformation_indicator_1 = deformation_indicator_1;
            this.deformation_indicator_2 = deformation_indicator_2;
            this.coef_structural_mechanical = coef_structural_mechanical;
            this.residual_operating_time = residual_operating_time;
            this.result = result;
            this.ratio_of_yield_strength_to_elongation= ratio_of_yield_strength_to_elongation;
            this.date = date.ToString("d", CultureInfo.CreateSpecificCulture("de-DE"));
        }

    }
}
