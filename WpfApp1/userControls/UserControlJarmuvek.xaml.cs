using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Linq;

namespace WpfApp1.userControls
{
    public partial class UserControlJarmuvek : UserControl
    {
        private ObservableCollection<Auto> filteredAutok = new ObservableCollection<Auto>();

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
            markaComboBox.SelectedItem = null; // Nem lehet kiválasztva a márka, ha gyártási év szerint filterezünk


            filteredAutok.Clear();
            var ev = RendezesComboBox.SelectedItem;
            foreach (var auto in App.Autok.OrderBy(a => a.GyartasiEv).Where(a => a.GyartasiEv == (int)ev))
            {
                filteredAutok.Add(auto);
            }
        }

        private void sorrendComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            filteredAutok.Clear();
            if (sorrendComboBox.SelectedItem == "Növekvő")
            {
                foreach (var auto in App.Autok.OrderBy(a => a.GyartasiEv))
                    filteredAutok.Add(auto);
            }
            else if (sorrendComboBox.SelectedItem == "Csökkenő")
            {
                foreach (var auto in App.Autok.OrderByDescending(a => a.GyartasiEv))
                    filteredAutok.Add(auto);
            }
        }
    }
}
