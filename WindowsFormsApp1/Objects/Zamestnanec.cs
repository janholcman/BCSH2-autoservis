using System;

namespace GUI.Objects
{
    public class Zamestnanec
    {
        public int Id { get; set; }
        public String Jmeno { get; set; }
        public String Prijmeni { set; get; }
        public String RodneCislo { get; set; }
        public DateTime DatumNastupu { get; set; }
        public float HodinovaMzda { get; set; }
        public float Mzda { get; set; }
        public int Pozice { get; set; }
        public String UserName { get; set; }
        public string Password { get; set; }

        public Zamestnanec(int id, string jmeno, string prijmeni, string rodneCislo, DateTime datumNastupu, float hodinovaMzda, float mzda, int pozice, string userName, string password)
        {
            Id = id;
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            RodneCislo = rodneCislo;
            DatumNastupu = datumNastupu;
            HodinovaMzda = hodinovaMzda;
            Mzda = mzda;
            Pozice = pozice;
            UserName = userName;
            Password = password;
        }

        public Zamestnanec(int id, string jmeno, string prijmeni, string rodneCislo, DateTime datumNastupu, float hodinovaMzda, float mzda, int pozice)
        {
            Id = id;
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            RodneCislo = rodneCislo;
            DatumNastupu = datumNastupu;
            HodinovaMzda = hodinovaMzda;
            Mzda = mzda;
            Pozice = pozice;
        }

        public Zamestnanec(string jmeno, string prijmeni)
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
