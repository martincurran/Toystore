using System.Collections.Generic;
using System.Web.Mvc;
using BusinessLogic;
using WebStore.Models;


namespace WebStore.Controllers
{
    [Authorize]
    public class ProductListController : Controller
    {
        // GET: ProductList
        public ActionResult Index()
        {
            var allProducts = new ProductList().GetProducts();
            ProductListModel allProductsData = new ProductListModel( allProducts);
            
            return View( allProductsData );
        }
    }
}