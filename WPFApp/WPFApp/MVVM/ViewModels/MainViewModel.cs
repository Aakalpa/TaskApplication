﻿using System;
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
        public RelayCommand DownloadViewCommand { get; set; }
        #endregion

        #region ViewModelInstances
        public HomeViewModel HomeVM { get; set; }
        public DownloadViewModel DownloadVM { get; set; }
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
            DownloadVM = new DownloadViewModel();

            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            DownloadViewCommand = new RelayCommand(o =>
            {
                CurrentView = DownloadVM;
            });
        }
    }
}