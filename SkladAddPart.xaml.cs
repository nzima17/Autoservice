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
    /// Логика взаимодействия для SkladAddPart.xaml
    /// </summary>
    public partial class SkladAddPart : Window
    {
        public SkladAddPart()
        {
            InitializeComponent();


            ResizeMode = ResizeMode.NoResize;
            WindowStyle = WindowStyle.SingleBorderWindow;
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            var Name = name.Text.Trim();
            var Category = category.Text.Trim();
            var Model = model.Text.Trim();
            var description = desc.Text.Trim();
            var inStock = stock.Text.Trim();
            var Price = price.Text.Trim();

            using(DataContext context =  new DataContext())
            {
                if (Name != null && Price != null && Category != null && Model != null && description != null && inStock != null)
                {
                    context.SparePartsList.Add(new SpareParts() { 
                        Name = Name, 
                        Category = Category,
                        Compatibility = Model,
                        Description = description,
                        InStock = inStock,
                        Price = Price
                    });
                    context.SaveChanges();
                    MessageBox.Show("Новая запчасть успешно сохранена!");
                }
                else
                {
                    MessageBox.Show("Заполните поля!!");
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SkladMain skladMain = new SkladMain();
            skladMain.Show();
            this.Close();
        }
    }
}
