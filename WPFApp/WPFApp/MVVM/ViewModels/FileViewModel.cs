using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFApp.MVVM.Models;
using System.Net.Http;
using System.Net.Http.Headers;

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
                new File { AuditId = 1, FileName = "hello", CreatedDate = new DateTime(2021, 6, 4), User = "Peter", Activity = "Download", Error = null},
                new File { AuditId = 2, FileName = "world", CreatedDate = new DateTime(2019, 5, 21), User = "Harry", Activity = "Download", Error = null },
                new File { AuditId = 3, FileName = "how", CreatedDate = new DateTime(2020, 5, 14), User = "Grace", Activity = "Download", Error = null },
                new File { AuditId = 4, FileName = "are", CreatedDate = new DateTime(2021, 8, 26), User = "Simon", Activity = "Download", Error = null },
                new File { AuditId = 5, FileName = "you", CreatedDate = new DateTime(2020, 2, 20), User = "Talia", Activity = "Download", Error = null },
                new File { AuditId = 6, FileName = "fgsgfdxgf", CreatedDate = new DateTime(2021, 9, 9), User = "Vikk", Activity = "Download", Error = "Could not find file 'C:\\Users\\Lumanti.Dangol\\Documents\\Images\\fgsgfdxgf.pdf'." },
                new File { AuditId = 7, FileName = "world", CreatedDate = new DateTime(2021, 5, 4), User = "Josh", Activity = "Download", Error = null },
                new File { AuditId = 8, FileName = "how", CreatedDate = new DateTime(2021, 5, 14), User = "Freya", Activity = "Download", Error = null },
                new File { AuditId = 9, FileName = "abc", CreatedDate = new DateTime(2020, 1, 20), User = "Anne", Activity = "Download", Error = "Could not find file 'C:\\Users\\Lumanti.Dangol\\Documents\\Images\\abc.pdf'." },
                new File { AuditId = 10, FileName = "you", CreatedDate = new DateTime(2021, 7, 30), User = "Gee", Activity = "Download", Error = null },
            };
        }
    }
}
