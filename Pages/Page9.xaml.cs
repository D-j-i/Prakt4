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
    /// Логика взаимодействия для Page9.xaml
    /// </summary>
    public partial class Page9 : Page
    {
        public Page9()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double P1 = Math.Pow(double.Parse(Box1.Text), 2);
            double P2 = Math.Pow(double.Parse(Box2.Text), 2) * Math.PI;
            if (P1 > P2)
            {
                MessageBox.Show($"Площадь квадрата = {P1}\nПлощадь круга = {P2}\n{P1} > {P2}", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (P1 < P2)
            {
                MessageBox.Show($"Площадь квадрата = {P1}\nПлощадь круга = {P2}\n{P1} < {P2}", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show($"Площадь квадрата = {P1}\nПлощадь круга = {P2}\n{P1} = {P2}", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
