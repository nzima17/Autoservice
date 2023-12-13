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
using System.Windows.Shapes;

namespace Autoservice
{
    /// <summary>
    /// Логика взаимодействия для AdminShowOrders.xaml
    /// </summary>
    public partial class AdminShowOrders : Window
    {
        public AdminShowOrders()
        {
            InitializeComponent();

            ResizeMode = ResizeMode.NoResize;
            WindowStyle = WindowStyle.SingleBorderWindow;

            showOrders();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AdminMain adminMain = new AdminMain();
            adminMain.Show();
            this.Close();
        }

        private void showOrders()
        {
            using (DataContext context = new DataContext())
            {
                var listOfOrders = context.ClientOrders
                    .Select(u => new { u.Name, u.PhoneNumber, u.OrderDate, u.FinishDate, u.OrderStatus, u.TotalPrice })
                    .ToList();
                orders.ItemsSource = listOfOrders;
            }
        }
    }
}
