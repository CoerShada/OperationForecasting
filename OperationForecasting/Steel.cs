using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationForecasting
{
    abstract class Steel
    {
        public abstract double AmplitudeOfInternalStressFields();

        public abstract double ShearStresses();

        public abstract double DeformationIndicator1();

        public abstract double DeformationIndicator2();


    }
}
