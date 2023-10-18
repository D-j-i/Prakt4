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
    /// Логика взаимодействия для Page5.xaml
    /// </summary>
    public partial class Page5 : Page
    {
        public Page5()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a, b, c;
            a = double.Parse(Box1.Text);

            b = double.Parse(Box2.Text);
            c = double.Parse(Box3.Text);
            if (a > 0) 
            {
                a = Math.Pow(a, 2);
            }
            if (b > 0) 
            {
                b = Math.Pow(b, 2);
            }
            if (c > 0) 
            {
                c = Math.Pow(c, 2);
            }
            MessageBox.Show($"a - {a}\nb - {b}\nc - {c}", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
