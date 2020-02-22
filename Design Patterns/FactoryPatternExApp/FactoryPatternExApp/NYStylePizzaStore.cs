using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExApp
{
    public class NYStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            if (type.Equals("cheese"))
            {
                return new NYStyleCheesePizza();
            }

            return null;
        }
    }
}
