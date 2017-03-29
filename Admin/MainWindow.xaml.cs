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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BusinessLogic;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using RestSharp;
using WebStore.Models;


namespace Admin
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

     
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            GoToProductsIfLoggedIn();
        }

        private void GoToProductsIfLoggedIn()
        {
            if (ValidLogin(EdtUserName.Text, EdtPassword.Password))
            {
                ProductWindow productWindow = new ProductWindow();
                productWindow.User = EdtUserName.Text;
                productWindow.ShowDialog();
            }

        }

        private bool ValidLogin(string userEmail, string userPassword)
        {
            bool result = false;
            IRestResponse response;
            var model = new RemoteLoginModel() {Email = userEmail, Password = userPassword};

            var client = new RestClient("http://martystoystore.azurewebsites.net/");
            //var client = new RestClient("http://localhost:1676/");
            var request = new RestRequest("Account/LoginRemote", Method.POST);
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(model);
            response = client.Execute(request);
            var res = response.Content.ToString();
            lblStatus.Content = res;
            if (res == "Valid")
            {
                result = true;
            }
            return result;
        }
    }
}
