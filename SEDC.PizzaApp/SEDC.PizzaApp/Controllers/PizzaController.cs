using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.Mappers;
using SEDC.PizzaApp.Models.ViewModels;

namespace SEDC.PizzaApp.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult GetPizzas()
        {
            List<PizzaViewModel> pizzas = StaticDb.Pizzas.Select (x => x.MapPizza()).ToList();
            return View(pizzas);
        }
        public IActionResult Details(int? id)
        {
            if(id == null)
            {
                return RedirectToAction("Error");
            }

            PizzaViewModel pizzaView = StaticDb.Pizzas.FirstOrDefault(x => x.Id == id).MapPizza();

            if(pizzaView == null)
            {
                return RedirectToAction("Error");
            }
            return View(pizzaView);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
