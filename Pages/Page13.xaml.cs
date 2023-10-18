using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace WpfApp2.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page13.xaml
    /// </summary>
    public partial class Page13 : Page
    {
        public Page13()
        {
            InitializeComponent();
        }

        static double Vklad = 0;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(Box1.Text);
            if (Vklad == 1)
            {
                a = a * 1.06;
                MessageBox.Show($"Сумма выплаты = {a}", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
                a = 0;
            }
            else if (Vklad == 2)
            {
                a = a * 1.08;
                MessageBox.Show($"Сумма выплаты = {a}", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
                a = 0;
            }
            

        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            Vklad = 1;
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            Vklad = 2;
        }

    }
}
