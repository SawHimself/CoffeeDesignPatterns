using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    //ConcreteDecorator
    public class AddSugarDecorator : MakeCoffeeWithAdditives
    {
        public AddSugarDecorator(MakeCoffee makeCoffee) : base(makeCoffee.price + 20, makeCoffee) { }
        public override void Operation()
        {
            makeCoffee.Operation();
            Console.Write("with sugar ");
        }
    }
}
