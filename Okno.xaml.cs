using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace tester_wpf
{
    public partial class Okno : Window
    {

        public Okno(string rez)
        {
            InitializeComponent();

            creatorTest.IsEnabled = rez == "1";
        }

        private void exit_2_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }

        private void proiti_test_Click(object sender, RoutedEventArgs e)
        {
            pages.Content = Sd.Deserialize<List<testerMod>>() == null ? new Troll() : new Prohojdenie();
        }

        private void creatorTest_Click(object sender, RoutedEventArgs e)
        {
            pages.Content = new RedactorTest();
        }
    }
}

