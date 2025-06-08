using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace WpfApp1
{
    internal class Berles
    {
        public Berles()
        {
        }

        public Berles(string teljesNev, int ulesekSzama, int idotartam, string telefonSzam)
        {
            TeljesNev = teljesNev;
            UlesekSzama = ulesekSzama;
            Idotartam = idotartam;
            TelefonSzam = telefonSzam;
        }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string TeljesNev { get; set; }

        public int UlesekSzama { get; set; }

        public int Idotartam {  get; set; }

        public string TelefonSzam {  get; set; }
    }
}
