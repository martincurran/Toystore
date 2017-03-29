using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessLogic;

namespace WebStore.Models
{
    public class ProductListModel
    {
        private List<Product> allProducts;

        public ProductListModel(List<Product> allProducts)
        {
            this.allProducts = allProducts;
        }

        public List<Product> AllProducts => allProducts;
    }
}