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
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double qs = Math.Pow(Double.Parse(Box1.Text) + Double.Parse(Box2.Text), 2);
                double sq = Math.Pow(Double.Parse(Box1.Text), 2) + Math.Pow(Double.Parse(Box2.Text), 2);
                if (qs > sq)
                {
                    MessageBox.Show($"Квадрат суммы = {qs}\n Сумма квадратов = {sq}\n Квадрат суммы больше", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else if (qs == sq)
                {
                    MessageBox.Show($"Квадрат суммы = {qs}\n Сумма квадратов = {sq}\n Квадрат суммы равен сумме квадратов", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show($"Квадрат суммы = {qs}\n Сумма квадратов = {sq}\n Сумма квадратов больше", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch
            {
                double qs = Math.Pow(Double.Parse(Box1.Text) + Double.Parse(Box2.Text), 2);
                double sq = Math.Pow(Double.Parse(Box1.Text), 2) + Math.Pow(Double.Parse(Box2.Text), 2);
                if (qs > sq)
                {
                    MessageBox.Show($"Квадрат суммы = {qs}\n Сумма квадратов = {sq}\n Квадрат суммы больше", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else if (qs == sq)
                {
                    MessageBox.Show($"Квадрат суммы = {qs}\n Сумма квадратов = {sq}\n Квадрат суммы равен сумме квадратов", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Введено неверное значение", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
