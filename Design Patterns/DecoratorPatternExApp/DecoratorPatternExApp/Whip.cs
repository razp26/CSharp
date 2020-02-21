using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatternExApp
{
    public class Whip : CondimentDecorator
    {
        protected Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Whip";
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.50;
        }
    }
}
