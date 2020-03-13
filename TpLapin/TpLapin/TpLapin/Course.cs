using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpLapin
{
    class Course
    {
        private int distance;
        private List<Lapin> participer;
        public int Count {
            get { return this.distance; }
        }

        public List<Lapin> Participer
        {
            get { return this.participer; }
        }

        /*public Lapin this[int position]
        {
            get { return this.participer[position]; }
        }*/
        
        public void Add(Lapin nouveauParticipant)
        {
            this.participer.Add(nouveauParticipant);
        }

        public Course(int distance)
        {
            this.distance = distance;
            this.participer = new List<Lapin>();
        }

        public void Depart()
        {
           Console.WriteLine("Top départ !");
           for(int j=0; j<distance; j++)
            {

                for (int i =0; i < participer.Count; i++)
                {
                    Participer[i].Avancer();
                    Console.WriteLine(Participer[i].ToString());
                }
            }
        }
        public Lapin Gagnant
        {
            get
            {
                Lapin gagnant = (Lapin)participer[0];
                foreach (Lapin unLapin in participer)
                {
                    if (unLapin.Position > gagnant.Position)
                    {
                        gagnant = unLapin;
                    }
                }
                return gagnant;
            }
        }

        public List<Lapin> GetParticiper()
        {
            return this.participer;
        }

        public void RemoveAt(int position) {
            

        } 
    }
}
