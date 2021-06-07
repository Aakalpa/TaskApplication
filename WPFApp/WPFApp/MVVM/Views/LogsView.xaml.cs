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
using WPFApp.MVVM.ViewModels;
using System.Net.Http;
using System.Net.Http.Headers;
using WPFApp.MVVM.Models;
using Newtonsoft.Json;

namespace WPFApp.MVVM.Views
{
    /// <summary>
    /// Interaction logic for LogsView.xaml
    /// </summary>
    public partial class LogsView : UserControl
    {
        public LogsView()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public class Audit
        {
            [JsonProperty("auditId")]
            public int auditId { get; set; }
            [JsonProperty("user")]
            public string user { get; set; }
            [JsonProperty("createdDate")]
            public DateTime createdDate { get; set; }
            [JsonProperty("fileName")]
            public string fileName { get; set; }
            [JsonProperty("activity")]
            public string activity { get; set; }
            [JsonProperty("error")]
            public errorDetails error { get; set; }
        }

        public class errorDetails
        {
            [JsonProperty("errorId")]
            public int errorId { get; set; }
            [JsonProperty("message")]
            public string message { get; set; }
            [JsonProperty("stackTrace")]
            public string stackTrace { get; set; }
            [JsonProperty("auditId")]
            public int auditId { get; set; }
            [JsonProperty("auditLog")]
            public string auditLog { get; set; }
        }

        private async void BindFileList()
        {
            HttpClient client = new HttpClient(new HttpClientHandler()
            {
                UseDefaultCredentials = true
            });
            HttpResponseMessage response = await client.GetAsync("https://localhost:44384/api/FileUpload/GetAuditLogWithError"); 
            System.Diagnostics.Debug.WriteLine(response);
            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                System.Diagnostics.Debug.WriteLine(responseBody);
                List<Audit> Audits = JsonConvert.DeserializeObject<List<Audit>>(responseBody);
                LogsGrid.ItemsSource = (System.Collections.IEnumerable)Audits;

            }
            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }

        private void View_Loaded(object sender, RoutedEventArgs e)
        {
            BindFileList();
        }
    }
}
