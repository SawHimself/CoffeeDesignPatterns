using FactoryMethod;

CoffeeMaker coffeeMaker = new RafMaker();
Coffee coffee = coffeeMaker.Make();
coffee.MakeCoffee();

coffeeMaker = new CappuccinoMaker();
coffee = coffeeMaker.Make();
coffee.MakeCoffee();

coffeeMaker = new AmericanoMaker();
coffee = coffeeMaker.Make();
coffee.MakeCoffee();

coffeeMaker = new EspressoMaker();
coffee = coffeeMaker.Make();
coffee.MakeCoffee();

