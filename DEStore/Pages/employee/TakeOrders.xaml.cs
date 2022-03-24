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

namespace DEStore.Pages.employee
{
    /// <summary>
    /// Логика взаимодействия для TakeOrders.xaml
    /// </summary>
    public partial class TakeOrders : Page
    {
        public static Model.destoreEntities2 db = new Model.destoreEntities2();

        public TakeOrders()
        {
            InitializeComponent();
        }

        private void BCheckOrder_Click(object sender, RoutedEventArgs e)
        {
            Model.order orders = db.order.FirstOrDefault(o => o.confirmationСode.ToString() == TBCode.Text);
            if (orders != null)
            {
                orders.statusOrder = true;
                db.SaveChanges();
                MessageBox.Show("ready");
                return;
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Pages.employee.EmployeePanel());
        }
    }
}
