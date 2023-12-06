using System;

namespace GUI.Objects
{
    internal class Zakaznik
    {
        int Id { get; set; }
        public String Jmeno { get; set; }
        public String Prijmeni { get; set; }
        public String JmenoFirmy { get; set; }
        public Adresa Adresa { get; set; }

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
        public Zakaznik(string jmeno, string prijmeni, String JmenoFirmy = "")
        {
            this.Jmeno = jmeno;
            this.Prijmeni = prijmeni;
            this.JmenoFirmy = JmenoFirmy;
        }

        public override string ToString()
        {
            return Jmeno + " " + Prijmeni + " - " + JmenoFirmy;
        }
    }
}
