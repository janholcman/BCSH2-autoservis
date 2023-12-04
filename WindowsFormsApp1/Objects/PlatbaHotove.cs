using System;

namespace GUI.Objects
{
    internal class PlatbaHotove : Platba
    {
        int Id { get; set; }
        DateTime DatumSplatnosti { get; set; }
        float Cena { get; set; }
        float KVraceni { get; set; }

        public PlatbaHotove(int id, DateTime datumSplatnosti, float cena, float kVraceni) : base(id, datumSplatnosti, cena)
        {
            Id = id;
            DatumSplatnosti = datumSplatnosti;
            Cena = cena;
            KVraceni = kVraceni;
        }

        public PlatbaHotove(int id, DateTime datumSplatnosti, float cena) : base(id, datumSplatnosti, cena)
        {
            Id = id;
            DatumSplatnosti = datumSplatnosti;
            Cena = cena;
        }
    }
}
