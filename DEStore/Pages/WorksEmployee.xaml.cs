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
    /// Логика взаимодействия для WorksEmployee.xaml
    /// </summary>
    public partial class WorksEmployee : Page
    {
        public static Model.destoreEntities2 db = new Model.destoreEntities2();

        public WorksEmployee()
        {
            InitializeComponent();
            myDataGrids.ItemsSource  = db.employee.ToList();
        }

        private void myDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
