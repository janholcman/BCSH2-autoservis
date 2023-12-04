using System;

namespace GUI.Objects
{
    internal class Znacka
    {
        int Id { get; set; }
        String nazev { get; set; }

        public Znacka(int id, string nazev)
        {
            Id = id;
            this.nazev = nazev;
        }
    }
}
