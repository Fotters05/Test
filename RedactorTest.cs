using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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
using tester_wpf;
using static System.Net.Mime.MediaTypeNames;

namespace tester_wpf
{
    public partial class RedactorTest : Page
    {
        public List<testerMod> tests = Sd.Deserialize<List<testerMod>>() ?? new List<testerMod>();

        public RedactorTest()
        {
            InitializeComponent();
            tablichka.ItemsSource = tests;
        }

        private void tablichka_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Sd.Serialize(tests);
        }

        private void add_que_Click(object sender, RoutedEventArgs e)
        {
            tests.Add(new testerMod("Тест", "бомбовый", "ответ1", "ответ2", "ответ3", Enumm.vop1));
            Sd.Serialize(tests.Count + 1);
            tablichka.ItemsSource = null;
            tablichka.ItemsSource = tests;
        }
    }
}