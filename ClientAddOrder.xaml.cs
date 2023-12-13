using Microsoft.Win32;
using System.Windows;

namespace Autoservice
{
    /// <summary>
    /// Логика взаимодействия для ClientAddOrder.xaml
    /// </summary>
    public partial class ClientAddOrder : Window
    {
        private string imagePath;
        public ClientAddOrder()
        {
            InitializeComponent();

            ResizeMode = ResizeMode.NoResize;
            WindowStyle = WindowStyle.SingleBorderWindow;
        }

        private void OpenImageFileDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Изображения (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png|Все файлы (*.*)|*.*";

            bool? result = openFileDialog.ShowDialog();

            if (result == true)
            {
                // Получаем путь к выбранному файлу
                imagePath = openFileDialog.FileName;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenImageFileDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainPage();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var FullName = fullName.Text.Trim();
            var PhoneNumber = phoneNumber.Text.Trim();
            var Description = desc.Text.Trim();
            UserLogin userLogin = UserLogin.Instance;
            string username = userLogin.GetUsername();

            using (DataContext context = new DataContext())
            {
                if (!FullName.Equals("") && !PhoneNumber.Equals("") && !Description.Equals(""))
                {
                    context.ClientOrders.Add(new Order() {Name=FullName, PhoneNumber=PhoneNumber, Description=Description, Image=imagePath, OrderDate=System.DateTime.Now, OrderStatus="В ожидании", Username=username});
                    context.SaveChanges();
                    MessageBox.Show("Ваш заказ успешно сохранен!");
                    MainPage();
                }
                else
                {
                    MessageBox.Show("Значения полей пустые!\nВведите значения полей.");
                }
            }
        }

        public void MainPage()
        {
            ClientMain clientMain = new ClientMain();
            clientMain.Show();
            this.Close();
        }
    }
}
