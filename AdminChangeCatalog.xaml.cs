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
    /// Логика взаимодействия для AdminChangeCatalog.xaml
    /// </summary>
    public partial class AdminChangeCatalog : Window
    {
        public AdminChangeCatalog()
        {
            InitializeComponent();
            ResizeMode = ResizeMode.NoResize;
            WindowStyle = WindowStyle.SingleBorderWindow;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AdminMain adminMain = new AdminMain();
            adminMain.Show();
            this.Close();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            var Id = int.Parse(id.Text.Trim());
            var Name = name.Text.Trim();
            var Price = price.Text.Trim();

            using(DataContext context  = new DataContext())
            {
                var toUpdate = context.ServiceCatalog.FirstOrDefault(u => u.Id == Id);

                if(toUpdate != null)
                {
                    toUpdate.Name = Name;
                    toUpdate.Price = Price;

                    context.SaveChanges();
                    MessageBox.Show("Изменения успешно сохранены!");
                }
                else
                {
                    MessageBox.Show("Такой услуги нет в каталоге!");
                }
            }
        }
    }
}
