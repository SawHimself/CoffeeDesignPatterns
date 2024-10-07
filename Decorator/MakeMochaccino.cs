using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    //ConcreteComponent
    public class MakeMochaccino : MakeCoffee
    {
        public MakeMochaccino(int money) : base(money){ }
        public override void Operation()
        {
            Console.Write("Make mochaccino ");
        }
    }
}
