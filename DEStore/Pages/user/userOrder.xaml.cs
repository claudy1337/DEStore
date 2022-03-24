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

namespace DEStore.Pages.user
{
    /// <summary>
    /// Логика взаимодействия для userOrder.xaml
    /// </summary>
    public partial class userOrder : Page
    {
        public static Model.destoreEntities2 db = new Model.destoreEntities2();

        public userOrder()
        {
            InitializeComponent();
            
            myDataGrids.ItemsSource = db.order.Where(c=>c.idUser == MainWindow.LoggedUser.idUser).ToList();
        }

        private void myDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
        }

        private void DGEmployee_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
