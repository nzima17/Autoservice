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
    /// Логика взаимодействия для ClientAddReview.xaml
    /// </summary>
    public partial class ClientAddReview : Window
    {
        public ClientAddReview()
        {
            InitializeComponent();

            ResizeMode = ResizeMode.NoResize;
            WindowStyle = WindowStyle.SingleBorderWindow;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var Review = review.Text.Trim();

            using (DataContext context = new DataContext())
            {
                if (!Review.Equals(""))
                {
                    context.Reviews.Add(new Review() { Description=Review});
                    context.SaveChanges();
                    MessageBox.Show("Ваш отзыв успешно сохранен!");
                    MainPage();

                    
                }
                else
                {
                    MessageBox.Show("Значения полей пустые!\nВведите значения полей.");
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ClientMain clientMain = new ClientMain();
            clientMain.Show();
            this.Close();
        }

        public void MainPage()
        {
            ClientMain clientMain = new ClientMain();
            clientMain.Show();
            this.Close();
        }
    }
}
