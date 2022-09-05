using Microsoft.AspNetCore.Mvc;
using prjAspNet6.Data;
using prjAspNet6.Models;

namespace prjAspNet6.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }


        public IActionResult Index()
        {
            IEnumerable<Category> ohjCategoryList = _db.categories;
            return View(ohjCategoryList);
        }
    }
}
