using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefMeerdereRelaties
{
    class Vak
    {
        private string _beschrijving;
        private string _leslokaal;
        private int _lesuren;

        public Vak(string beschrijving, int lesuren, string leslokaal)
        {
            Beschrijving = beschrijving;
            Leslokaal = leslokaal;
            Lesuren = lesuren;
        }

        public string Leslokaal { get => _leslokaal; set => _leslokaal = value; }
        public int Lesuren { get => _lesuren; set => _lesuren = value; }
        public string Beschrijving { get => _beschrijving; set => _beschrijving = value; }

        public override bool Equals(object obj)
        {
            var vak = obj as Vak;
            return vak != null &&
                   Lesuren == vak.Lesuren &&
                   Beschrijving == vak.Beschrijving;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", Beschrijving, Lesuren, Leslokaal);
        }
    }
}
