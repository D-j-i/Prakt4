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
    /// Логика взаимодействия для Page12.xaml
    /// </summary>
    public partial class Page12 : Page
    {
        public Page12()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double x = double.Parse(Box11.Text);
            double y = double.Parse(Box12.Text);
            if (x < 0 && y > 0) 
            {
                MessageBox.Show($"Координата ({x},{y}) лежит в первом квадрате", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show($"Координата ({x},{y}) НЕ лежит в первом квадрате", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
