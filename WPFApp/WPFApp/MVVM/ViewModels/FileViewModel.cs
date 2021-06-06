using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFApp.MVVM.Models;

namespace WPFApp.MVVM.ViewModels
{

    public class FileViewModel
    {
        private IList<File> _FileList;

        public IList<File> Files
        {
            get { return _FileList; }
        }

        public FileViewModel()
        {
            _FileList = new List<File>
            {
                new File { FileId = 1, FileName = "hello", CreatedDate = new DateTime(2021, 6, 4), User = "Peter", Activity = "Download"},
                new File { FileId = 2, FileName = "world", CreatedDate = new DateTime(2019, 5, 21), User = "Harry", Activity = "Upload" },
                new File { FileId = 3, FileName = "how", CreatedDate = new DateTime(2020, 5, 14), User = "Grace", Activity = "Upload" },
                new File { FileId = 4, FileName = "are", CreatedDate = new DateTime(2021, 8, 26), User = "Simon", Activity = "Download" },
                new File { FileId = 5, FileName = "you", CreatedDate = new DateTime(2020, 2, 20), User = "Talia", Activity = "Upload" },
                new File { FileId = 6, FileName = "hello", CreatedDate = new DateTime(2021, 9, 9), User = "Vikk", Activity = "Download"},
                new File { FileId = 7, FileName = "world", CreatedDate = new DateTime(2021, 5, 4), User = "Josh", Activity = "Upload" },
                new File { FileId = 8, FileName = "how", CreatedDate = new DateTime(2021, 5, 14), User = "Freya", Activity = "Download" },
                new File { FileId = 9, FileName = "are", CreatedDate = new DateTime(2020, 1, 20), User = "Anne", Activity = "Download" },
                new File { FileId = 10, FileName = "you", CreatedDate = new DateTime(2021, 7, 30), User = "Gee", Activity = "Upload" },
            };
        }
    }
}
