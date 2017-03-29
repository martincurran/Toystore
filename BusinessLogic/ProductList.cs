using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//this is the main business logic 
namespace BusinessLogic
{
    public class ProductList
    {

        public List<Product> GetProducts()
        {
            var ourDatabase = new ToystoreEntities();
            var products = from product in ourDatabase.Products
                        select product;
            var allProducts = products.ToList();
            return allProducts;
        }

        public void UpdateProducts(List<Product> updatedProducts)
        {
            var ourDatabase = new ToystoreEntities();
            foreach (var updatedProduct in updatedProducts)
            {
                var dbProduct = from product in ourDatabase.Products
                    where product.Id == updatedProduct.Id
                    select product;

                var update = dbProduct.FirstOrDefault();
                update.ProductName = updatedProduct.ProductName;
                update.Description = updatedProduct.Description;
                update.Price = updatedProduct.Price;
                update.mageUrl = updatedProduct.mageUrl;
                
            }
            ourDatabase.SaveChanges();

        }
    } 
}
