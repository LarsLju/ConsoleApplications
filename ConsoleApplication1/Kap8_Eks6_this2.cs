/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Person
    {
        // Offentlige felter
        public string Fornavn;
        public string Efternavn;

        // constructor
        public Person(string Fornavn, string Efternavn)
        {
            this.Fornavn = Fornavn;
            this.Efternavn = Efternavn;
        }

        // ny constructor med mellemnavn
        public Person(string Fornavn, string Mellemnavn, string Efternavn) : this(Fornavn + " " + Mellemnavn, Efternavn)
        {
            // constructorkald sendes videre til anden construktor
            // - Person(string, string)
        }

        public override string ToString()
        {
            return this.Fornavn + " " + this.Efternavn;
        }

        public class CSDemo
        {
            static void Main()
            {
                Person person = new Person("Egon", "Olsenbanden", "Olsen");
                Console.WriteLine(person.ToString());
            }
        }
    }
}*/
