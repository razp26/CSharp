using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternExApp
{
    public class Squeak : QuackBehavior
    {
        public void DoQuack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
