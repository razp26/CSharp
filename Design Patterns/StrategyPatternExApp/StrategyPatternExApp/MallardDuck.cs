﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternExApp
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard Duck");
        }
    }
}
