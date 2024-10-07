using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.CoffeeType
{
    class Cappuccino : Coffee
    {
        public override void MakeCoffee()
        {
            Console.WriteLine("Cappuccino coffee preparation");
        }
    }
}
