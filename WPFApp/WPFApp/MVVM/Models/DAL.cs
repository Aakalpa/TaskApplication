using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFApp.MVVM.Models
{
    public class File
    {
        private String fileName;
        private DateTime createdDate;
        public String FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }
        public DateTime CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; }
        }
    }
    public class DAL
    {
        public ObservableCollection<Object> Data = new ObservableCollection<Object>();
        public DAL()
        {
            Data.Add(new File() { FileName = "hello", CreatedDate = new DateTime(2021, 6, 4)});
            Data.Add(new File() { FileName = "world", CreatedDate = new DateTime(2021, 6, 4) });
            Data.Add(new File() { FileName = "how", CreatedDate = new DateTime(2021, 6, 4) });
            Data.Add(new File() { FileName = "are", CreatedDate = new DateTime(2021, 6, 4) });
            Data.Add(new File() { FileName = "you", CreatedDate = new DateTime(2021, 6, 4) });
        }
    }
}
