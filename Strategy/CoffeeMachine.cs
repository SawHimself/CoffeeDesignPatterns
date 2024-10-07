using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    // Context
    public class CoffeeMachine
    {
        // IStrategy
        public ICoffeeMaker coffeeMaker;

        public CoffeeMachine(ICoffeeMaker coffeeMaker)
        {
            this.coffeeMaker = coffeeMaker;
        }

        public void ExecuteAlgorithm()
        {
            coffeeMaker.AlgorithmMakeCoffee();
        }
    }
}
