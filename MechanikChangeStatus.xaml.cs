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
    /// Логика взаимодействия для MechanikChangeStatus.xaml
    /// </summary>
    public partial class MechanikChangeStatus : Window
    {
        public MechanikChangeStatus()
        {
            InitializeComponent();

            ResizeMode = ResizeMode.NoResize;
            WindowStyle = WindowStyle.SingleBorderWindow;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MechanikMain mechanikMain = new MechanikMain();
            mechanikMain.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var id = int.Parse(clientLogin.Text.Trim());
            var orderStatus = status.Text.Trim();
            var finishDate = date.SelectedDate;
            var orderPrice = price.Text.Trim();

            using(DataContext context = new DataContext())
            {
                var orderToUpdate = context.ClientOrders.FirstOrDefault(u => u.Id == id);

                if (orderToUpdate != null)
                {
                    orderToUpdate.OrderStatus = orderStatus;
                    orderToUpdate.FinishDate = finishDate;
                    orderToUpdate.TotalPrice = orderPrice;

                    context.SaveChanges();

                    MessageBox.Show("Изменения успешно сохранены!");
                }
                else
                {
                    MessageBox.Show("Пользователь не найден!");
                }
            }
        }
    }
}
