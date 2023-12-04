using System;

namespace GUI.Objects
{
    internal class Zakaznik
    {
        int Id { get; set; }
        String Jmeno { get; set; }
        String Prijmeni { get; set; }
        String JmenoFirmy { get; set; }
        Adresa Adresa { get; set; }

        public Zakaznik(int id, string jmeno, string prijmeni, string jmenoFirmy, Adresa adresa)
        {
            Id = id;
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            JmenoFirmy = jmenoFirmy;
            Adresa = adresa;
        }

        public Zakaznik(int id, string jmeno, string prijmeni, Adresa adresa)
        {
            Id = id;
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Adresa = adresa;
        }
    }
}
