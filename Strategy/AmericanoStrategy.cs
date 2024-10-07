using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    //ConcreteStrategy
    public class AmericanoStrategy : ICoffeeMaker
    {
        public void AlgorithmMakeCoffee()
        {
            Console.WriteLine("Make Espresso...");
            Console.WriteLine("Heat the Water...");
            Console.WriteLine("Combine Espresso and Water...");
            Console.WriteLine("Americano is ready to serve");
            Console.WriteLine("############################# \n");
        }
    }
}
