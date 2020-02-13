using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternExApp
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new MuteQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Decoy Duck");
        }
    }
}
