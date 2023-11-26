using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Objects
{
    internal class Pojistovna
    {
        int Id { get; set; }
        String nazev {  get; set; }

        public Pojistovna(int id, string nazev)
        {
            Id = id;
            this.nazev = nazev;
        }
    }
}
