using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternExApp
{
    public class Quack : QuackBehavior
    {
        public void DoQuack()
        {
            Console.WriteLine("Quack");
        }
    }
}
