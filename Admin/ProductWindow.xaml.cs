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
using System.Windows.Shapes;
using BusinessLogic;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;

namespace Admin
{
    /// <summary>
    /// logic for ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        private static ViewModel viewModel = new ViewModel();
        private ProductList businessProducts = new ProductList();
        private string _user;

        public ProductWindow()
        {
            InitializeComponent();
            ViewModel.ProductList = businessProducts.GetProducts();
            DataContext = viewModel;
            dataGrid.DataContext = viewModel;
        }

        public string User
        {
            get { return _user; }
            set
            {
                _user = value;
                if (_user.ToLower() != "admin@toystore.com")
                {
                    DisableControls();
                }
            }
        }

        private void DisableControls()
        {
            btnSave.Visibility = Visibility.Hidden;
            btnUploadBlob.Visibility =Visibility.Hidden;
            btnSelectImge.IsEnabled = false;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(viewModel.SelectedProduct.ProductName);
        }
        private void btnSelectImge_Click(object sender, RoutedEventArgs e)
        {
            SelectNewImage();
        }

        private void SelectNewImage()
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Select a picture";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                viewModel.SelectedProduct.mageUrl = op.FileName;
                fileSource.Content = op.FileName;
                BlobUri.Content = op.SafeFileName;
            }

        }

        private void btnUploadBlob_Click(object sender, RoutedEventArgs e)
        {
            // upload image to Azure - get uri
            string fileName = fileSource.Content.ToString();
            string accountname = "martystoystore";
            string accesskey = "OlDho5qbeYaRzdauKjw1sEmYZT3QQPtNa2s3OZHU2MPKld/s/F9/SEzeopu8YEz6Kv5BPS52bsFU+sX+p88Jjw==";


            try
            {
                StorageCredentials creden = new StorageCredentials(accountname, accesskey);
                CloudStorageAccount acc = new CloudStorageAccount(creden, useHttps: true);
                CloudBlobClient client = acc.CreateCloudBlobClient();
                CloudBlobContainer cont = client.GetContainerReference("toystorecontainer");
                cont.CreateIfNotExists();
                cont.SetPermissions(new BlobContainerPermissions
                {
                    PublicAccess = BlobContainerPublicAccessType.Blob
                });

                string blobRef = BlobUri.Content.ToString();
                CloudBlockBlob cblob = cont.GetBlockBlobReference(blobRef);
                using (Stream file = File.OpenRead(fileName))
                {
                    cblob.UploadFromStream(file);
                }
                viewModel.SelectedProduct.mageUrl = cblob.SnapshotQualifiedUri.AbsoluteUri;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            businessProducts.UpdateProducts( ViewModel.ProductList);
        }
    }
}
