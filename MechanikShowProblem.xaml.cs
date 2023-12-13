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
    /// Логика взаимодействия для MechanikShowProblem.xaml
    /// </summary>
    public partial class MechanikShowProblem : Window
    {
        public MechanikShowProblem()
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

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            var id = int.Parse(clientLogin.Text.Trim());

            using(DataContext context = new DataContext())
            {
                var info = context.ClientOrders
                    .Where(u => u.Id == id)
                    .Select(u => new {u.Name, u.PhoneNumber, u.Image, u.Description})
                    .FirstOrDefault();

                if (info != null)
                {
                    clientName.Text = info.Name;
                    clientPhone.Text = info.PhoneNumber;
                    clientProblem.Text = info.Description;
                    DataContext = new { ImagePath = info.Image };
                }

            }
        }
    }
}
