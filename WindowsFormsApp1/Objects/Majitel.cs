using System;

namespace GUI.Objects
{
    internal class Majitel
    {
        int Id { get; set; }
        String Jmeno { get; set; }
        String Prijmeni { get; set; }
        DateTime VlastniOd { get; set; }

        public Majitel(int id, string jmeno, string prijmeni, DateTime vlastniOd)
        {
            Id = id;
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            VlastniOd = vlastniOd;
        }
    }
}
