using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternExApp
{
    public class MuteQuack : QuackBehavior
    {
        public void DoQuack()
        {
            Console.WriteLine("<< Silence >>");
        }
    }
}
