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
    /// Логика взаимодействия для SkladPartsDelete.xaml
    /// </summary>
    public partial class SkladPartsDelete : Window
    {
        public SkladPartsDelete()
        {
            InitializeComponent();

            ResizeMode = ResizeMode.NoResize;
            WindowStyle = WindowStyle.SingleBorderWindow;

            showPartsList();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            var partId = int.Parse(id.Text.Trim());

            using (DataContext context = new DataContext())
            {
                var partToDelete = context.SparePartsList.FirstOrDefault(u => u.Id == partId);

                if (partToDelete != null)
                {
                    context.SparePartsList.Remove(partToDelete);
                    context.SaveChanges();
                    MessageBox.Show("Запчасть успешно удалена!");
                    showPartsList();
                }
                else
                {
                    MessageBox.Show("Введите правильный id!");
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SkladMain skladMain = new SkladMain();
            skladMain.Show();
            this.Close();
        }

        private void showPartsList()
        {
            using (DataContext context = new DataContext())
            {
                var parts = context.SparePartsList
                    .Select(u => new {u.Id, u.Name, u.Category, u.Compatibility, u.InStock, u.Price})
                    .ToList();
                partsList.ItemsSource = parts;
            }
        }
    }
}
