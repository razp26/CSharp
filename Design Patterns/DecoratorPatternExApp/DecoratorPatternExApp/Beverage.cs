using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatternExApp
{
    public abstract class Beverage
    {
        protected string description = "Unknown beverage";

        public abstract string GetDescription();

        public abstract double Cost();
    }
}
