using FactoryMethod.CoffeeType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    //ConcreteCreator
    class AmericanoMaker : CoffeeMaker
    {
        public override Coffee Make()
        {
            return new Americano();
        }
    }
}
