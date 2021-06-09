using System;
using System.Collections.Generic;
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
using System.Net.Http;
using System.Net;
using System.IO;
using System.Net.Http.Headers;
using System.Globalization;

namespace WPFApp.MVVM.Views
{
    /// <summary>
    /// Interaction logic for UploadView.xaml
    /// </summary>
    public partial class UploadView : UserControl
    {
        public UploadView()
        {
            InitializeComponent();
        }

        private void BrowseButton_Click(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog
            Microsoft.Win32.OpenFileDialog openFileDlg = new Microsoft.Win32.OpenFileDialog();

            // Launch OpenFileDialog by calling ShowDialog method
            Nullable<bool> result = openFileDlg.ShowDialog();
            // Get the selected file name and display in a TextBox.
            // Load content of file in a TextBlock
            if (result == true) //if the dialog box is opened
            {
                FileNameTextBox.Text = openFileDlg.FileName;
            }
        }

        private void BtnUpload_Click(object sender, RoutedEventArgs e)
        {
            var fileToUpload = FileNameTextBox.Text;

            #region Using_HTTPClient
            //HttpClient client = new HttpClient(new HttpClientHandler()
            //{
            //    UseDefaultCredentials = true
            //});
            //System.Diagnostics.Debug.WriteLine(FileToUpload);

            //var response = await client.PostAsJsonAsync("https://localhost:44384/api/FileUpload/UploadFile", FileToUpload);

            //if (response.IsSuccessStatusCode)
            //{
            //    MessageBox.Show("File Uploaded");
            //    FileNameTextBox.Text = "";
            //}
            //else
            //{
            //    MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            //}
            #endregion

            #region Using_WebAclient
            using (var client = new WebClient()) //WebClient  
            {
                client.Credentials = CredentialCache.DefaultCredentials;
                byte[] response = client.UploadFile("https://localhost:44384/api/FileUpload/UploadFile", fileToUpload);
                string s = System.Text.Encoding.UTF8.GetString(response, 0, response.Length);
                MessageBox.Show(s);
            }
            #endregion


        }
    }
}
