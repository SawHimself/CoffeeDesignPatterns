using Strategy;
/*    
Context context = new Context(new ConcreteStrategy1());
context.ExecuteStrategy();

context.strategy = new ConcreteStrategy2();
context.ExecuteStrategy();*/

CoffeeMachine coffeeMachine = new CoffeeMachine(new AmericanoStrategy());
coffeeMachine.ExecuteAlgorithm();

coffeeMachine.coffeeMaker = new CappuccinoStrategy();
coffeeMachine.ExecuteAlgorithm();