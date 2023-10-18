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
    /// Логика взаимодействия для Page11.xaml
    /// </summary>
    public partial class Page11 : Page
    {
        public Page11()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double a = double.Parse(Box1.Text);
            if (a%2 == 0)
            {
                MessageBox.Show($"Число {a} является чётным", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if ((a + 7) % 10 == 0)
            {
                MessageBox.Show($"Число {a} оканчивается на 3", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show($"Число {a} не является чётным и не оканчивается на 3", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
