using System;

namespace GUI.Objects
{
    internal class Platba
    {
        int Id { get; set; }
        DateTime DatumSplatnosti { get; set; }
        float Cena { get; set; }

        public Platba(int id, DateTime datumSplatnosti, float cena)
        {
            Id = id;
            DatumSplatnosti = datumSplatnosti;
            Cena = cena;
        }
    }
}
