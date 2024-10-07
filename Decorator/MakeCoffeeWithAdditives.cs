using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    // Decorator
    public class MakeCoffeeWithAdditives : MakeCoffee
    {
        protected MakeCoffee makeCoffee;

        public MakeCoffeeWithAdditives(int price, MakeCoffee makeCoffee) : base(price)
        {
            this.makeCoffee = makeCoffee;
        }

        public override void Operation()
        {
            if(makeCoffee != null) 
            { 
                makeCoffee.Operation();
            }
        }
    }
}
