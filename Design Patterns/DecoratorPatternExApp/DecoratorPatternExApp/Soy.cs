using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatternExApp
{
    public class Soy : CondimentDecorator
    {
        protected Beverage beverage;

        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Soy";
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.35;
        }
    }
}
