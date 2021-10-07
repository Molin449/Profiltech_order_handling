
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

            OrdersListPage ordersListPage = new OrdersListPage();
           
            contentView.Content = ordersListPage;






        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e) {
            base.OnMouseLeftButtonDown(e);

            // Begin dragging the window
            this.DragMove();
        }





        private void Navigation_Click(object sender, RoutedEventArgs e) {
            
            //Styles navigation button to be active color
            var buttons = Navigation.Children;
            Color activeNavBtnColor = (Color)ColorConverter.ConvertFromString("#2c3340");

            foreach (var currItem in buttons) {
                Button currButton = (Button)currItem;
                currButton.Background = Brushes.Transparent;
            }
         
            Button navButton = e.Source as Button;
            navButton.Background = new SolidColorBrush(activeNavBtnColor);

            //Change the page
            string pageName = navButton.Name;
            
            contentView.Content = FindTheCurrentPage(pageName);

            var list = contentView;
        }



        private Object FindTheCurrentPage(string pageName) {
            Object page = null;
            switch (pageName) {
                case "Orders":
                    page = new OrdersListPage();
                    break;
                default:
                    break;
            }

            return page;
        }
    }
}
