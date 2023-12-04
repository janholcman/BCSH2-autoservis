using System;

namespace GUI.Objects
{
    internal class Pozice
    {
        int Id { get; set; }
        String nazev { get; set; }

        public Pozice(int id, string nazev)
        {
            Id = id;
            this.nazev = nazev;
        }
    }
}
