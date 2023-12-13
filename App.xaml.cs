using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Windows;

namespace Autoservice
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            DatabaseFacade facade = new DatabaseFacade(new DataContext());
            facade.EnsureCreated();
            //using (var context = new DataContext())
            //{
            //context.Database.Migrate();
            //}
        }
    }
}
