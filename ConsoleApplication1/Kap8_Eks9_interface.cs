/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ConsoleApplication1
    {
        public interface IDyr
        {
            string Navn
            {
                get;
                set;
            }

            string Lyd();
        }

        public class Hund : IDyr
        {
            private string _Navn;

            public string Navn
            {
                get
                {
                    return _Navn;
                }
                set
                {
                    _Navn = value;
                }
            }

            public string Lyd()
            {
                return "Vov vov (sniffe) (sniffe)";
            }

            public Hund(string Navn)
            {
                _Navn = Navn;
            }

            public class CSDemo
            {
                static void Main()
                {
                    Hund minHund = new Hund("Kvik");
                    Console.WriteLine("Jeg hedder " + minHund.Navn + ", og jeg siger " + minHund.Lyd());
                }
            }
        }
    }
}*/
