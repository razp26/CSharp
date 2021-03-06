﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPatternExApp
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "Dark Roast Coffee";
        }

        public override string GetDescription()
        {
            return description;
        }

        public override double Cost()
        {
            return 2.25;
        }
    }
}
