using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
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
using WPFApp.MVVM.ViewModels;

namespace WPFApp.MVVM.Views
{
    /// <summary>
    /// Interaction logic for DownloadView.xaml
    /// </summary>
    public partial class DownloadView : UserControl
    {
        public DownloadView()
        {
            InitializeComponent();
            this.DataContext = new FileViewModel();
        }

        public class UploadedFileList
        {
            public string fileName { get; set; }
            public string date { get; set; }
            public string time { get; set; }
        }
        private async void BindUploadedFileLists()
        {
            HttpClient client = new HttpClient(new HttpClientHandler()
            {
                UseDefaultCredentials = true
            });

            client.BaseAddress = new Uri("https://localhost:44384/");
            //client.DefaultRequestHeaders.Add("appkey", "myapp_key");
            client.DefaultRequestHeaders.Accept.Add(
               new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await client.GetAsync("api/FileUpload/GetFilesList/Images");
            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                System.Diagnostics.Debug.WriteLine(responseBody);
                List<UploadedFileList> UploadedFiles = JsonConvert.DeserializeObject<List<UploadedFileList>>(responseBody);
                System.Diagnostics.Debug.WriteLine(UploadedFiles);
                UploadedFilesGrid.ItemsSource = (System.Collections.IEnumerable)UploadedFiles;
            }
            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

        private void View_Loaded(object sender, RoutedEventArgs e)
        {
            BindUploadedFileLists();
        }

        private async void Download_Click(object sender, MouseButtonEventArgs e)
        {
            HttpClient client = new HttpClient(new HttpClientHandler()
            {
                UseDefaultCredentials = true
            });
            HttpResponseMessage response = await client.GetAsync("https://localhost:44384/api/FileUpload/DownloadFile/test/docs");
            System.Diagnostics.Debug.WriteLine(response);
            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                System.Diagnostics.Debug.WriteLine(responseBody);
            }
        }
    }
}
