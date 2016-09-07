using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public abstract class Dyr
    {
        public string Navn;


        public abstract string Lyd();

        public Dyr(string Navn)
        {
            this.Navn = Navn;
        }

        public class Hund : Dyr
        {
            public override string Lyd()
            {
                return "Vov vov (sniffe sniffe)";
            }

            public Hund(String Navn) : base(Navn)
            // "base" kan bruges som this, men her til at tilgå en constructor i superklassen
            {

            }
        }

        public class Kat : Dyr
        {
            public override string Lyd()
            {
                return "Mijau mijau (spinde spinde)";
            }

            public Kat(String Navn) : base(Navn)
            {

            }
        }

        public class CSDemo
        {
            static void Main()
            {
                // Array af dyr
                Dyr[] ArrayAfDyr = new Dyr[6];
                ArrayAfDyr[0] = new Hund("Trisse");
                ArrayAfDyr[1] = new Kat("Gizmo");
                ArrayAfDyr[2] = new Hund("Nala");
                ArrayAfDyr[3] = new Kat("Trunte");
                ArrayAfDyr[4] = new Hund("Kvik");
                ArrayAfDyr[5] = new Kat("Guitarkatten");

                //Løb arrayet igennem og se, hvad der er

                // Flere ændringer i linje 63
                foreach (Dyr mitDyr in ArrayAfDyr)
                {
                    Console.WriteLine("Mit navn er " + mitDyr.Navn + ". Jeg siger " + mitDyr.Lyd());
                }
            }
        }
    }
}