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
    /// Логика взаимодействия для Page15.xaml
    /// </summary>
    public partial class Page15 : Page
    {
        public Page15()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double ax = double.Parse(Box11.Text);
            double ay = double.Parse(Box12.Text);
            double bx = double.Parse(Box21.Text);
            double by = double.Parse(Box22.Text);
            double ra, rb;
            ra = Math.Sqrt(ax * ax + ay * ay);
            rb = Math.Sqrt(bx * bx + by * by);
            if (ra > rb)
            {
                MessageBox.Show($"Расстояние до точки A = {ra}\nРасстояние до точки B = {rb}\nТочка A дальше", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (rb > ra)
            {
                MessageBox.Show($"Расстояние до точки A = {ra}\nРасстояние до точки B = {rb}\nТочка B дальше", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show($"Расстояние до точки A = {ra}\nРасстояние до точки B = {rb}\nРасстояние до точек одинаковое", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
