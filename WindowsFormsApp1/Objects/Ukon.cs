using System;

namespace GUI.Objects
{
    internal class Ukon
    {
        int Id { get; set; }
        String NazevUkonu { get; set; }

        public Ukon(int id, string nazevUkonu)
        {
            Id = id;
            NazevUkonu = nazevUkonu;
        }
    }
}
