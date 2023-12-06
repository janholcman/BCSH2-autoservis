using System;

namespace GUI.Objects
{
    internal class Model
    {
        int Id { get; set; }
        public String Nazev { get; set; }
        public String Typ { get; set; }
        public String Vyrobce { get; set; }

        public Model(string nazev, string typ, string vyrobce)
        {
            this.Nazev = nazev;
            this.Typ = typ;
            this.Vyrobce = vyrobce;
        }

        public override string ToString()
        {
            return Nazev + " " + Typ + " " + Vyrobce;
        }
    }
}
