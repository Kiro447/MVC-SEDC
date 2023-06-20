using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.ViewModels;

namespace SEDC.PizzaApp.Models.Mappers
{
    public static class OrderMapper
    {
        public static OrderViewModel ToOrderViewModel( Order order)
        {
            return new OrderViewModel()
            {
                PizzaName = order.Pizza.Name,
                PaymentMethod = order.PaymentMethod,
                Price = order.Pizza.Price + 50,
                UserFullName = order.User.FirstName + " " + order.User.LastName,
            };

        }

        public static OrderViewModel MapOrder(this Order order)
        {
            return new OrderViewModel()
            {
                PizzaName = order.Pizza.Name,
                PaymentMethod = order.PaymentMethod,
                Price = order.Pizza.Price,
                UserFullName = order.User.FirstName + " " + order.User.LastName,
                Address = order.User.Address
            };

        }
    }
}
