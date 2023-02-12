using ASPDOTNETBOLMVC6.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASPDOTNETBOLMVC6.Controllers
{
    public class CategoryController : Controller
    {

        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _categoryService.GetAll();
            return View(data);
        }
    }
}
