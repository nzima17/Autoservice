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
    /// Логика взаимодействия для AdminAddToCatalog.xaml
    /// </summary>
    public partial class AdminAddToCatalog : Window
    {
        public AdminAddToCatalog()
        {
            InitializeComponent();
            ResizeMode = ResizeMode.NoResize;
            WindowStyle = WindowStyle.SingleBorderWindow;

        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            var Name = name.Text.Trim();
            var Price = price.Text.Trim();

            using (DataContext context = new DataContext())
            {
                if (Name != null && Price != null)
                {
                    context.ServiceCatalog.Add(new Catalog() { Name = Name, Price = Price });
                    context.SaveChanges();
                    MessageBox.Show("Новая услуга успешно сохранена!");
                }
                else
                {
                    MessageBox.Show("Заполните поля!!");
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AdminMain adminMain = new AdminMain();
            adminMain.Show();
            this.Close();
        }
    }
}
