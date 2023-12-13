using System.Windows;

namespace Autoservice
{
    /// <summary>
    /// Логика взаимодействия для MechanikMain.xaml
    /// </summary>
    public partial class MechanikMain : Window
    {
        public MechanikMain()
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
            MechanikShowProblem mechanikShowProblem = new MechanikShowProblem();
            mechanikShowProblem.Left = 600;
            mechanikShowProblem.Top = 200;
            mechanikShowProblem.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MechanikChangeStatus mechanikChangeStatus = new MechanikChangeStatus();
            mechanikChangeStatus.Left = 600;
            mechanikChangeStatus.Top = 200;
            mechanikChangeStatus.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MechanikShowSpareParts mechanikShowSpareParts = new MechanikShowSpareParts();
            mechanikShowSpareParts.Left = 600;
            mechanikShowSpareParts.Top = 200;
            mechanikShowSpareParts.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MechanikShowReview mechanikShowReview = new MechanikShowReview();
            mechanikShowReview.Left = 600;
            mechanikShowReview.Top = 200;
            mechanikShowReview.Show();
            this.Close();
        }
    }
}
