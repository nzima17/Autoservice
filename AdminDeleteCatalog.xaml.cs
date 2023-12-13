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
    /// Логика взаимодействия для AdminDeleteCatalog.xaml
    /// </summary>
    public partial class AdminDeleteCatalog : Window
    {
        public AdminDeleteCatalog()
        {
            InitializeComponent();

            ResizeMode = ResizeMode.NoResize;
            WindowStyle = WindowStyle.SingleBorderWindow;

            showCatalog();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            var catalogId = int.Parse(id.Text.Trim());

            using (DataContext context = new DataContext())
            {
                var catalogToDelete = context.ServiceCatalog.FirstOrDefault(u => u.Id == catalogId);

                if (catalogToDelete != null)
                {
                    context.ServiceCatalog.Remove(catalogToDelete);
                    context.SaveChanges();
                    MessageBox.Show("Услуга успешно удалена!");
                    showCatalog();
                }
                else
                {
                    MessageBox.Show("Введите правильный id!");
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AdminMain adminMain = new AdminMain();
            adminMain.Show();
            this.Close();
        }

        private void showCatalog()
        {
            using (DataContext context = new DataContext())
            {
                var catalogList = context.ServiceCatalog.ToList();
                catalog.ItemsSource = catalogList;
            }
        }
    }
}
