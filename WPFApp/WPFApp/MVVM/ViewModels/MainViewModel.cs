using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFApp.Core;

namespace WPFApp.MVVM.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        #region RelayCommandInstances
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand UploadViewCommand { get; set; }
        public RelayCommand DownloadViewCommand { get; set; }
        public RelayCommand LogsViewCommand { get; set; }
        #endregion

        #region ViewModelInstances
        public HomeViewModel HomeVM { get; set; }
        public UploadViewModel UploadVM { get; set; }
        public DownloadViewModel DownloadVM { get; set; }
        public LogsViewModel LogsVM { get; set; }
        #endregion

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set 
            { 
                _currentView = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            UploadVM = new UploadViewModel();
            DownloadVM = new DownloadViewModel();
            LogsVM = new LogsViewModel();

            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            UploadViewCommand = new RelayCommand(o =>
            {
                CurrentView = UploadVM;
            });
            

            DownloadViewCommand = new RelayCommand(o =>
            {
                CurrentView = DownloadVM;
            });

            LogsViewCommand = new RelayCommand(o =>
            {
                CurrentView = LogsVM;
            });
        }
    }
}
