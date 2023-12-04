using System;

namespace GUI.Objects
{
    internal class Zamestnanec
    {
        int Id { get; set; }
        String Jmeno { get; set; }
        String Prijmeni { set; get; }
        String RodneCislo { get; set; }
        DateTime DatumNastupu { get; set; }
        float HodinovaMzda { get; set; }
        float Mzda { get; set; }
        Pozice Pozice { get; set; }

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
    }
}
