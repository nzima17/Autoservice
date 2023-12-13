using System.Windows;

namespace Autoservice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Create()
        {
            using (DataContext context = new DataContext())
            {
            }
        }
    }
}
