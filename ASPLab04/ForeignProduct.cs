using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPLab04
{
    class ForeignProduct : Product
    {
        private double duty;

        public ForeignProduct(string name, int quantity, double netto, string category, double duty) : base(name, quantity, netto, category)
        {
            this.duty = duty;
        }

        public override double Brutto {
            get
            {
                //return base.Brutto * (1 + duty / 100);
                return base.Brutto * (1 + duty/100);
                
            }
            set
            {
                netto = base.Brutto / (1 + duty / 100); 
            }
        }

        public override string ToString()
        {
            return "Netto: " + Netto + " | Brutto: " + Brutto + "| Duty: " + duty;
        }

    }
}
