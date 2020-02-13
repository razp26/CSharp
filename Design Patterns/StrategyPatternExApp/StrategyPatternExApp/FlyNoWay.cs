using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternExApp
{
    public class FlyNoWay : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}
