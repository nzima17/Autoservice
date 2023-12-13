using System.Windows;

namespace Autoservice
{
    /// <summary>
    /// Логика взаимодействия для AdminMain.xaml
    /// </summary>
    public partial class AdminMain : Window
    {
        public AdminMain()
        {
            InitializeComponent();

            ResizeMode = ResizeMode.NoResize;
            WindowStyle = WindowStyle.SingleBorderWindow;

            Left = 500;
            Top = 150;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UserLogin userLogin = new UserLogin();
            userLogin.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AdminShowOrders adminShowOrders = new AdminShowOrders();
            adminShowOrders.Left = 600;
            adminShowOrders.Top = 200;
            adminShowOrders.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AdminDeleteOrder adminDeleteOrder = new AdminDeleteOrder();
            adminDeleteOrder.Left = 600;
            adminDeleteOrder.Top = 200;
            adminDeleteOrder.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            AdminAddToCatalog adminAddToCatalog = new AdminAddToCatalog();
            adminAddToCatalog.Left = 600;
            adminAddToCatalog.Top = 200;
            adminAddToCatalog.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            AdminChangeCatalog adminChange = new AdminChangeCatalog();
            adminChange.Left = 600;
            adminChange.Top = 200;
            adminChange.Show();
            this.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            AdminDeleteCatalog adminDeleteCatalog = new AdminDeleteCatalog();
            adminDeleteCatalog.Left = 600;
            adminDeleteCatalog.Top = 200;
            adminDeleteCatalog.Show();
            this.Close();
        }
    }
}
