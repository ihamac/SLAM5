using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismeExo2
{
    class Option
    {
        private string libellé;
        private double prix;

        public Option(string libellé, double prix)
        {
            this.libellé = libellé;
            this.prix = prix;
        }

        public string GetLibelle()
        {
            return libellé;
        }

        public double GetPrix()
        {
            return prix;
        }

        public new string ToString()
        {
            return string.Format("{0} {1}", this.libellé, this.prix);
        }
    }
}
