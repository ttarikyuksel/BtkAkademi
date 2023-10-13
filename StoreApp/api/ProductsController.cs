using Microsoft.AspNetCore.Mvc;

namespace StoreApp.api
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
