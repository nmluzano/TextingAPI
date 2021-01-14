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
using RestSharp;

namespace Texting_API
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void charCount()
        {
            int j = txtMessage.Text.Length;
            string charcount = j.ToString() + " " + "/" + " " + "100";
            CharCount.Text = charcount;
        }


        private void txtMessage_TextChanged(object sender, TextChangedEventArgs e)
        {
            charCount();
            txtMessage.MaxLength = 100;
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            string PhoneNumber = txtPhoneNumber.Text;
            string Message = txtMessage.Text;

            var client = new RestSharp.RestClient("https://www.itexmo.com/php_api/api.php");

            var request = new RestSharp.RestRequest(RestSharp.Method.POST);
            request.AddParameter("1", PhoneNumber);
            request.AddParameter("2", Message);
            request.AddParameter("3", "TR-NICOL459883_BWFQ5");
            request.AddParameter("passwd", "m(z(cgw5ng");

            client.Execute(request);
        }
    }
}
