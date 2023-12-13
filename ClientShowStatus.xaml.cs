using Microsoft.EntityFrameworkCore;
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
    /// Логика взаимодействия для ClientShowStatus.xaml
    /// </summary>
    public partial class ClientShowStatus : Window
    {
        public ClientShowStatus()
        {
            InitializeComponent();

            ResizeMode = ResizeMode.NoResize;
            WindowStyle = WindowStyle.SingleBorderWindow;

            showStatus();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ClientMain clientMain = new ClientMain();
            clientMain.Show();
            this.Close();
        }

        private void showStatus()
        {
            UserLogin userLogin = UserLogin.Instance;
            string username = userLogin.GetUsername();

            using (DataContext context = new DataContext())
            {
                var clientOrder = context.ClientOrders
                    .Where(u => u.Username == username)
                    .Select(u=> new {u.Name, u.OrderDate, u.FinishDate, u.OrderStatus, u.TotalPrice})
                    .ToList();
                status.ItemsSource = clientOrder;
            }
        }
    }
}
