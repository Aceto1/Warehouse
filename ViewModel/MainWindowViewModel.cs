using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Threading;
using GalaSoft.MvvmLight.CommandWpf;
using Warehouse.Client.Annotations;
using Warehouse.Client.Properties;

namespace Warehouse.Client.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private string windowTitle;

        public MainWindowViewModel()
        {
            
        }

        public string WindowTitle => $"{Resources.WindowTitle} - 1.0.0.0";

        public RelayCommand ChangeLanguageCommand => new RelayCommand(ChangeLanguage);

        public void ChangeLanguage()
        {
            Resources.Culture = new CultureInfo("en");
            OnPropertyChanged(nameof(WindowTitle));
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        } 
        #endregion
    }
}
