using System;

namespace GUI.Objects
{
    internal class Zamestnanec
    {
        int Id { get; set; }
        public String Jmeno { get; set; }
        public String Prijmeni { set; get; }
        public String RodneCislo { get; set; }
        public DateTime DatumNastupu { get; set; }
        public float HodinovaMzda { get; set; }
        public float Mzda { get; set; }
        public Pozice Pozice { get; set; }

        public Zamestnanec(int id, string jmeno, string prijmeni, string rodneCislo, DateTime datumNastupu, float hodinovaMzda, float mzda, Pozice pozice)
        {
            Id = id;
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            RodneCislo = rodneCislo;
            DatumNastupu = datumNastupu;
            HodinovaMzda = hodinovaMzda;
            Mzda = mzda;
            Pozice = pozice;
        }

        public Zamestnanec(string jmeno, string prijmeni)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
        }

        public override string ToString()
        {
            return Jmeno + " " + Prijmeni;
        }
    }
}
