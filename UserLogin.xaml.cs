using System.Linq;
using System.Windows;

namespace Autoservice
{
    /// <summary>
    /// Логика взаимодействия для UserLogin.xaml
    /// </summary>
    public partial class UserLogin : Window
    {
        private string Username;

        private static UserLogin instance;
        public UserLogin()
        {
            InitializeComponent();

            ResizeMode = ResizeMode.NoResize;
            WindowStyle = WindowStyle.SingleBorderWindow;

            Left = 500;
            Top = 150;

            instance = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UserRegister userRegister = new UserRegister();
            userRegister.Left = Left;
            userRegister.Top = Top;
            userRegister.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Username = login.Text.Trim();
            var Password = password.Password.Trim();

            using (DataContext context = new DataContext())
            {
                bool userFound = context.Users.Any(user => user.Login == Username && user.Password == Password);

                if (userFound)
                {
                    if ("admin".Equals(Username.ToLower()))
                    {
                        AdminWindow();
                        this.Close();
                    }
                    else if ("sklad".Equals(Username.ToLower()))
                    {
                        SkladWindow();
                        this.Close();
                    }
                    else if ("mechanic".Equals(Username.ToLower()))
                    {
                        MechanikWindow();
                        this.Close();
                    }
                    else
                    {
                        ClientWindow();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль!");
                }

            }
        }

        public void ClientWindow()
        {
            ClientMain clientMain = new ClientMain();
            clientMain.Left = Left;
            clientMain.Top = Top;
            clientMain.Show();
        }

        public void AdminWindow()
        {
            AdminMain adminMain = new AdminMain();
            adminMain.Left = Left;
            adminMain.Top = Top;
            adminMain.Show();
        }

        public void SkladWindow()
        {
            SkladMain skladMain = new SkladMain();
            skladMain.Left = Left;
            skladMain.Top = Top;
            skladMain.Show();
        }

        public void MechanikWindow()
        {
            MechanikMain mechanikMain = new MechanikMain();
            mechanikMain.Left = Left;
            mechanikMain.Top = Top;
            mechanikMain.Show();
        }

        public string GetUsername()
        {
            return Username;
        }

        public static UserLogin Instance
        {
            get { return instance; }
        }
    }
}
