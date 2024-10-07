using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.CoffeeType
{
    class Raf : Coffee
    {
        public override void MakeCoffee()
        {
            Console.WriteLine("Raf coffee preparation");
        }
    }
}
