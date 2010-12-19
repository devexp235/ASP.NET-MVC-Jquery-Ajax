using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNETMVC_Jquery_Ajax.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new SomeRepo().AllProducts());
        }

    }

    public class SomeRepo : IRepository
    {
        public IEnumerable<Product> AllProducts()
        {
            yield return new Product { Id = 1, Description = "Vegetarian Pizza", Price = 12m };
            yield return new Product { Id = 2, Description = "Tofu Hamburger", Price = 5m };
            yield return new Product { Id = 3, Description = "Vegan Lasagna", Price = 12m };
        }
    }

    public interface IRepository
    {
        IEnumerable<Product> AllProducts();
    }

    public class Product
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }
    }
}
