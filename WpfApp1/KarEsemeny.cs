using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class KarEsemeny
    {
        public KarEsemeny()
        {
        }

        public KarEsemeny(string teljesNev, string autoTipus, string karTipus, string telefonSzam, string baleset)
        {
            TeljesNev = teljesNev;
            AutoTipus = autoTipus;
            KarTipus = karTipus;
            TelefonSzam = telefonSzam;
            Baleset = baleset;
        }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string TeljesNev { get; set; }

        public string AutoTipus { get; set; }

        public string KarTipus { get; set; }

        public string TelefonSzam { get; set; }

        public string Baleset { get; set; }
    }

}
