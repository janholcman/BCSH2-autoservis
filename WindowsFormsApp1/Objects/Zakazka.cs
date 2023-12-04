using System;

namespace GUI.Objects
{
    internal class Zakazka
    {
        int Id { get; set; }
        DateTime StartZakazka { set; get; }
        DateTime KonecZakazka { set; get; }
        Zamestnanec Zamestnanec { get; set; }

        public Zakazka(int id, DateTime startZakazka, DateTime konecZakazka, Zamestnanec zamestnanec)
        {
            Id = id;
            StartZakazka = startZakazka;
            KonecZakazka = konecZakazka;
            Zamestnanec = zamestnanec;
        }

        public Zakazka(int id, DateTime startZakazka, Zamestnanec zamestnanec)
        {
            Id = id;
            StartZakazka = startZakazka;
            Zamestnanec = zamestnanec;
        }
    }
}
