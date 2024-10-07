using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    //ConcreteDecorator
    public class AddChocolateDecorator : MakeCoffeeWithAdditives
    {
        public AddChocolateDecorator(MakeCoffee makeCoffee) : base(makeCoffee.price + 50, makeCoffee) { }

        public override void Operation()
        {
            makeCoffee.Operation();
            Console.Write("with chocolate ");
        }
    }
}
