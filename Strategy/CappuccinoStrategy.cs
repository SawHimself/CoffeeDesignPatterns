using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    //ConcreteStrategy
    public class CappuccinoStrategy : ICoffeeMaker
    {
        public void AlgorithmMakeCoffee()
        {
            Console.WriteLine("Make Espresso...");
            Console.WriteLine("Heat the Milk...");
            Console.WriteLine("Froth the Milk...");
            Console.WriteLine("Combine Espresso and Milk...");
            Console.WriteLine("Cappuccino is ready to serve");
            Console.WriteLine("############################# \n");
        }
    }
}
