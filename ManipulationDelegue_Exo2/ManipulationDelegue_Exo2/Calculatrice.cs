using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulationDelegue_Exo2
{
    class Calculatrice
    {
        delegate int PrototypeOperation(int i, int j);
        PrototypeOperation dOperation;
        private List<int> lesNombres = new List<int>();
        public Calculatrice()
        {
            this.lesNombres = lesNombres;
        }

        public int Addition(int n1, int n2)
        {
            int resultat = 0;
            resultat = n1 + n2;
            return resultat;
        }
        public int Soustraction(int n1, int n2)
        {
            int resultat = 0;
            resultat = n1 - n2;
            return resultat;
        }
        public int Multiplication(int n1, int n2)
        {
            int resultat = 0;
            resultat = n1 * n2;
            return resultat;
        }
        public int Division(int n1, int n2)
        {
            int resultat = 0;
            resultat = n1 / n2;
            if(n2 == 0)
            {
                throw new Exception("Impossible de diviser un nombre par 0");
            }
            return resultat;
        }
        public int Calculer()
        {
            int result = lesNombres[0];
            int i = 0;
            foreach (PrototypeOperation uneOperation in dOperation.GetInvocationList())
            { 
                result = dOperation(result, lesNombres[i]);
            }
            return result;
        }
        
        public void ChoixOpération(Choix choix)
        {
            switch (choix)
            {
                case Choix.Addition:
                    dOperation += Addition;
                    break;
                case Choix.Soustraction:
                    dOperation += Soustraction;
                    break;
                case Choix.Multiplication:
                    dOperation += Multiplication;
                    break;
                case Choix.Division:
                    dOperation += Division;
                    break;
            }
        }

        public void Add(int n)
        {
            lesNombres.Add(n);
        }
    }
}
