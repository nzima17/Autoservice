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
    /// Логика взаимодействия для MechanikShowSpareParts.xaml
    /// </summary>
    public partial class MechanikShowSpareParts : Window
    {
        public MechanikShowSpareParts()
        {
            InitializeComponent();

            ResizeMode = ResizeMode.NoResize;
            WindowStyle = WindowStyle.SingleBorderWindow;

            showSpareParts();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MechanikMain mechanikMain = new MechanikMain();
            mechanikMain.Show();
            this.Close();
        }

        private void showSpareParts()
        {
            using (DataContext context = new DataContext())
            {
                var listOfSpareParts = context.SparePartsList
                    .Select(u => new {u.Name, u.Category, u.Compatibility, u.Description, u.Price})
                    .ToList();
                spareParts.ItemsSource = listOfSpareParts;
            }
        }
    }
}
