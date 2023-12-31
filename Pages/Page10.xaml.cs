﻿using System;
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
    /// Логика взаимодействия для Page10.xaml
    /// </summary>
    public partial class Page10 : Page
    {
        public Page10()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            double[] sp = { double.Parse(Box1.Text), double.Parse(Box2.Text), double.Parse(Box3.Text) };

            for (int i = 0; i < sp.Length; i++)
            {
                if (sp[i] > 0)
                {
                    sp[i] = Math.Pow(sp[i], 3);
                }
                else 
                    {
                        sp[i] = 0;
                    }
                
            }
            MessageBox.Show($"Число 1 = {sp[0]}\nЧисло 2 = {sp[1]}\nЧисло 3 = {sp[2]}", "Ответ", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
