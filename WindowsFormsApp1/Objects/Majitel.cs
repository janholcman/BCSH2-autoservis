using System;

namespace GUI.Objects
{
    internal class Majitel
    {
        int Id { get; set; }
        public String Jmeno { get; set; }
        public String Prijmeni { get; set; }
        public DateTime VlastniOd { get; set; }

        public Majitel(int id, string jmeno, string prijmeni, DateTime vlastniOd)
        {
            Id = id;
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            VlastniOd = vlastniOd;
        }

        public Majitel(string jmeno, string prijmeni)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
        }

        public override string ToString()
        {
            return Jmeno + " " + Prijmeni;
        }
    }
}
