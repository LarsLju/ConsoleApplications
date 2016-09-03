/*
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
                Hund minHund = new Hund("Nala");
                Console.WriteLine("Jeg er en hund og hedder " + minHund.Navn + ", og jeg siger " + minHund.Lyd());
                Kat minKat = new Kat("Gabriel");
                Console.WriteLine("Jeg er en kat og hedder " + minKat.Navn + ", og jeg siger " + minKat.Lyd());
            }
        }
    }
}
*/