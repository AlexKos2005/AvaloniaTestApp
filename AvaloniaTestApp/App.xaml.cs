using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using AvaloniaTestApp.ViewModels;
using AvaloniaTestApp.Views;
using AvaloniaTestApp.DAL.Interfaces;
using AvaloniaTestApp.DAL.Services;
using AvaloniaTestApp.BLL.Interfaces;
using AvaloniaTestApp.BLL.Services;

namespace AvaloniaTestApp
{
    public class App : Application
    {
        private IJsonRepository _jsonRepository = null;
        private ISqlRepository _sqlRepository = null;
        private IModbusMaster _modbusMaster = null;
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            _jsonRepository = new JSonRepository();
            _sqlRepository = new SqLiteRepository();
            _modbusMaster = new ModbusRTUMaster();
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainWindow
                {
                    DataContext = new MainWindowViewModel(_jsonRepository, _sqlRepository,_modbusMaster),
                };
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}
