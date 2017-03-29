using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;

namespace Admin
{
    class MainWindowViewModel
    {
        private List<Product> _allProducts;


        public List<Product> AllProducts
        {
            get { return _allProducts; }
            set { _allProducts = value; }
        }

        public Product SelectedProduct
        {
            get
            {
                return selectedProduct;
            }

            set
            {
                selectedProduct = value;
            }
        }

        private Product selectedProduct;
    }
}
