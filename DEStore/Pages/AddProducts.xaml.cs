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
    /// Логика взаимодействия для AddProducts.xaml
    /// </summary>
    public partial class AddProducts : Page
    {
        public static Model.destoreEntities2 db = new Model.destoreEntities2();

        public AddProducts()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TBName.Text) || string.IsNullOrWhiteSpace(TBPrice.Text) || string.IsNullOrWhiteSpace(TBAmount.Text))
            {
                MessageBox.Show("incorrect");
                return;
            }
            Model.product produts = new Model.product() { nameProduct = TBName.Text, priceProduct = Convert.ToInt32(TBPrice.Text), amount = Convert.ToInt32(TBAmount.Text) };
            db.product.Add(produts);
            db.SaveChanges();
            MessageBox.Show("ok");
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.AdminsPanel());
        }
    }
}
