using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    //ConcreteDecorator
    public class AddWhippedCreamDecorator : MakeCoffeeWithAdditives
    {
        public AddWhippedCreamDecorator(MakeCoffee makeCoffee) : base(makeCoffee.price + 75, makeCoffee) { }
        public override void Operation()
        {
            makeCoffee.Operation();
            Console.Write("with whipped cream");
        }
    }
}
