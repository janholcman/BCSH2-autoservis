using System;

namespace GUI.Objects
{
    internal class Automobil
    {

        int Id { get; set; }
        String Vin { get; set; }
        String Spz { get; set; }
        int RokVyroby { get; set; }
        Model Znacka { get; set; }
        Pojistovna Pojistovna { get; set; }
        Majitel Majitel { get; set; }

        public Automobil(int id, string vin, string spz, int rokVyroby, Model znacka, Pojistovna pojistovna, Majitel majitel)
        {
            Id = id;
            Vin = vin;
            Spz = spz;
            RokVyroby = rokVyroby;
            Znacka = znacka;
            Pojistovna = pojistovna;
            Majitel = majitel;
        }


    }
}
