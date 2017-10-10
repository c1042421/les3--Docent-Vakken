using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefMeerdereRelaties
{
    class Provincie
    {
        private string _provincieNaam;
        private List<Gemeente> _gemeentes;

        public Provincie(string provincieNaam)
        {
            ProvincieNaam = provincieNaam;
            Gemeentes = new List<Gemeente>();
        }

        public string ProvincieNaam { get => _provincieNaam; set => _provincieNaam = value; }
        private List<Gemeente> Gemeentes { get => _gemeentes; set => _gemeentes = value; }

        public void AddGemeente(Gemeente gemeente)
        {
            Gemeentes.Add(gemeente);
        }

        public void RemoveGemeente(Gemeente gemeente)
        {
            Gemeentes.Remove(gemeente);
        }

        public override string ToString()
        {
            string gemeentes = "";

            foreach (Gemeente gemeente in Gemeentes)
            {
                gemeentes += "\t" + gemeente.ToString() + Environment.NewLine;
            }


            return string.Format("Provincie {0}\n{1}",  ProvincieNaam, gemeentes);
        }
    }
}
