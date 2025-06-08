using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace WpfApp1
{
    public partial class App : Application
    {

        static string dataBaseName = "Betegek.db";
        static string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public static string databasePath = System.IO.Path.Combine(folderPath, dataBaseName);

        public static List<string> Markak { get; } = new List<string>
        {
            "Toyota",
            "Ford",
            "BMW",
            "Mercedes"
        };

        public static ObservableCollection<Auto> Autok { get; } = new ObservableCollection<Auto>
        {
            new Auto { Marka = "Toyota", Tipus = "Corolla", Rendszam = "ABC-123", GyartasiEv = 2020, Szin = "Red", MotorTeljesitmeny = 132 },
            new Auto { Marka = "Ford", Tipus = "Focus", Rendszam = "DEF-456", GyartasiEv = 2019, Szin = "Blue", MotorTeljesitmeny = 120 }
        };
    }

    public class Auto
    {
        public string Marka { get; set; }
        public string Tipus { get; set; }
        public string Rendszam { get; set; }
        public int GyartasiEv { get; set; }
        public string Szin { get; set; }
        public int MotorTeljesitmeny { get; set; }
    }
}
