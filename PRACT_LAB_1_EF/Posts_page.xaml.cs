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
    /// Логика взаимодействия для Posts_page.xaml
    /// </summary>
    public partial class Posts_page : Page
    {
        private VodocanalEntities VOD = new VodocanalEntities();
        public Posts_page()
        {
            InitializeComponent();
            Table.ItemsSource = VOD.Posts.ToList();
        }
    }
}
