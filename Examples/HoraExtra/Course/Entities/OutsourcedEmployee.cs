using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    class OutsourcedEmployee : Employee
    {
      
        public double AditionalCharge { get; set; }
        public OutsourcedEmployee(double aditionalCharge, string name, int hours, double valuePerHour)
            : base (name,hours,valuePerHour)
        {
            AditionalCharge = aditionalCharge;
        }
      

        public override double Payment()
        {
            return base.Payment() + 1.1 * AditionalCharge;
        }

    }
}
