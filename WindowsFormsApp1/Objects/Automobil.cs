using System;

namespace GUI.Objects
{
    public  class Automobil
    {

        public int Id { get; set; }
        public String Vin { get; set; }
        public String Spz { get; set; }
        public int RokVyroby { get; set; }
        public int Znacka { get; set; }
        public int Pojistovna { get; set; }
        public int Majitel { get; set; }

        public Automobil(int id, string vin, string spz, int rokVyroby, int znacka, int pojistovna, int majitel)
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
