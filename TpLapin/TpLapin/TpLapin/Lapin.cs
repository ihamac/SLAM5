using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpLapin
{
    class Lapin
    {
        private int age;
        private static Random aleatoire = new Random();
        private int position;
        private string surnom;
        private static int comptage;
        private int dossard;
        private static int pas;

        public int Dossard
        {
            get
            {
                return this.dossard;
            }

            set
            {
                dossard = value;
            }
        }

        private int Pas
        {
            get
            {
                return Lapin.pas;

            }

            set
            {
                pas = value;
            }
        }

        static Lapin()
        {
            Lapin.comptage = 1000;
            Lapin.pas = 10;
        }
        public static void ChangeStart(int start)
        {
            Lapin.comptage = start;
        }
        public int Age
        {
            get { return this.age; }
            set { age = value; }
        }
        public int Position {
            get { return this.position; }
        }

        public string Surnom {
            get { return this.surnom; }
        }


        public void Avancer()
        {
                int random = Lapin.aleatoire.Next(0, 6);
                this.position = this.position + random; 
        }
        public Lapin(string surnom, int age) {
            this.surnom = surnom;
            this.age = age;
     
            this.dossard = Lapin.comptage + Lapin.pas;
            Lapin.comptage = Lapin.comptage + Lapin.pas;


        }
        public string ToString()
        {
            return string.Format("- {0} a {1}ans, est à la position {2} avec le dossard n°{3}", this.surnom, this.age, this.position, this.dossard);
        }
    }
}
