using System.Windows;

namespace Autoservice
{
    /// <summary>
    /// Логика взаимодействия для ClientMain.xaml
    /// </summary>
    public partial class ClientMain : Window
    {
        public ClientMain()
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
            ClientAddOrder clientAddOrder = new ClientAddOrder();
            clientAddOrder.Left = 600;
            clientAddOrder.Top = 200;
            clientAddOrder.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ClientShowCatalog clientShowCatalog = new ClientShowCatalog();
            clientShowCatalog.Left = 600;
            clientShowCatalog.Top = 200;
            clientShowCatalog.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ClientShowStatus clientShowStatus = new ClientShowStatus();
            clientShowStatus.Left = 600;
            clientShowStatus.Top = 200;
            clientShowStatus.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ClientAddReview clientAddReview = new ClientAddReview();
            clientAddReview.Left = 600;
            clientAddReview.Top = 200;
            clientAddReview.Show();
            this.Close();
        }
    }
}
