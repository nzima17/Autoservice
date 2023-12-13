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
    /// Логика взаимодействия для SkladPartsUpdate.xaml
    /// </summary>
    public partial class SkladPartsUpdate : Window
    {
        public SkladPartsUpdate()
        {
            InitializeComponent();

            ResizeMode = ResizeMode.NoResize;
            WindowStyle = WindowStyle.SingleBorderWindow;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SkladMain skladMain = new SkladMain();
            skladMain.Show();
            this.Close();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            var Id = int.Parse(id.Text.Trim());
            var Name = name.Text.Trim();
            var Category = category.Text.Trim();
            var Model = model.Text.Trim();
            var description = desc.Text.Trim();
            var inStock = stock.Text.Trim();
            var Price = price.Text.Trim();

            using(DataContext context = new DataContext())
            {
                var toUpdate = context.SparePartsList.FirstOrDefault(u => u.Id == Id);

                if (toUpdate != null)
                {
                    toUpdate.Name = Name;
                    toUpdate.Category = Category;
                    toUpdate.Compatibility = Model;
                    toUpdate.Description = description;
                    toUpdate.InStock = inStock;
                    toUpdate.Price = Price;

                    context.SaveChanges();
                    MessageBox.Show("Изменения успешно сохранены!");
                }
                else
                {
                    MessageBox.Show("Такой запчасти нет в каталоге!");
                }
            }
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            var Id = int.Parse(id.Text.Trim());
            using(DataContext context = new DataContext())
            {
                var parts = context.SparePartsList
                    .Where(u=>u.Id== Id)
                    .Select(u => new { u.Name, u.Category, u.Compatibility, u.Description, u.InStock, u.Price})
                    .FirstOrDefault();

                name.Text = parts.Name;
                category.Text = parts.Category;
                model.Text = parts.Compatibility;
                desc.Text = parts.Description;
                stock.Text = parts.InStock;
                price.Text = parts.Price;
            }
        }
    }
}
