using System;

namespace FactoryPatternExApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyPizzaStore = new NYStylePizzaStore();
            Pizza pizza = nyPizzaStore.OrderPizza("cheese");
            Console.WriteLine("Client1 ordered a " + pizza.GetName());

            PizzaStore chicagoPizzaStore = new ChicagoStylePizzaStore();
            pizza = chicagoPizzaStore.OrderPizza("cheese");
            Console.WriteLine("Client2 ordered a " + pizza.GetName());

            Console.ReadKey();
        }
    }
}
