using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatternExApp
{
    public class Mocha : CondimentDecorator
    {
        protected Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Mocha";
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.20;
        }
    }
}
