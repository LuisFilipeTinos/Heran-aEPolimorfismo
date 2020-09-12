using System;
using System.Collections.Generic;
using System.Text;

namespace HerançaEPolimorfismo.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) 
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            return ValuePerHour * Hours + AdditionalCharge * 1.1;

        }
    }
}
