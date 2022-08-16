//Create new magherita pizza
Pizza pizza = new Margherita();
Console.WriteLine($"{pizza.GetDescription()} Cost: {pizza.GetCost()}");

//Create a new farm house
Pizza pizza2 = new FarmHouse();

//Decorate it with fresh tomato topping
pizza2 = new FreshTomato(pizza2);

//Decorate it with paneer topping
pizza2 = new Panner(pizza2);

Console.WriteLine($"{pizza2.GetDescription()} Cost: {pizza2.GetCost()}");

Pizza pizza3 = new Barbeque(null); //no specific pizza

Console.WriteLine($"{pizza3.GetDescription()} Cost: {pizza3.GetCost()}");