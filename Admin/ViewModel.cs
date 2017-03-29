using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;

namespace Admin
{
    class ViewModel
    {
        private static List<Product> productList;

        public static List<Product> ProductList
        {
            get
            {
                return productList ??
                       (productList = new List<Product>()
                       {
                           new Product {ProductName = "Product1", Description = "Desc1", Price = (decimal) 1.23, mageUrl = "images/Toy1.png"},
                           new Product {ProductName = "Prod2", Description = "Desc2", Price = (decimal) 2.34, mageUrl = "images/toy2.png"},
                           new Product {ProductName = "Prod3", Description = "Desc3", Price = (decimal) 3.45, mageUrl = "images/toy3.png"}
                       });
            }
            set
            {
                if (value != null) productList = value;
            }
        }


        public Product SelectedProduct { get; set; }
    }
}
