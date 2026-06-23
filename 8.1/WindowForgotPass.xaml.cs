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
using System.Windows.Shapes;

namespace Практическая_8
{
    /// <summary>
    /// Логика взаимодействия для WindowForgotPass.xaml
    /// </summary>
    public partial class WindowForgotPass : Window
    {
        public WindowForgotPass()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textB1.Visibility = Visibility.Hidden;
            label1.Visibility = Visibility.Hidden;
            btn1.Visibility = Visibility.Hidden;
            label2.Content = "Ваш запрос отправлен голубиной почтой нашему администратору!";
            btn2.Visibility = Visibility.Visible;
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
