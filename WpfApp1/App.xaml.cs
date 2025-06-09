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
            "Mercedes",
            "Audi",
            "Volkswagen",
            "Honda",
            "Hyundai",
            "Kia",
            "Mazda"
        };

        public static List<int> Evszamok { get; } = new List<int>
        {
            2016, 2017, 2018, 2019, 2020, 2021, 2022, 2023
        };

        public static List<string> Sorrend { get; } = new List<string>
        {
            "Növekvő",
            "Csökkenő"
        };





        public static ObservableCollection<Auto> Autok { get; } = new ObservableCollection<Auto>
        {
            new Auto { Marka = "Toyota", Tipus = "Corolla", Rendszam = "AAA-001", GyartasiEv = 2020, Szin = "Red", MotorTeljesitmeny = 132 },
            new Auto { Marka = "Ford", Tipus = "Focus", Rendszam = "AAA-002", GyartasiEv = 2019, Szin = "Blue", MotorTeljesitmeny = 120 },
            new Auto { Marka = "BMW", Tipus = "320i", Rendszam = "AAA-003", GyartasiEv = 2021, Szin = "Black", MotorTeljesitmeny = 184 },
            new Auto { Marka = "Audi", Tipus = "A4", Rendszam = "AAA-004", GyartasiEv = 2018, Szin = "White", MotorTeljesitmeny = 150 },
            new Auto { Marka = "Honda", Tipus = "Civic", Rendszam = "AAA-005", GyartasiEv = 2022, Szin = "Silver", MotorTeljesitmeny = 158 },
            new Auto { Marka = "Mercedes", Tipus = "C200", Rendszam = "AAA-006", GyartasiEv = 2017, Szin = "Gray", MotorTeljesitmeny = 156 },
            new Auto { Marka = "Volkswagen", Tipus = "Golf", Rendszam = "AAA-007", GyartasiEv = 2020, Szin = "Green", MotorTeljesitmeny = 115 },
            new Auto { Marka = "Hyundai", Tipus = "Elantra", Rendszam = "AAA-008", GyartasiEv = 2021, Szin = "Blue", MotorTeljesitmeny = 147 },
            new Auto { Marka = "Kia", Tipus = "Ceed", Rendszam = "AAA-009", GyartasiEv = 2019, Szin = "Red", MotorTeljesitmeny = 120 },
            new Auto { Marka = "Mazda", Tipus = "3", Rendszam = "AAA-010", GyartasiEv = 2022, Szin = "White", MotorTeljesitmeny = 155 },
            new Auto { Marka = "Toyota", Tipus = "Yaris", Rendszam = "AAA-011", GyartasiEv = 2018, Szin = "Yellow", MotorTeljesitmeny = 106 },
            new Auto { Marka = "Ford", Tipus = "Mondeo", Rendszam = "AAA-012", GyartasiEv = 2017, Szin = "Black", MotorTeljesitmeny = 140 },
            new Auto { Marka = "BMW", Tipus = "X1", Rendszam = "AAA-013", GyartasiEv = 2021, Szin = "Blue", MotorTeljesitmeny = 190 },
            new Auto { Marka = "Audi", Tipus = "Q3", Rendszam = "AAA-014", GyartasiEv = 2022, Szin = "Gray", MotorTeljesitmeny = 170 },
            new Auto { Marka = "Honda", Tipus = "Accord", Rendszam = "AAA-015", GyartasiEv = 2020, Szin = "Silver", MotorTeljesitmeny = 192 },
            new Auto { Marka = "Mercedes", Tipus = "E220", Rendszam = "AAA-016", GyartasiEv = 2016, Szin = "Black", MotorTeljesitmeny = 194 },
            new Auto { Marka = "Volkswagen", Tipus = "Passat", Rendszam = "AAA-017", GyartasiEv = 2020, Szin = "White", MotorTeljesitmeny = 150 },
            new Auto { Marka = "Hyundai", Tipus = "i30", Rendszam = "AAA-018", GyartasiEv = 2019, Szin = "Red", MotorTeljesitmeny = 130 },
            new Auto { Marka = "Kia", Tipus = "Sportage", Rendszam = "AAA-019", GyartasiEv = 2021, Szin = "Blue", MotorTeljesitmeny = 180 },
            new Auto { Marka = "Mazda", Tipus = "CX-5", Rendszam = "AAA-020", GyartasiEv = 2022, Szin = "Green", MotorTeljesitmeny = 187 },
            new Auto { Marka = "Toyota", Tipus = "RAV4", Rendszam = "AAA-021", GyartasiEv = 2020, Szin = "Black", MotorTeljesitmeny = 203 },
            new Auto { Marka = "Ford", Tipus = "Kuga", Rendszam = "AAA-022", GyartasiEv = 2018, Szin = "Gray", MotorTeljesitmeny = 150 },
            new Auto { Marka = "BMW", Tipus = "X3", Rendszam = "AAA-023", GyartasiEv = 2021, Szin = "White", MotorTeljesitmeny = 248 },
            new Auto { Marka = "Audi", Tipus = "Q5", Rendszam = "AAA-024", GyartasiEv = 2019, Szin = "Blue", MotorTeljesitmeny = 261 },
            new Auto { Marka = "Honda", Tipus = "CR-V", Rendszam = "AAA-025", GyartasiEv = 2022, Szin = "Red", MotorTeljesitmeny = 190 },
            new Auto { Marka = "Mercedes", Tipus = "GLC", Rendszam = "AAA-026", GyartasiEv = 2020, Szin = "Silver", MotorTeljesitmeny = 255 },
            new Auto { Marka = "Volkswagen", Tipus = "Tiguan", Rendszam = "AAA-027", GyartasiEv = 2021, Szin = "Black", MotorTeljesitmeny = 184 },
            new Auto { Marka = "Hyundai", Tipus = "Tucson", Rendszam = "AAA-028", GyartasiEv = 2019, Szin = "White", MotorTeljesitmeny = 161 },
            new Auto { Marka = "Kia", Tipus = "Sorento", Rendszam = "AAA-029", GyartasiEv = 2018, Szin = "Gray", MotorTeljesitmeny = 240 },
            new Auto { Marka = "Mazda", Tipus = "6", Rendszam = "AAA-030", GyartasiEv = 2017, Szin = "Blue", MotorTeljesitmeny = 184 },
            new Auto { Marka = "Toyota", Tipus = "Camry", Rendszam = "AAA-031", GyartasiEv = 2021, Szin = "Red", MotorTeljesitmeny = 203 },
            new Auto { Marka = "Ford", Tipus = "Fiesta", Rendszam = "AAA-032", GyartasiEv = 2022, Szin = "Yellow", MotorTeljesitmeny = 100 },
            new Auto { Marka = "BMW", Tipus = "1 Series", Rendszam = "AAA-033", GyartasiEv = 2019, Szin = "Black", MotorTeljesitmeny = 140 },
            new Auto { Marka = "Audi", Tipus = "A3", Rendszam = "AAA-034", GyartasiEv = 2018, Szin = "White", MotorTeljesitmeny = 150 },
            new Auto { Marka = "Honda", Tipus = "Jazz", Rendszam = "AAA-035", GyartasiEv = 2020, Szin = "Blue", MotorTeljesitmeny = 110 },
            new Auto { Marka = "Mercedes", Tipus = "A180", Rendszam = "AAA-036", GyartasiEv = 2022, Szin = "Silver", MotorTeljesitmeny = 136 },
            new Auto { Marka = "Volkswagen", Tipus = "Polo", Rendszam = "AAA-037", GyartasiEv = 2017, Szin = "Red", MotorTeljesitmeny = 95 },
            new Auto { Marka = "Hyundai", Tipus = "i20", Rendszam = "AAA-038", GyartasiEv = 2021, Szin = "Black", MotorTeljesitmeny = 84 },
            new Auto { Marka = "Kia", Tipus = "Rio", Rendszam = "AAA-039", GyartasiEv = 2020, Szin = "Gray", MotorTeljesitmeny = 100 },
            new Auto { Marka = "Mazda", Tipus = "2", Rendszam = "AAA-040", GyartasiEv = 2019, Szin = "Green", MotorTeljesitmeny = 90 },
            new Auto { Marka = "Toyota", Tipus = "Auris", Rendszam = "AAA-041", GyartasiEv = 2018, Szin = "Blue", MotorTeljesitmeny = 132 },
            new Auto { Marka = "Ford", Tipus = "EcoSport", Rendszam = "AAA-042", GyartasiEv = 2017, Szin = "Orange", MotorTeljesitmeny = 125 },
            new Auto { Marka = "BMW", Tipus = "5 Series", Rendszam = "AAA-043", GyartasiEv = 2022, Szin = "White", MotorTeljesitmeny = 252 },
            new Auto { Marka = "Audi", Tipus = "A6", Rendszam = "AAA-044", GyartasiEv = 2020, Szin = "Gray", MotorTeljesitmeny = 245 },
            new Auto { Marka = "Honda", Tipus = "HR-V", Rendszam = "AAA-045", GyartasiEv = 2019, Szin = "Red", MotorTeljesitmeny = 141 },
            new Auto { Marka = "Mercedes", Tipus = "CLA", Rendszam = "AAA-046", GyartasiEv = 2021, Szin = "Blue", MotorTeljesitmeny = 163 },
            new Auto { Marka = "Volkswagen", Tipus = "Arteon", Rendszam = "AAA-047", GyartasiEv = 2022, Szin = "Black", MotorTeljesitmeny = 280 },
            new Auto { Marka = "Hyundai", Tipus = "Kona", Rendszam = "AAA-048", GyartasiEv = 2020, Szin = "Yellow", MotorTeljesitmeny = 175 },
            new Auto { Marka = "Kia", Tipus = "Stonic", Rendszam = "AAA-049", GyartasiEv = 2021, Szin = "Green", MotorTeljesitmeny = 120 },
            new Auto { Marka = "Mazda", Tipus = "MX-5", Rendszam = "AAA-050", GyartasiEv = 2018, Szin = "Red", MotorTeljesitmeny = 181 },
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
