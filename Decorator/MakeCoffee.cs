using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    // Component
    public abstract class MakeCoffee
    {
        public int price;

        public MakeCoffee(int price)
        {
            this.price = price;
        }
        public abstract void Operation();
    }
}
