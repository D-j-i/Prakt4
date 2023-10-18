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
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double d1 = Math.Sqrt(Math.Pow(double.Parse(Box11.Text), 2) + Math.Pow(double.Parse(Box12.Text), 2));
                double d2 = Math.Sqrt(Math.Pow(double.Parse(Box21.Text), 2) + Math.Pow(double.Parse(Box22.Text), 2));
                if (d1 > d2)
                {
                    MessageBox.Show($"A = {d1} \nB = {d2}\nТочка A дальше", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else if (d1 == d2)
                {
                    MessageBox.Show($"A = {d1} \nB = {d2}\nТочки равноудалены", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information); ;
                }
                else
                {
                    MessageBox.Show($"A = {d1} \nB = {d2}\nТочка B дальше", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                
            }
            catch 
            {
                
                
                    MessageBox.Show("Неверное значение", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                
            }
        }
    }
}
