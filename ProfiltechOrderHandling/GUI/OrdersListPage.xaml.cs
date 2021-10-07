using ProfiltechOrderHandling.Model;
using ProfiltechOrderHandling.Service;
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

namespace ProfiltechOrderHandling.GUI {
    /// <summary>
    /// Interaction logic for OrdersListPage.xaml
    /// </summary>
    public partial class OrdersListPage : Page {
        public OrdersListPage() {
            InitializeComponent();


            OrdersService os = new OrdersService();
            List<Order> orders = os.GetOrders("40608");
            dataGrid.DataContext = orders;
            dataGrid.CanUserResizeRows = false;

        }



        //private void datagrid_mousedoubleclick(object sender, mousebuttoneventargs e) {
        //    order customer = (order)datagrid.selecteditem;
        //    itemwindow window = new itemwindow();
        //    window.show();
        //    this.close();
        //}
    }
}
