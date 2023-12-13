using System.Linq;
using System.Windows;

namespace Autoservice
{
    /// <summary>
    /// Логика взаимодействия для UserRegister.xaml
    /// </summary>
    public partial class UserRegister : Window
    {
        public UserRegister()
        {
            InitializeComponent();

            ResizeMode = ResizeMode.NoResize;
            WindowStyle = WindowStyle.SingleBorderWindow;
            Left = 500;
            Top = 150;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            UserLogin userLogin = new UserLogin();
            userLogin.Left = Left;
            userLogin.Top = Top;
            userLogin.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var Username = login.Text.Trim();
            var Password = password.Password.Trim();
            var PasswordCheck = checkPassword.Password.Trim();

            using (DataContext context = new DataContext())
            {
                bool userFound = context.Users.Any(user => user.Login == Username);

                if (userFound)
                {
                    MessageBox.Show("Пользователь с таким логином уже существует!\nПридумайте другой логин.");
                }
                else
                {
                    if (!Username.Equals("") && !Password.Equals("") && !PasswordCheck.Equals(""))
                    {
                        if (Password != PasswordCheck)
                        {
                            MessageBox.Show("Пароли не совпадают!\nВведите пароль правильно.");
                        }
                        else
                        {
                            context.Users.Add(new User() { Login = Username, Password = Password });
                            context.SaveChanges();
                            UserLogin();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Значения полей пустые!\nВведите значения полей.");
                    }
                }

            }
        }
        public void UserLogin()
        {
            UserLogin login = new UserLogin();
            login.Left = Left;
            login.Top = Top;
            login.Show();

        }
    }
}
