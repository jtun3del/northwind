using Microsoft.AspNetCore.Mvc;

namespace Northwind.Controllers
{
    public class ProductController(DataContext db) : Controller
    {
        // this controller depends on the DataContext


        private readonly DataContext _dataContext = db;
        public IActionResult dex(int id) => View(new PostViewModel
        {
            Categories = _dataContext.Categories.FirstOrDefault(b => b.CategoryId == id),
            Products = _dataContext.Products.Where(p => p.CategoryId == id)
        });


        public IActionResult Category() => View(_dataContext.Categories.OrderBy(b => b.CategoryName));


    }
}
