using System;

namespace GUI.Objects
{
    public class Pojistovna
    {
        int Id { get; set; }
        public String nazev { get; set; }

        public Pojistovna(int id, string nazev)
        {
            Id = id;
            this.nazev = nazev;
        }

        public Pojistovna(string nazev)
        {
            this.nazev = nazev;
        }

        public override string ToString()
        {
            return nazev;
        }
    }
}
