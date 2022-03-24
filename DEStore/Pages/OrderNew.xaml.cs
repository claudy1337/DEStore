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

namespace DEStore.Pages
{
    /// <summary>
    /// Логика взаимодействия для OrderNew.xaml
    /// </summary>
    public partial class OrderNew : Page
    {
        public static Model.destoreEntities2 db = new Model.destoreEntities2();

        public OrderNew()
        {
            InitializeComponent();
           
        }

        private void addProducts1_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
