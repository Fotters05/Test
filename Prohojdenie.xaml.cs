using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using tester_wpf;

namespace tester_wpf
{
    public partial class Prohojdenie : Page
    {
        private int num_of_que = 0;
        private int right_answers = 0;

        private List<testerMod> tests = new List<testerMod>();
        private List<string> variable_positive = new List<string> { "Трушно"};
        private List<string> variable_not = new List<string> { "Кринж"};

        public Prohojdenie()
        {
            InitializeComponent();

            _1answ.IsEnabled = true;
            _2answ.IsEnabled = true;
            _3answ.IsEnabled = true;
            DisplayQuestion();
        }

        private void _1answ_Click(object sender, RoutedEventArgs e) => CheckAnswer(Enumm.vop1);
        private void _2answ_Click(object sender, RoutedEventArgs e) => CheckAnswer(Enumm.vop2);
        private void _3answ_Click(object sender, RoutedEventArgs e) => CheckAnswer(Enumm.vop3);

        private void DisplayQuestion()
        {
            tests = Sd.Deserialize<List<testerMod>>();

            if (tests != null && tests.Count > num_of_que)
            {
                var currentQuestion = tests[num_of_que];
                _title.Text = currentQuestion.title;
                _desc.Text = currentQuestion.desc;
                _1answ.Content = currentQuestion.answ1;
                _2answ.Content = currentQuestion.answ2;
                _3answ.Content = currentQuestion.answ3;
            }
            else
            {
                MessageBox.Show("Список тестов пуст или не удалось загрузить тесты.");
            }
        }

        private void CheckAnswer(Enumm selectedAnswer)
        {
            if (tests[num_of_que].correct_answ == selectedAnswer)
            {
                var rand = new Random();
                var msg = variable_positive[rand.Next(0, variable_positive.Count)];
                _message.Text = msg;
                right_answers++;
            }
            else
            {
                var rand = new Random();
                var msg = variable_not[rand.Next(0, variable_not.Count)];
                _message.Text = msg;
            }

            num_of_que++;

            if (num_of_que < tests.Count)
            {
                DisplayQuestion();
            }
            else
            {
                _message.Text = "";
                Thread.Sleep(100);
                _1answ.IsEnabled = false;
                _2answ.IsEnabled = false;
                _3answ.IsEnabled = false;
                _message.Text = $"{right_answers} из {tests.Count}";
            }
        }
    }
}
