using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace StoreApp.Component
{
    public class CategoriesMenuViewComponent : ViewComponent
    {
        private readonly IServiceManager _manager;

        public CategoriesMenuViewComponent(IServiceManager manager)
        {
            _manager = manager;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _manager.CategoryService.GetAllCategoeris(false);
            return View(categories);
        }
    }
}
