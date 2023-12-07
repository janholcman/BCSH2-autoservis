using System;

namespace GUI.Objects
{
    public class Zakaznik
    {
        public int Id { get; set; }
        public String Jmeno { get; set; }
        public String Prijmeni { get; set; }
        public String JmenoFirmy { get; set; }
        public int Idadresa { get; set; }
        public String NazevUctu { get; set; }
        public String Heslo { get; set; }

        public Zakaznik(int id, string jmeno, string prijmeni, string jmenoFirmy, int adresa, string nazevUctu, string heslo)
        {
            Id = id;
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            JmenoFirmy = jmenoFirmy;
            Idadresa = adresa;
            NazevUctu = nazevUctu;
            Heslo = heslo;
        }

        public Zakaznik(int id, string jmeno, string prijmeni, string jmenoFirmy, int adresa)
        {
            Id = id;
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            JmenoFirmy = jmenoFirmy;
            Idadresa = adresa;
        }

        public Zakaznik(int id, string jmeno, string prijmeni, int adresa)
        {
            Id = id;
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Idadresa = adresa;
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
