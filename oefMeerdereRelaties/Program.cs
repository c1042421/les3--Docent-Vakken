using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefMeerdereRelaties
{
    class Program
    {
        static void Main(string[] args)
        {
            //DOCENT - VAK
            Docent jelmar = new Docent("Dhr. Van Aert");

            Vak mm = new Vak("MM", 60, "D112");

            jelmar.AddVak(new Vak("PR1", 120, "D101"));
            jelmar.AddVak(new Vak("PR3", 120, "D104"));
            jelmar.AddVak(new Vak("PR4", 120, "D104"));
            jelmar.AddVak(mm);

            Console.WriteLine(jelmar.ToString());

            jelmar.RemoveVak(mm);

            Console.WriteLine("na het verwijderen van MM");
            Console.WriteLine(jelmar.ToString());

            Console.WriteLine(Environment.NewLine + Environment.NewLine);

            //PROVINCIE - GEMEENTE
            Provincie antwerpen = new Provincie("Antwerpen");
            Gemeente wuustwezel = new Gemeente("2990", "Wuustwezel");
            antwerpen.AddGemeente(wuustwezel);
            antwerpen.AddGemeente(new Gemeente("2960", "Brecht"));

            Console.WriteLine(antwerpen.ToString());

            antwerpen.RemoveGemeente(wuustwezel);

            Console.WriteLine("na het verwijderen van Wuustwezel");
            Console.WriteLine(antwerpen.ToString());

            Console.ReadLine();
        }
    }
}
