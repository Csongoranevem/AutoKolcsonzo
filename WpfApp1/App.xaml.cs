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





        public static ObservableCollection<Jarmu> Autok { get; } = new ObservableCollection<Jarmu>
        {
            new Jarmu ("Toyota", "Corolla", "AAA-001", 2020, "Red", 132 ),
            new Jarmu ("Ford", "Focus", "AAA-002", 2019, "Blue", 120),
            new Jarmu ("BMW", "320i", "AAA-003", 2021, "Black", 184),
            new Jarmu ("Audi", "A4", "AAA-004", 2018, "White", 150),
            new Jarmu ("Honda", "Civic", "AAA-005", 2022, "Silver", 158),
            new Jarmu ("Mercedes", "C200", "AAA-006", 2017, "Gray", 156),
            new Jarmu ("Volkswagen", "Golf", "AAA-007", 2020, "Green", 115),
            new Jarmu ("Hyundai", "Elantra", "AAA-008", 2021, "Blue", 147),
            new Jarmu ("Kia", "Ceed", "AAA-009", 2019, "Red", 120),
            new Jarmu ("Mazda", "3", "AAA-010", 2022, "White", 155),
            new Jarmu ("Toyota", "Yaris", "AAA-011", 2018, "Yellow", 106),
            new Jarmu ("Ford", "Mondeo", "AAA-012", 2017, "Black", 140),
            new Jarmu ("BMW", "X1", "AAA-013", 2021, "Blue", 190),
            new Jarmu ("Audi", "Q3", "AAA-014", 2022, "Gray", 170),
            new Jarmu ("Honda", "Accord", "AAA-015", 2020, "Silver", 192),
            new Jarmu ("Mercedes", "E220", "AAA-016", 2016, "Black", 194),
            new Jarmu ("Volkswagen", "Passat", "AAA-017", 2020, "White", 150),
            new Jarmu ("Hyundai", "i30", "AAA-018", 2019, "Red", 130),
            new Jarmu ("Kia", "Sportage", "AAA-019", 2021, "Blue", 180),
            new Jarmu ("Mazda", "CX-5", "AAA-020", 2022, "Green", 187),
            new Jarmu ("Toyota", "RAV4", "AAA-021", 2020, "Black", 203),
            new Jarmu ("Ford", "Kuga", "AAA-022", 2018, "Gray", 150),
            new Jarmu ("BMW", "X3", "AAA-023", 2021, "White", 248),
            new Jarmu ("Audi", "Q5", "AAA-024", 2019, "Blue", 261),
            new Jarmu ("Honda", "CR-V", "AAA-025", 2022, "Red", 190),
            new Jarmu ("Mercedes", "GLC", "AAA-026", 2020, "Silver", 255),
            new Jarmu ("Volkswagen", "Tiguan", "AAA-027", 2021, "Black", 184),
            new Jarmu ("Hyundai", "Tucson", "AAA-028", 2019, "White", 161),
            new Jarmu ("Kia", "Sorento", "AAA-029", 2018, "Gray", 240),
            new Jarmu ("Mazda", "6", "AAA-030", 2017, "Blue", 184),
            new Jarmu ("Toyota", "Camry", "AAA-031", 2021, "Red", 203),
            new Jarmu ("Ford", "Fiesta", "AAA-032", 2022, "Yellow", 100),
            new Jarmu ("BMW", "1 Series", "AAA-033", 2019, "Black", 140),
            new Jarmu ("Audi", "A3", "AAA-034", 2018, "White", 150),
            new Jarmu ("Honda", "Jazz", "AAA-035", 2020, "Blue", 110),
            new Jarmu ("Mercedes", "A180", "AAA-036", 2022, "Silver", 136),
            new Jarmu ("Volkswagen", "Polo", "AAA-037", 2017, "Red", 95),
            new Jarmu ("Hyundai", "i20", "AAA-038", 2021, "Black", 84),
            new Jarmu ("Kia", "Rio", "AAA-039", 2020, "Gray", 100),
            new Jarmu ("Mazda", "2", "AAA-040", 2019, "Green", 90),
            new Jarmu ("Toyota", "Auris", "AAA-041", 2018, "Blue", 132),
            new Jarmu ("Ford", "EcoSport", "AAA-042", 2017, "Orange", 125),
            new Jarmu ("BMW", "5 Series", "AAA-043", 2022, "White", 252),
            new Jarmu ("Audi", "A6", "AAA-044", 2020, "Gray", 245),
            new Jarmu ("Honda", "HR-V", "AAA-045", 2019, "Red", 141),
            new Jarmu ("Mercedes", "CLA", "AAA-046", 2021, "Blue", 163),
            new Jarmu ("Volkswagen", "Arteon", "AAA-047", 2022, "Black", 280),
            new Jarmu ("Hyundai", "Kona", "AAA-048", 2020, "Yellow", 175),
            new Jarmu ("Kia", "Stonic", "AAA-049", 2021, "Green", 120),
            new Jarmu ("Mazda", "MX-5", "AAA-050", 2018, "Red", 181),
        };
    }

}
