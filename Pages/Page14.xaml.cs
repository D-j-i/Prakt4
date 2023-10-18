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

namespace WpfApp2.Pages
{
    /// <summary>
    /// Логика взаимодействия для Page14.xaml
    /// </summary>
    public partial class Page14 : Page
    {
        public Page14()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(Box1.Text);
            double b = double.Parse(Box2.Text);
            double S, S1, S2;
            S1 = a * a - b * b;
            S2 = Math.Pow(a - b, 2);
            if (S1 > S2) 
            {
                MessageBox.Show($"Разность квадратов = {S1}\nМодуаль квадрата разности = {S2}\nРазность квадратов больше", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (S1 < S2)
            {
                MessageBox.Show($"Разность квадратов = {S1}\nМодуаль квадрата разности = {S2}\nМодуль квадрата разности больше", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show($"Разность квадратов = {S1}\nМодуаль квадрата разности = {S2}\nЧисла равны", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
