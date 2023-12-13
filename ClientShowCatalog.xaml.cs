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
    /// Логика взаимодействия для ClientShowCatalog.xaml
    /// </summary>
    public partial class ClientShowCatalog : Window
    {
        public ClientShowCatalog()
        {
            InitializeComponent();

            ResizeMode = ResizeMode.NoResize;
            WindowStyle = WindowStyle.SingleBorderWindow;

            showCatalog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ClientMain clientMain = new ClientMain();
            clientMain.Show();
            this.Close();
        }

        private void showCatalog()
        {
            using(DataContext context = new DataContext())
            {
                var listOfCatalog = context.ServiceCatalog
                    .Select(u => new {u.Name, u.Price})
                    .ToList();
                catalog.ItemsSource = listOfCatalog;
            }
        }
    }
}
