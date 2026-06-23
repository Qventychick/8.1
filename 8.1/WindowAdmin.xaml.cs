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
    /// Логика взаимодействия для WindowAdmin.xaml
    /// </summary>
    public partial class WindowAdmin : Window
    {
        public WindowAdmin()
        {
            InitializeComponent();
        }

        private void DataGrid_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            comboB1.Visibility = Visibility.Hidden;
            comboB2.Visibility = Visibility.Hidden;
            comboB3.Visibility = Visibility.Hidden;
            label9.Visibility = Visibility.Hidden;
            label10.Visibility = Visibility.Hidden;
            label8.Content = "Таблица для налоговой";
            dataGrid.Visibility = Visibility.Visible;
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
