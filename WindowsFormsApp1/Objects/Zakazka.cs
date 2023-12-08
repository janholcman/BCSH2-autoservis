using System;

namespace GUI.Objects
{
    public class Zakazka
    {
        public int Id { get; set; }
        public DateTime StartZakazka { set; get; }
        public DateTime KonecZakazka { set; get; }
        public int Zamestnanec { get; set; }

        public Zakazka(int id, DateTime startZakazka, DateTime konecZakazka, int zamestnanec)
        {
            Id = id;
            StartZakazka = startZakazka;
            KonecZakazka = konecZakazka;
            Zamestnanec = zamestnanec;
        }

        public Zakazka(int id, DateTime startZakazka, int zamestnanec)
        {
            Id = id;
            StartZakazka = startZakazka;
            Zamestnanec = zamestnanec;
        }
    }
}
