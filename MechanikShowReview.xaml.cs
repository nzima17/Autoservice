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
    /// Логика взаимодействия для MechanikShowReview.xaml
    /// </summary>
    public partial class MechanikShowReview : Window
    {
        public MechanikShowReview()
        {
            InitializeComponent();

            ResizeMode = ResizeMode.NoResize;
            WindowStyle = WindowStyle.SingleBorderWindow;

            showReviews();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MechanikMain mechanikMain = new MechanikMain();
            mechanikMain.Show();
            this.Close();
        }

        private void showReviews()
        {
            using (DataContext context = new DataContext())
            {
                var reviewList = context.Reviews.ToList();
                review.ItemsSource = reviewList;
            }
        }
    }
}
