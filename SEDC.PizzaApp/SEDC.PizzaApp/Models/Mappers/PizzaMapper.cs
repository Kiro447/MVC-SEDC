using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.ViewModels;

namespace SEDC.PizzaApp.Models.Mappers;

public static class PizzaMapper
{
    public static PizzaViewModel MapPizza(this Pizza pizza)
    {
        return new PizzaViewModel()
        {
            PizzaSize = pizza.PizzaSize,
            IsOnPromotion = pizza.IsOnPromotion,
            Name = pizza.Name,
            Price = pizza.HasExtras ? pizza.Price + 10 : pizza.Price,
            HasExtras = pizza.HasExtras

        };

    }
}
