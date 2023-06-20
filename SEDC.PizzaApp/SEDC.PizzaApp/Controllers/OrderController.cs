using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp;
using SEDC.PizzaApp.Models.ViewModels;
using SEDC.PizzaApp.Models.Mappers;

namespace SEDC.PizzaApp.Controllers
{
    public class OrderController : Controller
    {
        //[Route ("Order/ListOrder")]
        public IActionResult Index()
        {
            // - MANUAL MAPPING

            List<OrderViewModel> orders = StaticDb.Orders.Select(order => order.MapOrder()).ToList();
            return View(orders);

        }

        public IActionResult Details(int id)
        {
            if(id == null)
            {
                return RedirectToAction("Error", "Pizza");
            }
            Order order = StaticDb.Orders.FirstOrDefault(o => o.Id == id);
            
            if(order == null)
            {
                return RedirectToAction("Error", "Pizza");
            }

            OrderViewModel orderViewModel = order.MapOrder();

            return View(orderViewModel);
        }
        public IActionResult JsonData()
        {
            List<Order> orders = StaticDb.Orders;
            return new JsonResult(orders);  
        }
    }
}
