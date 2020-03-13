using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismeExo2
{
    abstract class Vehicule
    {
        private string immatriculation;
        List<Option> optionsBase;

        public Vehicule(string immatriculation)
        {
            this.immatriculation = immatriculation;
            optionsBase = new List<Option>();
        }

        public void AddOption(Option option)
        {
            optionsBase.Add(option);
        }

       public bool possèdeOption(string libelle)
        {
            for(int i=0; i < optionsBase.Count; i++)
            {
                if (libelle == optionsBase[i].GetLibelle())
                {
                    return true;
                }
            }
            return false;
        }

        public Option this[int index]
        {
            get { return this.optionsBase[index];
            }
        }

        public int Count
        {
            get
            {
                return this.optionsBase.Count;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.immatriculation, this.optionsBase);
        }
    }
}
