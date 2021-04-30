using ASPNETBeginLib.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
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

namespace WPFQueryResponse
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string WebServiceUrl { get; set; } = "http://192.168.56.101";
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Task.Run(() => InitialDataGrid());
        }

        public void InitialDataGrid() 
        {
            try
            {
                string URL = WebServiceUrl + "/api/phone";
                WebClient client = new WebClient();
                string data = client.DownloadString(URL);

                DataContractJsonSerializer dcjs = new DataContractJsonSerializer(typeof(List<PhoneVM>));
                var phones =
                    dcjs.ReadObject(new MemoryStream(Encoding.UTF8.GetBytes(data))) as List<PhoneVM>;
                Dispatcher.Invoke(new Action(() => { 
                    this.dgPhones.ItemsSource = phones;
                }));
            }
            catch
            {
                MessageBox.Show("Невірно вказано адрес!");
            }
        }
    }
}
