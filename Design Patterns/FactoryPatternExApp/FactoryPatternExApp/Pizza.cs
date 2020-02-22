using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExApp
{
    public abstract class Pizza
    {
        protected string name;
        protected string dough;
        protected string sauce;
        protected List<string> toppings = new List<string>();

        public void Prepare()
        {
            Console.WriteLine("Preparing " + name);
            Console.WriteLine("Tossing dough " + dough);
            Console.WriteLine("Adding sauce " + sauce);
            Console.WriteLine("Adding toppings: ");
            foreach(var topping in toppings)
            {
                Console.WriteLine(topping + " added");
            }
        }

        public void Bake()
        {
            Console.WriteLine("Bake for 30 minutes at 350");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting The Pizza Into Diagonal Slices");
        }

        public void Box()
        {
            Console.WriteLine("Place Pizza in Official Pizza Store Box");
        }

        public string GetName()
        {
            return name;
        }
    }
}
