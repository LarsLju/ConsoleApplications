/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public enum SpilleKort_Farve
    {
        Joker = 0,
        Spar = 1,
        Hjerter = 2,
        Ruder = 3,
        Klør = 4,
    }

    public class Spillekort
    {
        private SpilleKort_Farve _Farve;
        private byte _Værdi;

        public byte Værdi
        {
            get
            {
                return _Værdi;
            }
            set
            {
                if (value >= 1 & value <= 15)
                {
                    _Værdi = value;
                }
                else
                {
                    throw new Exception("Forkert værdi");
                }
            }
        }

        public SpilleKort_Farve Farve
        {
            get
            {
                return _Farve;
            }
            set
            {
                _Farve = value;
            }
        }

        /// <summary>
        ///  ErEs fortæller, om kortet er et Es (1 eller 14)
        ///  
        /// </summary>
        /// <returns></returns>
        public bool ErEs()
        {
            if (_Værdi == 1 | _Værdi == 14)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ErJoker()
        {
            if (_Værdi == 2 | _Værdi == 15)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ErBilledKort()
        {
            switch (Værdi)
            {
                case 11:
                    return true;
                case 12:
                    return true;
                case 13:
                    return true;
                default:
                    return false;

            }
        }

        public string Info()
        {
            return _Farve.ToString() + ' ' + _Værdi;
        }

    }

    class CSDemo
    {
        public static void Main()
        {
            // Hjerter dame
            Spillekort Kort1 = new Spillekort();
            Kort1.Farve = SpilleKort_Farve.Hjerter;
            Kort1.Værdi = 12;
            Console.WriteLine(Kort1.Info());

            // Spar 5 
            Spillekort Kort2 = new Spillekort();
            Kort2.Farve = SpilleKort_Farve.Spar;
            Kort2.Værdi = 5;
            Console.WriteLine(Kort2.Info());

            // Spar 2 Canasta
            CanastaSpilleKort Kort3 = new CanastaSpilleKort();
            Kort3.Farve = SpilleKort_Farve.Spar;
            Kort3.Værdi = 2;
            Console.WriteLine("Canasta : " + Kort3.Info());
            Console.WriteLine("Er billedkort: " + Kort3.ErBilledKort());
            Console.WriteLine("Er es: " + Kort3.ErEs());
            Console.WriteLine("Er vildkort: " + Kort3.ErVildKort());



            Console.ReadLine();


        }
    }

    public class CanastaSpilleKort : Spillekort
    {
        public bool ErVildKort()
        {
            if (Værdi == 2 | Værdi == 15)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

    }
}

*/