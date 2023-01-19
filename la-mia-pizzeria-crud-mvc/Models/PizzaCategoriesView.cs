using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_crud_mvc.Models
{
    public class PizzaCategoriesView : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
