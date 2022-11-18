// See https://aka.ms/new-console-template for more information

using BigMammaUML3;

IMenuCatalogue catalogue;
catalogue = new MenuCatalogue();

Pizza p1 = new Pizza(1, "Margherita", "tomato & cheese", 77, MenuType.Pizza, true, true, false);
Pizza p2 = new Pizza(2, "Vesuvio", "tomato, cheese and ham", 83, MenuType.Pizza, false, true, false);
Pizza p3 = new Pizza(3, "Capricciosa", "tomato, cheese, ham & mushroom", 88, MenuType.Pizza, false, true, false);
Pizza p4 = new Pizza(4, "Calzone", "tomato, cheese, ham & mushroom", 88, MenuType.Pizza, false, true, true);
Beverage b1 = new Beverage(10, "Cola", "soft drink", 32, MenuType.Beverage, true, false, false, true);
Beverage b2 = new Beverage(11, "Cola zero", "soft drink", 32, MenuType.Beverage, true, false, false, false);
Beverage b3 = new Beverage(12, "Sprite", "soft drink", 32, MenuType.Beverage, true, false, false, true);
Beverage b4 = new Beverage(13, "Carlsberg", "beer", 39, MenuType.Beverage, true, true, true, false);
Pasta pa1 = new Pasta(20, "Linguine alle cozze", "pasta with mussels", 95, MenuType.Pasta, false, false, false);
Pasta pa2 = new Pasta(21, "Pennette al ragout di vitello", "pennette pasta with veal navarin and grana padano cheese", 105, MenuType.Pasta, false, true, false);
Pasta pa3 = new Pasta(22, "Crudaiola al limone", "pasta with lemon marinated tomatoes, garlic, basil and mozzarella", 90, MenuType.Pasta, true, true, false);
Pasta pa4 = new Pasta(23, "Pappardelle ai funghi di bosco", "pappardelle pasta with a sauce of mixed mushrooms and parmesan cheese", 99, MenuType.Pasta, true, true, false);
Topping t1 = new Topping(30, "Marinara sauce", "a tomato based sauce, spread on pizza", 5, MenuType.Topping, true, true, "sauces");
Topping t2 = new Topping(31, "Mozzarella cheese", "a mild cheese used on most pizzas", 10, MenuType.Topping, false, true, "cheeses");
Topping t3 = new Topping(32, "Mushroom", "a mushroom", 10, MenuType.Topping, true, true, "non meats");
Topping t4 = new Topping(33, "Parmesan cheese", "a sharp cow's milk cheese", 15, MenuType.Topping, false, true, "cheeses");

Console.WriteLine("Test af Add:");
Console.WriteLine($"Før add af item: {catalogue.Count}");
catalogue.Add(p1);
catalogue.Add(p2);
catalogue.Add(p3);
catalogue.Add(p4);
catalogue.Add(b1);
catalogue.Add(b2);
catalogue.Add(b3);
catalogue.Add(b4);
catalogue.Add(pa1);
catalogue.Add(pa2);
catalogue.Add(pa3);
catalogue.Add(pa4);
catalogue.Add(t1);
catalogue.Add(t2);
catalogue.Add(t3);
catalogue.Add(t4);

Console.WriteLine($"Efter add af item: {catalogue.Count}");

Console.WriteLine("\n");
Console.WriteLine("Test af Search");
IMenuItem foundItem = catalogue.Search(1);

if (foundItem != null)
{
    //Udskriv foundBook
    Console.WriteLine($"Item fundet:\n{foundItem.PrintInfo()}");
}
else
{
    //Udskriv bog ikke fundet
    Console.WriteLine("Item ikke fundet");
}

Console.WriteLine("\n");
Console.WriteLine("Test af update:");
Console.WriteLine("Print items før update");
catalogue.PrintAll();
IMenuItem upDatedItem = new Pizza(1, "Margherita", "tomato & cheese", 77, MenuType.Pizza, true, false, false);
catalogue.Update(1, upDatedItem);
Console.WriteLine("\n");
Console.WriteLine("Print items after update");
catalogue.PrintAll();

//Console.WriteLine("\n");
//Console.WriteLine("Test af delete:");
//Console.WriteLine("Antal items før delete:");
//Console.WriteLine(catalogue.Count);
//catalogue.Delete(13);
//Console.WriteLine("Antal items efter delete:");
//Console.WriteLine(catalogue.Count);

Console.WriteLine("\n");
Console.WriteLine("Test af print pizzas");
catalogue.PrintPizzasMenu();

Console.WriteLine("\n");
Console.WriteLine("Test af most expensive:");
IMenuItem mostExpensiveItem = catalogue.MostExpensiveMenuItem();
Console.WriteLine(mostExpensiveItem.PrintInfo());

Console.WriteLine("\n");
Console.WriteLine("Test af print vegan items (pizzas)");
List<IMenuItem> veganPizzas = catalogue.FindAllVegan(MenuType.Pizza);
foreach (IMenuItem veganPizza in veganPizzas)
{
    Console.WriteLine(veganPizza.PrintInfo());
}

Console.WriteLine("\n");
Console.WriteLine("Test af print vegan items (toppings)");
List<IMenuItem> veganToppings = catalogue.FindAllVegan(MenuType.Topping);
foreach (IMenuItem veganTopping in veganToppings)
{
    Console.WriteLine(veganTopping.PrintInfo());
}

Console.WriteLine("\n");
Console.WriteLine("Test af MenuItemNumberExist");
//try
//{
//    catalogue.Add(p2);
//}
//catch (MenuItemNumberExist mineEx)
//{
//    Console.WriteLine("Something went wrong: " + mineEx.Message);
//}
catalogue.Add(p3);
catalogue.Add(b4);