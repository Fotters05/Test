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

namespace tester_wpf
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Title = "TEST";
            code_word.Visibility = Visibility.Collapsed;
        }

        private void exit_1_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void code_word_TextChanged(object sender, TextChangedEventArgs e)
        {
            string rez = code_word.Text;

            if (code_word.Text == "1")
            {
                Okno test = new(rez);
                test.ShowDialog();
            }
        }

        private void go_test_Click(object sender, RoutedEventArgs e)
        {
            string rez = code_word.Text = "";
            Okno tester = new(rez);
            tester.ShowDialog();
        }

        private void create_test_Click(object sender, RoutedEventArgs e)
        {
            code_word.Visibility = Visibility.Visible;
        }
    }
}
