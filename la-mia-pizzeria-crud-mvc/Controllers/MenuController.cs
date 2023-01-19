using la_mia_pizzeria_crud_mvc.Database;
using la_mia_pizzeria_crud_mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.SqlServer.Server;
using System.Linq;

namespace la_mia_pizzeria_crud_mvc.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            using (PizzaContext db = new PizzaContext())
            {
                List<Pizza> pizze = db.Pizzes.ToList<Pizza>();
                return View("Index", pizze);
            }
        }



   [HttpGet]
   public IActionResult AddPizza()
   { return View(); }

   [HttpPost]
   [ValidateAntiForgeryToken]
   public IActionResult AddPizza(Pizza FormData)
   {
       if (!ModelState.IsValid)
       {
           return View("AddPizza", FormData);
       }

       using (PizzaContext db = new PizzaContext())
       {
           db.Pizzes.Add(FormData);
           db.SaveChanges();
       }

       return RedirectToAction("AddPizza", FormData);
   }

}
}
