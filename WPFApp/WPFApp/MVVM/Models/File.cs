using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFApp.Core;

namespace WPFApp.MVVM.Models
{
    public class File : ObservableObject
    {
        private int fileId;
        private String fileName;
        private DateTime createdDate;
        private String user;
        private String activity;

        public int FileId
        {
            get { return fileId; }
            set
            {
                fileId = value;
                OnPropertyChanged();
            }
        }
        public String FileName
        {
            get { return fileName; }
            set 
            { 
                fileName = value;
                OnPropertyChanged();
            }
        }
        public DateTime CreatedDate
        {
            get { return createdDate; }
            set 
            { 
               createdDate = value;
                OnPropertyChanged();
            }
        }
        public String User
        {
            get { return user; }
            set
            {
                user = value;
                OnPropertyChanged();
            }
        }
        public String Activity
        {
            get { return activity; }
            set
            {
                activity = value;
                OnPropertyChanged();
            }
        }
    }
}
