using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Objects
{
    internal class Ukon
    {
        int Id {  get; set; }
        String NazevUkonu {  get; set; }

        public Ukon(int id, string nazevUkonu)
        {
            Id = id;
            NazevUkonu = nazevUkonu;
        }
    }
}
