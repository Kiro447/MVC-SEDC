using SEDC.PizzaApp.Models.Domain;
using SEDC.PizzaApp.Models.Enums;

namespace SEDC.PizzaApp;

public static class StaticDb
{
    public static List<Pizza> Pizzas = new List<Pizza>
    {
        new Pizza
        {
        Id = 1,
        Name="Capri",
        Price = 300,
        IsOnPromotion = true,
        HasExtras = true,
        PizzaSize = PizzaSize.Family

        },
        new Pizza
        { 
        Id = 2,
        Name="frommagi",
        Price = 300,
        IsOnPromotion = false,
        HasExtras= false,
        PizzaSize = PizzaSize.Normal
        },
    };
    public static List<User> Users = new List<User> {

        new User
        {
            Id = 1,
            FirstName = "Bob",
            LastName = "Markovski" ,
            PhoneNumber = "1234",
            Address = "Franjo Kluz 17/1"
        },
        new User
        { 
          Id = 2,
          FirstName = "Stevo", 
          LastName = "Karaevski" , 
          PhoneNumber = "23424",
          Address =  "Pandil Siskov"
        }
    };
    public static List<Order> Orders = new List<Order>
    {
        new Order
        {
            Id = 1,
            PizzaId = 1,
            UserId = 2,
            Pizza = Pizzas[0],
            User = Users.First(user => user.Id == 2),
            PaymentMethod = PaymentMethod.Cash
        },
        new Order
        {
            Id = 2,
            PizzaId = 1,
            UserId = 1,
            Pizza = Pizzas[0],
            User = Users.First(user => user.Id == 1),
            PaymentMethod = PaymentMethod.Card
        }

    };

}
