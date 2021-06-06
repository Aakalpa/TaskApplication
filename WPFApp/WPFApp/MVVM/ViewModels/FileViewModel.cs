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
                new File { FileId = 2, FileName = "world", CreatedDate = new DateTime(2021, 5, 21), User = "Harry", Activity = "Upload" },
                new File { FileId = 3, FileName = "how", CreatedDate = new DateTime(2021, 5, 14), User = "Grace", Activity = "Upload" },
                new File { FileId = 4, FileName = "are", CreatedDate = new DateTime(2021, 8, 26), User = "Simon", Activity = "Download" },
                new File { FileId = 5, FileName = "you", CreatedDate = new DateTime(2021, 2, 18), User = "Talia", Activity = "Upload" },
            };
        }
    }
}
