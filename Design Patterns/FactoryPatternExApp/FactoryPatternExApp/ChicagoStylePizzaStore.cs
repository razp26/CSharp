using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExApp
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            if (type.Equals("cheese"))
            {
                return new ChicagoStyleCheesePizza();
            }

            return null;
        }
    }
}
