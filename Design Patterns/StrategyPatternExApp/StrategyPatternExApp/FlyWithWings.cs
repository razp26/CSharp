using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternExApp
{
    public class FlyWithWings : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying!");
        }
    }
}
