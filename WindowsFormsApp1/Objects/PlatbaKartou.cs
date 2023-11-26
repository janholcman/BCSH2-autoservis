using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Objects
{
    internal class PlatbaKartou : Platba
    {
        int Id { get; set; }
        DateTime DatumSplatnosti { get; set; }
        float Cena { get; set; }
        String CisloBanky {  get; set; }

        public PlatbaKartou(int id, DateTime datumSplatnosti, float cena, String cisloBanky) : base(id, datumSplatnosti, cena)
        {
            Id = id;
            DatumSplatnosti = datumSplatnosti;
            Cena = cena;
            CisloBanky = cisloBanky;
        }

        public PlatbaKartou(int id, DateTime datumSplatnosti, float cena) : base(id, datumSplatnosti, cena)
        {
            Id = id;
            DatumSplatnosti = datumSplatnosti;
            Cena = cena;
        }
    }
}
