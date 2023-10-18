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
    /// Логика взаимодействия для Page7.xaml
    /// </summary>
    public partial class Page7 : Page
    {
        public Page7()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (PIC(double.Parse(Box11.Text), double.Parse(Box12.Text), double.Parse(Box2.Text)))
                MessageBox.Show("Точка лежит внутри окружности", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
            else
                MessageBox.Show("Точка не лежит внутри окружности", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        static bool PIC (double x, double y, double r)
        {
            return (x*x+y*y) <= (r*r);
        }
    }
}
