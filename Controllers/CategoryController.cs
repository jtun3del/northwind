using Microsoft.AspNetCore.Mvc;

namespace Northwind.Controllers
{
    public class CategoryController(DataContext db) : Controller
    {
        // this controller depends on the DataContext


        private readonly DataContext _dataContext = db;
        public IActionResult Category() => View(_dataContext.Categories);
    }
}