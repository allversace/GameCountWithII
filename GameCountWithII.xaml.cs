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

namespace WpfApp11
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WriteChislo.MaxLength = 2;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void WriteChislo_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Space)
                e.Handled = true;
        }

        private void WriteChislo_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if(!Char.IsDigit(e.Text, 0))
                e.Handled = true;
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            string randomNumber = random.Next(1, 101).ToString();
            string chislo = WriteChislo.Text;
            if(chislo != "")
            {
                if (chislo == randomNumber)
                {
                    WriteChisloII.Text = randomNumber;
                    MessageBox.Show("Вы угадали");
                    WriteChislo.Clear();
                    WriteChisloII.Clear();
                }
                else
                {
                    WriteChisloII.Text = randomNumber;
                    MessageBox.Show("Попробуйте в следующй раз");
                    WriteChislo.Clear();
                    WriteChisloII.Clear();
                }
            }
            else
            {
                MessageBox.Show("Введите чсло");
            }
        }
    }
}
