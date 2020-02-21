using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatternExApp
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "House Blend Coffee";
        }

        public override string GetDescription()
        {
            return description;
        }

        public override double Cost()
        {
            return 0.89;
        }
    }
}
