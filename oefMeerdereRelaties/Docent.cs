using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefMeerdereRelaties
{
    class Docent
    {
        private string _naam;
        private List<Vak> _vakken;

        public Docent(string naam)
        {
            Naam = naam;
            Vakken = new List<Vak>();
        }

        public string Naam { get => _naam; set => _naam = value; }
        private List<Vak> Vakken { get => _vakken; set => _vakken = value; }

        public void AddVak(Vak vak)
        {
            Vakken.Add(vak);
        }

        public void RemoveVak(Vak vak)
        {
            Vakken.Remove(vak);
        }

        public override string ToString()
        {
            string vakken = "";

            foreach (Vak vak in Vakken)
            {
                vakken += vak.ToString() + Environment.NewLine;
            }

            return string.Format("{0} geeft de volgende vakken:\n{1}", Naam, vakken);
        }
    }
}
