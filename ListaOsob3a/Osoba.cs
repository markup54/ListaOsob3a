using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaOsob3a
{
    public class Osoba : ICloneable
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Wiek { get; set; }
        public string Miasto { get; set; }

        public Osoba(string imie, string nazwisko, int wiek, string miasto)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Wiek = wiek;
            Miasto = miasto;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
