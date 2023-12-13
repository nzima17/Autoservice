using System.Windows;

namespace Autoservice
{
    /// <summary>
    /// Логика взаимодействия для SkladMain.xaml
    /// </summary>
    public partial class SkladMain : Window
    {
        public SkladMain()
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
            SkladAddPart skladAddPart = new SkladAddPart();
            skladAddPart.Left = 600;
            skladAddPart.Top = 200;
            skladAddPart.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SkladPartsUpdate skladPartsUpdate = new SkladPartsUpdate();
            skladPartsUpdate.Left = 600;
            skladPartsUpdate.Top = 200;
            skladPartsUpdate.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            SkladPartsDelete skladPartsDelete = new SkladPartsDelete();
            skladPartsDelete.Left = 600;
            skladPartsDelete.Top = 200;
            skladPartsDelete.Show();
            this.Close();
        }
    }
}
