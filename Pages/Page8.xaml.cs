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
    /// Логика взаимодействия для Page8.xaml
    /// </summary>
    public partial class Page8 : Page
    {
        public Page8()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(Box1.Text);
            double b = double.Parse(Box2.Text);
            double c = double.Parse(Box3.Text);
            double p = (a+b+c)/2;
            double S = (p*(p-a)*(p-b)*(p-c));
            if (S <= 0)
                MessageBox.Show("Такого треугольника не существует", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            else
                MessageBox.Show($"Площадь треугольника = {S}", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
