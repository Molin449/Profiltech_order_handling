
using ProfiltechOrderHandling.GUI;
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

namespace ProfiltechOrderHandling {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            OrdersService os = new OrdersService();
            List<Order> orders = os.GetOrders("40608");

            TestPage tp = new TestPage();
           
            contentView.Content = tp;

            
            
            
            
            
            //dataGrid.DataContext = orders;
            //dataGrid.CanUserResizeRows = false;
        }

        //private void dataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e) {
        //    Order customer = (Order) dataGrid.SelectedItem;
        //    ItemWindow window = new ItemWindow();
        //    window.Show();
        //    this.Close();
        //}

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e) {
            base.OnMouseLeftButtonDown(e);

            // Begin dragging the window
            this.DragMove();
        }
    }
}
