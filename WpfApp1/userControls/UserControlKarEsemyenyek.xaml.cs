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
    /// Interaction logic for UserControlKarEsemyenyek.xaml
    /// </summary>
    public partial class UserControlKarEsemyenyek : UserControl
    {
        List<KarEsemeny> karEsemenyek;
        KarEsemeny kivalasztottKarEsemeny;

        public UserControlKarEsemyenyek()
        {

            InitializeComponent();
            karEsemenyek = new List<KarEsemeny>();
            ReadDatabase();
            rogzitBTN.Visibility = Visibility.Visible;
            modositBTN.Visibility = Visibility.Hidden;
            torlesBTN.Visibility = Visibility.Hidden;

        }

        private void ReadDatabase()
        {
            teljesNev.Text = "";
            autoTipus.Text = "";
            karTipus.Text = "";
            telefonSzam.Text = "";
            balesetVolt.IsChecked = false;

            using (SQLite.SQLiteConnection sQLiteConnection = new SQLite.SQLiteConnection(App.databasePath))
            {
                sQLiteConnection.CreateTable<KarEsemeny>();
                karEsemenyek = sQLiteConnection.Table<KarEsemeny>().ToList();

                if (karEsemenyek != null)
                {
                    karEsemenyDataGrid.ItemsSource = karEsemenyek;
                }

            }

            rogzitBTN.Visibility = Visibility.Visible;
            modositBTN.Visibility = Visibility.Hidden;
            torlesBTN.Visibility = Visibility.Hidden;

        }


        private void karEsemenyDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            rogzitBTN.Visibility = Visibility.Visible;
            modositBTN.Visibility = Visibility.Visible;
            torlesBTN.Visibility = Visibility.Visible;


            if (karEsemenyDataGrid.SelectedItem != null)
            {
                kivalasztottKarEsemeny = (KarEsemeny)karEsemenyDataGrid.SelectedItem;
                teljesNev.Text = kivalasztottKarEsemeny.TeljesNev;
                autoTipus.Text = kivalasztottKarEsemeny.AutoTipus;
                karTipus.Text = kivalasztottKarEsemeny.KarTipus;
                telefonSzam.Text = kivalasztottKarEsemeny.TelefonSzam;

            }

        }
        private void rogzitBTN_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                KarEsemeny berles = new KarEsemeny()
                {
                    TeljesNev = teljesNev.Text,
                    AutoTipus = autoTipus.Text,
                    KarTipus = karTipus.Text,
                    TelefonSzam = telefonSzam.Text,
                    Baleset = balesetVolt.IsChecked == true ? "igen": "nem"
                };
                using (SQLite.SQLiteConnection sQLiteConnection = new SQLite.SQLiteConnection(App.databasePath))
                {
                    sQLiteConnection.CreateTable<KarEsemeny>();
                    sQLiteConnection.Insert(berles);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Figyelj arra, hogy minden mezőbe írj és megfelelő adatokat adjál meg!"/* + $"\n\n{ex.ToString()}"*/);
            }
            ReadDatabase();

        }

        private void modositBTN_Click_1(object sender, RoutedEventArgs e)
        {
            kivalasztottKarEsemeny.TeljesNev = teljesNev.Text;
            kivalasztottKarEsemeny.AutoTipus = autoTipus.Text;
            kivalasztottKarEsemeny.KarTipus = karTipus.Text;
            kivalasztottKarEsemeny.TelefonSzam = telefonSzam.Text;
            kivalasztottKarEsemeny.Baleset = balesetVolt.IsChecked == true ? "igen" : "nem";


            using (SQLite.SQLiteConnection sQLiteConnection = new SQLite.SQLiteConnection(App.databasePath))
            {
                sQLiteConnection.CreateTable<KarEsemeny>();
                sQLiteConnection.Update(kivalasztottKarEsemeny);
            }

            ReadDatabase();

        }

        private void torlesBTN_Click_1(object sender, RoutedEventArgs e)
        {
            using (SQLite.SQLiteConnection sQLiteConnection = new SQLite.SQLiteConnection(App.databasePath))
            {
                sQLiteConnection.CreateTable<KarEsemeny>();
                sQLiteConnection.Delete(kivalasztottKarEsemeny);
            }
            ReadDatabase();

        }
    }
}
