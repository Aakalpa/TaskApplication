using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFApp.Core;
using WPFApp.MVVM.Models;

namespace WPFApp.MVVM.ViewModels
{
    public class DownloadViewModel : ObservableObject
    {
        DAL DataAccess;
        public DownloadViewModel()
        {
            DataAccess = new DAL();
        }
        private ObservableCollection<File> data = new ObservableCollection<File>();
        public ObservableCollection<File> Data
        {
            get { return data; }
            set
            {
                data = value;
                OnPropertyChanged();
            }
        }
        private void LoadData()
        {
            Data = new ObservableCollection<File>(DataAccess.GetAll());
        }
    }
}
