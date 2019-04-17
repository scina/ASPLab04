using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPLab04
{
    class Product
    {
        private string name;
        private int quantity;
        protected double netto;
        private string category;

        public Product(string name, int quantity, double netto, string category )
        {
            this.name = name;
            this.quantity = quantity;
            this.netto = netto;
            this.category = category;
        }
        public double Netto
        {
            set { netto = value; }
            get { return netto; }
        }


        public virtual double Brutto
        {
            set
            {
                netto = value / 1.23;
            }

            get
            {
                return netto * 1.23;
            }
        }

        public override string ToString()
        {
            return "Netto: " + Netto + " | Brutto: " + Brutto + " | Category: " + category;
        }
    }
}
