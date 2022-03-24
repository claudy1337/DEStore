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
    /// Логика взаимодействия для DeleteProducts.xaml
    /// </summary>
    public partial class DeleteProducts : Page
    {
        public static Model.destoreEntities2 db = new Model.destoreEntities2();

        public DeleteProducts()
        {
            InitializeComponent();
            Refresh();
        }

        
        private void Refresh()
        {
            DGProducts.ItemsSource = null;
            DGProducts.ItemsSource = db.product.ToList();
        }

        private void DGEmployee_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void BRemove_Click_1(object sender, RoutedEventArgs e)
        {
            if (DGProducts.SelectedItem == null)
            {
                MessageBox.Show("select item");
                return;
            }
            db.product.Remove((Model.product)DGProducts.SelectedItem);
            db.SaveChanges();
            Refresh();
        }
    }
}
