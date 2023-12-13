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
    /// Логика взаимодействия для AdminDeleteOrder.xaml
    /// </summary>
    public partial class AdminDeleteOrder : Window
    {
        public AdminDeleteOrder()
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
                    .Select(u => new { u.Id, u.Name, u.PhoneNumber, u.OrderDate, u.FinishDate, u.OrderStatus, u.TotalPrice })
                    .ToList();
                orders.ItemsSource = listOfOrders;
            }
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            var orderId = int.Parse(id.Text.Trim());
            
            using (DataContext context = new DataContext())
            {
                var orderToDelete = context.ClientOrders.FirstOrDefault(u => u.Id == orderId);

                if(orderToDelete != null)
                {
                    context.ClientOrders.Remove(orderToDelete);
                    context.SaveChanges();
                    MessageBox.Show("Заказ успешно удален!");
                    showOrders();
                }
                else
                {
                    MessageBox.Show("Введите правильный id!");
                }
            }
        }
    }
}
