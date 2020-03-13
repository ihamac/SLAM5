using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpLapin
{
    class Program
    {
        static void Main(string[] args)
        {
            Lapin.ChangeStart(200);
            //Création de la course
            Course marathon = new Course(1000);

            //Inscription des concurrents
            marathon.Add(new Lapin("Guy", 20));
            marathon.Add(new Lapin("Matthias", 19));
            marathon.Add(new Lapin("Johan", 19));

            //Départ Course
            marathon.Depart();

            //Afficher la liste des inscrits
            //Utilisation d'un accesseur
            foreach (Lapin l in marathon.Participer) {
                Console.WriteLine(l.ToString());
            }

            /*//Utilisation de l'indexeur
            for (int i = 0; i < marathon.Count; i++)
            {
                Console.WriteLine(marathon[i].ToString());
            }*/

            //et le Gagnant est
            Lapin andTheWinnerIs = marathon.Gagnant;
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Le grand gagant est : {0}",andTheWinnerIs.Surnom);

            Console.ReadLine();
        }
    }
}
