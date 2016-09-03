/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    // bogen side 187
    public class TvProgram
    {
        public string titel;
        public DateTime startTidspunkt;
        public TvStation station;

        public string Udskriv()
        {
            // udskrivning
            string tmp;
            tmp = string.Format("Titel  :  {0}{1}", titel, "\n ");
            tmp += string.Format("Start  :  {0:F}{1}", startTidspunkt, "\n");
            tmp += string.Format("Station:  {0}", station.Navn);
            return tmp;
        }

        public class TvStation
        {
            public string Navn;
            public string URL;
        }

        public class CSDemo
        {
            public static void Main()
            {

                // TV Station
                TvStation station = new TvStation(); // ny instans af TV Station
                station.Navn = "TV2";
                station.URL = "www.tv2.dk";

                // Nyt program
                TvProgram Program = new TvProgram(); // Program er hele programmet fra a-z, se aller øverst
                Program.titel = "Festen";
                Program.startTidspunkt = new DateTime(2004, 12, 31, 17, 30, 0);
                Program.station = station; // Station ligger inden i program

                // Hvad er oprettet?
                Console.WriteLine(Program.Udskriv());

                // Find URL på stationen
                Console.WriteLine();
                Console.WriteLine("URL på {0} er {1}", Program.station.Navn, Program.station.URL);
            }
        }
    }
}*/
