using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternExApp
{
    public class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Redhead Duck");
        }
    }
}
