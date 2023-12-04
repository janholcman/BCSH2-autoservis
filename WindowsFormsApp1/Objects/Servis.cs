using System;

namespace GUI.Objects
{
    internal class Servis
    {
        int Id { get; set; }
        DateTime DatumServisu { get; set; }
        Automobil Automobil { get; set; }
        Zamestnanec Zamestnanec { get; set; }
        Zakazka Zakazka { get; set; }

        public Servis(int id, DateTime datumServisu, Automobil automobil, Zamestnanec zamestnanec, Zakazka zakazka)
        {
            Id = id;
            DatumServisu = datumServisu;
            Automobil = automobil;
            Zamestnanec = zamestnanec;
            Zakazka = zakazka;
        }

        public Servis(int id, Automobil automobil, Zamestnanec zamestnanec, Zakazka zakazka)
        {
            Id = id;
            Automobil = automobil;
            Zamestnanec = zamestnanec;
            Zakazka = zakazka;
        }
    }
}
