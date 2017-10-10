using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefMeerdereRelaties
{
    class Gemeente
    {
        private string _gemeenteNaam;
        private string _postCode;

        public Gemeente(string postCode, string gemeenteNaam)
        {
            GemeenteNaam = gemeenteNaam;
            PostCode = postCode;
        }

        public string GemeenteNaam { get => _gemeenteNaam; set => _gemeenteNaam = value; }
        public string PostCode { get => _postCode; set => _postCode = value; }

        public override string ToString()
        {
            return string.Format("{0} - {1}" , PostCode, GemeenteNaam);
        }

        public override bool Equals(object obj)
        {
            var gemeente = obj as Gemeente;
            return gemeente != null &&
                   GemeenteNaam == gemeente.GemeenteNaam &&
                   PostCode == gemeente.PostCode;
        }
    }
}
