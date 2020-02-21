using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatternExApp
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espresso";
        }

        public override string GetDescription()
        {
            return description;
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
}
