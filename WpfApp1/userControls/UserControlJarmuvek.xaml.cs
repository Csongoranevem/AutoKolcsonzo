using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Linq;

namespace WpfApp1.userControls
{
    public partial class UserControlJarmuvek : UserControl
    {
        private ObservableCollection<Jarmu> filteredAutok = new ObservableCollection<Jarmu>();

        public UserControlJarmuvek()
        {
            InitializeComponent();
            // Alapértelmezett betöltés – minden autó
            foreach (var auto in App.Autok)
                filteredAutok.Add(auto);

            // Állítsuk be a szűrt listát a DataGridhez
            JarmuDataGrid.ItemsSource = filteredAutok;
        }

        private void markaComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedMarka = markaComboBox.SelectedItem as string;

            if (string.IsNullOrEmpty(selectedMarka))
            {
                return;
            }

            // Szűrés
            filteredAutok.Clear();
            foreach (var auto in App.Autok.Where(a => a.Marka == selectedMarka))
                filteredAutok.Add(auto);
        }

        private void RendezesComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            filteredAutok.Clear();
            // Szűrés a gyártási év szerint
            if (markaComboBox.SelectedItem != null)
            {
                var ev =Convert.ToInt32(RendezesComboBox.SelectedItem);
                var mark = markaComboBox.SelectedItem as string;
                foreach (var auto in App.Autok.Where(a => a.GyartasiEv == ev && a.Marka == mark))
                {
                    filteredAutok.Add(auto);
                }

            }

            else
            {
                var ev = Convert.ToInt32(RendezesComboBox.SelectedItem);
                foreach (var auto in App.Autok.Where(a => a.GyartasiEv == ev))
                {
                    filteredAutok.Add(auto);
                }

            }
        }

        private void sorrendComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<Jarmu> filterBackup = filteredAutok.ToList();

            if (sorrendComboBox.SelectedItem == "Növekvő")
            {
                filterBackup = filterBackup.OrderBy(a => a.GyartasiEv).ToList();
                filteredAutok.Clear();
                foreach (var auto in filterBackup)
                {
                    filteredAutok.Add(auto);


                }
            }
            else if (sorrendComboBox.SelectedItem == "Csökkenő")
            {
                filterBackup = filterBackup.OrderByDescending(a => a.GyartasiEv).ToList();
                filteredAutok.Clear();
                foreach (var auto in filterBackup)
                {
                    filteredAutok.Add(auto);
                }
            }
        }

        private void markaTorlesBTN_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            markaComboBox.SelectedItem = null;
            RendezesComboBox.SelectedItem = null;


            filteredAutok.Clear();
            // Visszaállítjuk az összes autót, ha a márka törlés gombot nyomják
            foreach (var auto in App.Autok)
            {
                filteredAutok.Add(auto);
            }
        }
    }
}
