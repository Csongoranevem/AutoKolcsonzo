using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Jarmu
    {

        public Jarmu(string marka, string tipus, string rendszam, int gyartasiEv, string szin, int motorTeljesitmeny)
        {
            Marka = marka;
            Tipus = tipus;
            Rendszam = rendszam;
            GyartasiEv = gyartasiEv;
            Szin = szin;
            MotorTeljesitmeny = motorTeljesitmeny;
        }

        public string Marka { get; set; }
        public string Tipus { get; set; }
        public string Rendszam { get; set; }
        public int GyartasiEv { get; set; }
        public string Szin { get; set; }
        public int MotorTeljesitmeny { get; set; }

    }
}
