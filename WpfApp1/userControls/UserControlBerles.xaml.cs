using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1.userControls
{
    /// <summary>
    /// Interaction logic for UserControlBerles.xaml
    /// </summary>
    public partial class UserControlBerles : UserControl
    {
        List<Berles> berlesek;
        Berles kivalasztottBerles;
        public UserControlBerles()
        {
            InitializeComponent();
            berlesek = new List<Berles>();
            ReadDatabase();
            rogzitBTN.Visibility = Visibility.Visible;
            modositBTN.Visibility = Visibility.Hidden;
            torlesBTN.Visibility = Visibility.Hidden;
        }

        private void ReadDatabase()
        {
            teljesNev.Text = "";
            szemelySzam.Text = "";
            idoTartam.Text = "";
            telefonSzam.Text = "";

            using (SQLite.SQLiteConnection sQLiteConnection = new SQLite.SQLiteConnection(App.databasePath))
            {
                sQLiteConnection.CreateTable<Berles>();
                berlesek = sQLiteConnection.Table<Berles>().ToList();

                if (berlesek != null)
                {
                    berlesDataGrid.ItemsSource = berlesek;
                }

            }

            rogzitBTN.Visibility = Visibility.Visible;
            modositBTN.Visibility = Visibility.Hidden;
            torlesBTN.Visibility = Visibility.Hidden;

        }

        private void torlesBTN_Click(object sender, RoutedEventArgs e)
        {
            using (SQLite.SQLiteConnection sQLiteConnection = new SQLite.SQLiteConnection(App.databasePath))
            {
                sQLiteConnection.CreateTable<Berles>();
                sQLiteConnection.Delete(kivalasztottBerles);
            }
            ReadDatabase();
        }

        private void modositBTN_Click(object sender, RoutedEventArgs e)
        {
            kivalasztottBerles.TeljesNev = teljesNev.Text;
            kivalasztottBerles.UlesekSzama = Convert.ToInt32(szemelySzam.Text);
            kivalasztottBerles.Idotartam = Convert.ToInt32(idoTartam.Text);
            kivalasztottBerles.TelefonSzam = telefonSzam.Text;

            using (SQLite.SQLiteConnection sQLiteConnection = new SQLite.SQLiteConnection(App.databasePath))
            {
                sQLiteConnection.CreateTable<Berles>();
                sQLiteConnection.Update(kivalasztottBerles);
            }

            ReadDatabase();
        }

        private void rogzitBTN_Click(object sender, RoutedEventArgs e)
        {
            if (elfogadta.IsChecked == false)
            {
                MessageBox.Show("Fogadd el a feltételeket!");
                return;
            }


            try
            {
                Berles berles = new Berles()
                {
                    TeljesNev = teljesNev.Text,
                    UlesekSzama = Convert.ToInt32(szemelySzam.Text),
                    Idotartam = Convert.ToInt32(idoTartam.Text),
                    TelefonSzam = telefonSzam.Text

                };
                using (SQLite.SQLiteConnection sQLiteConnection = new SQLite.SQLiteConnection(App.databasePath))
                {
                    sQLiteConnection.CreateTable<Berles>();
                    sQLiteConnection.Insert(berles);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Figyelj arra, hogy minden mezőbe írj, és az ülések, illetve a napok számához számot adj meg!"/* + $"\n\n{ex.ToString()}"*/);
            }
            ReadDatabase();
        }

        private void berlesDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            rogzitBTN.Visibility = Visibility.Visible;
            modositBTN.Visibility = Visibility.Visible;
            torlesBTN.Visibility = Visibility.Visible;


            if (berlesDataGrid.SelectedItem != null)
            {
                kivalasztottBerles = (Berles)berlesDataGrid.SelectedItem;
                teljesNev.Text = kivalasztottBerles.TeljesNev;
                szemelySzam.Text = Convert.ToString(kivalasztottBerles.UlesekSzama);
                idoTartam.Text = Convert.ToString(kivalasztottBerles.Idotartam);
                telefonSzam.Text = kivalasztottBerles.TelefonSzam;

            }
        }
    }

}
