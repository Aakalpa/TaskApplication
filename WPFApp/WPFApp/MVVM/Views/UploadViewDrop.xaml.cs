using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFApp.MVVM.Views
{
    /// <summary>
    /// Interaction logic for UploadViewDrop.xaml
    /// </summary>
    public partial class UploadViewDrop : UserControl
    {
        public UploadViewDrop()
        {
            InitializeComponent();
        }
        private void Rectangle_Drop(object sender, DragEventArgs e)
        {
            //checking what kind of file is user dropping
            if(e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                string fileName = System.IO.Path.GetFileName(files[0]);
                //iterate and add all files to upload
                for (int i = 0; i < files.Length; i++)
                {
                    string filename = System.IO.Path.GetFileName(files[i]);
                    FileInfo fileInfo = new FileInfo(files[i]);
                    UploadingFileList.Items.Add(new FileDetails()
                    {
                        FileName = filename,

                        //to convert bytes to Mb
                        FileSize = string.Format("{0} {1}", (fileInfo.Length / 1.049e+6).ToString("0.0"), "Mb"),
                        UploadProgress = 100,
                    });
                }
            }
        }

        private void BtnUpload_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            bool? response = openFileDialog.ShowDialog();
            if (response == true)
            {
                //Get selected file and add them to upload
                string file = openFileDialog.FileName;
                string filename = System.IO.Path.GetFileName(file);
                FileInfo fileInfo = new FileInfo(file);
                UploadingFileList.Items.Add(new FileDetails()
                {
                    FileName = filename,

                    //to convert bytes to Mb
                    FileSize = string.Format("{0} {1}", (fileInfo.Length / 1.049e+6).ToString("0.0"), "Mb"),
                    UploadProgress = 100,
                });
            }
        }
    }
}
