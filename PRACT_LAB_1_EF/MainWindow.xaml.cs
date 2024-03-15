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

namespace PRACT_LAB_1_EF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            table_frame.Content = new Posts_page();
            first_table.IsEnabled = false;
            second_table.IsEnabled = true;
        }

        private void second_table_Click(object sender, RoutedEventArgs e)
        {
            table_frame.Content = new Employeers_page();
            first_table.IsEnabled = true;
            second_table.IsEnabled = false;
        }
    }
}
