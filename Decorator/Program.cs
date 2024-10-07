using Decorator;

MakeCoffee coffee = new MakeMochaccino(200);
coffee = new AddChocolateDecorator(coffee);
coffee = new AddSugarDecorator(coffee);
coffee = new AddWhippedCreamDecorator(coffee);
coffee.Operation();

Console.WriteLine("Price - {0}", coffee.price);