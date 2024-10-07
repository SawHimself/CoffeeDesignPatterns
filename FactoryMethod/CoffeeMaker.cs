using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    // Creator
    abstract class CoffeeMaker
    {
        // фабричный метод
        abstract public Coffee Make();
    }
}
