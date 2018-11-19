using System.Globalization;
using System.Windows;

namespace Warehouse.Client
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            Warehouse.Client.Properties.Resources.Culture = new CultureInfo("de-DE");
        }
    }
}
