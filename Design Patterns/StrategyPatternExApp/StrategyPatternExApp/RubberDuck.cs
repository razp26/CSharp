using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternExApp
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new MuteQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a rubber Duck");
        }
    }
}
