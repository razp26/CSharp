using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExApp
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            name = "Chicago Style Cheese Pizza";
            dough = "Extra Tich Crust Dough";
            sauce = "Plum Tomato Sauce";

            toppings.Add("Shredded Mozzarella Cheese");
        }

        public new void Cut()
        {
            Console.WriteLine("Cutting The Pizza Into Square Slices");
        }
    }
}
