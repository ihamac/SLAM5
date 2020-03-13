using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulationDesDelegues
{
    class Program
    {
        delegate void Prototype1(int i, string s);
        delegate void Prototype2(int i, int i1, int i2);
        delegate void Prototype3(string s, string s1, string s3);
        delegate void Prototype4(double d, string s);
        delegate void Prototype5(string s, string s2, int i);
        delegate int Prototype6();
        delegate string Prototype7(int i);
        delegate double Prototype8();
        delegate decimal Prototype9(decimal d, decimal d1);
        delegate int Prototype10(string s, string s1, string s2);
        delegate bool Prototype11(int i, string s);
        delegate DateTime Prototype12(double d, string s);
        delegate double Prototype13(bool b, bool b1);
        delegate int Prototype14(int i, DateTime dt);

        static void Main(string[] args)
        {
            Prototype1 d1 = null;
            d1 += p1;
            d1 += p4;
            d1 += p7;

            Prototype2 d2 = null;
            d2 += p2;
            d2 += p5;
            d2 += p9;

            Prototype3 d3 = null;
            d3 += p3;

            Prototype4 d4 = null;
            d4 += p8;

            Prototype5 d5 = null;
            d5 += p6;

            foreach(Prototype1 unD in d1.GetInvocationList())
            {
                unD.Invoke(13,"Salut");
            }
            Console.ReadLine();
        }

        static void p1(int i1, string s1)
        {
            Console.WriteLine("Je suis P1");
            Console.WriteLine("La valeur de mes paramètres est {0} - {1}", i1, s1);
        }

        static void p2(int i1, int i2, int i3)
        {
            Console.WriteLine("Je suis P2");
            Console.WriteLine("La valeur de mes paramètres est {0} - {1} - {2}", i1, i2, i3);
        }

        static void p3(string s1, string s2, string s3)
        {
            Console.WriteLine("Je suis P3");
            Console.WriteLine("La valeur de mes paramètres est {0} - {1} - {2}", s1, s2, s3);
        }

        static void p4(int i1, string s)
        {
            Console.WriteLine("Je suis P4");
            Console.WriteLine("La valeur de mes paramètres est {0} - {1}", i1, s);
        }

        static void p5(int i1, int i2, int i3)
        {
            Console.WriteLine("Je suis P5");
            Console.WriteLine("La valeur de mes paramètres est {0} - {1} - {2}", i1, i2, i3);
        }

        static void p6(string s1, string s2, int i3)
        {
            Console.WriteLine("Je suis P6");
            Console.WriteLine("La valeur de mes paramètres est {0} - {1} - {2}", s1, s2, i3);
        }

        static void p7(int i1, string s1)
        {
            Console.WriteLine("Je suis P7");
            Console.WriteLine("La valeur de mes paramètres est {0} - {1}", i1, s1);
        }
        static void p8(double d1, string s1)
        {
            Console.WriteLine("Je suis P8");
            Console.WriteLine("La valeur de mes paramètres est {0} - {1}", d1, s1);
        }

        static void p9(int j, int k, int l)
        {
            Console.WriteLine("Je suis P9");
            Console.WriteLine("La valeur de mes paramètres est {0} - {1} - {2}", j, k, l);
        }

        static int f1()
        {
            Console.WriteLine("Je suis F1 et je suis vide");
            return 0;
        }

        static string f2(int i)
        {
            Console.WriteLine("Je suis F1");
            Console.WriteLine("La valeur de mes paramètres est {0}", i);
            return "coucou";
        }
        static double f3()
        {
            Console.WriteLine("Je suis F3 et je suis vide");
            return 0.0;
        }
        static decimal f4(decimal d1, decimal d2)
        {
            Console.WriteLine("Je suis F4");
            Console.WriteLine("La valeur de mes paramètres est {0} - {1}", d1, d2);
            return d1 + d2;
        }

        static int f5(string s1, string s2, string s3)
        {
            Console.WriteLine("Je suis F5");
            Console.WriteLine("La valeur de mes paramètres est {0} - {1} - {2}", s1, s2, s3);
            return 0;
        }
        static bool f6(int i, string s)
        {
            Console.WriteLine("Je suis F6");
            Console.WriteLine("La valeur de mes paramètres est {0} - {1}", i, s);
            return true;
        }

        static DateTime f7(double d1, string s)
        {
            Console.WriteLine("Je suis P1");
            Console.WriteLine("La valeur de mes paramètres est {0} - {1}", d1, s);
            DateTime d3 = new DateTime();
            return d3;
        }

        static double f8(bool b1, bool b2)
        {
            Console.WriteLine("Je suis P1");
            Console.WriteLine("La valeur de mes paramètres est {0} - {1}", b1, b2);
            return 0.0;
        }
        static int f9(int i, DateTime dt)
        {
            Console.WriteLine("Je suis F9");
            Console.WriteLine("La valeur de mes paramètres est {0} - {1}", i, dt);
            return 0;
        }
    }
}
