using SQLite;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private void karEsemenyBTN_Click(object sender, RoutedEventArgs e)
        {
            userControlPanel.Children.Clear();
            userControlPanel.Children.Add(new userControls.UserControlKarEsemyenyek());

        }

        private void berlesBTN_Click(object sender, RoutedEventArgs e)
        {
            userControlPanel.Children.Clear();
            userControlPanel.Children.Add(new userControls.UserControlBerles());

        }

        private void jarmuveinkBTN_Click(object sender, RoutedEventArgs e)
        {
            userControlPanel.Children.Clear();
            userControlPanel.Children.Add(new userControls.UserControlJarmuvek());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown(); // Alkalmazás bezárása
        }
    }

}