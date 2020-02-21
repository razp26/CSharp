using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatternExApp
{
    public abstract class CondimentDecorator : Beverage
    {
        public abstract override string GetDescription();
    }
}
