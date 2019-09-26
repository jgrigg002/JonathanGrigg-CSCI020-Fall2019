//Jonathan Grigg
//9.10.19
//Pizza count and cost calculator
using System;
class MainClass {
  static void Main () {
  // Variable creation
    int pizzaCount = 0, portionCount = 0 , modCount = 0;
    double pizzaCost = 0 ;
    double portionCost = 0;
    string inputText = "";

  // Questions time
  //   Explain portion sizes is one slice
  Console.WriteLine("Standard portion size is one piece of pizza. This is typically enough for one non-american. There are eight pieces, or portions, per pizza. How many portions will you be needing?");
  //   Ask how many portions and store in portionCount
    inputText = Console.ReadLine();
    portionCount = int.Parse(inputText);
  //  Console.WriteLine(portionCount);
  // Calculations pizza count
  //   Divide portionCount by 8 store answer in pizzaCount
    pizzaCount = portionCount / 8 ;
  //   Mod portionCount by 8 store in modCount.
    modCount = portionCount % 8 ;
  //   If modCount is < 0 pizzaCount++
    if (modCount > 0)
    {
      pizzaCount++;
    }

  // Calculations cost count
  //   Multiply and cast pizzaCount by 1.2 and .0725 and 7.99 store in pizzaCost
    pizzaCost = (double)pizzaCount * 1.2 * 1.0725 *7.99;
  //   Divide pizzaCost by portion and round up to 100s space
    pizzaCost = Math.Round(pizzaCost * 100) / 100;
    portionCost = Math.Round( (pizzaCost / portionCount) * 100 ) / 100;
  // Give the bill
    Console.WriteLine("The total cost is $" + pizzaCost + ". The cost per portion, or person is $" + portionCost + ". " + pizzaCount + " total pizzas are being purchased. Any additional change due to rounding is given to the pizza maker. Don't be a dick, support your food workers.") ;
  //   Print out the number of pizzas being bought
  //   Print out the total cast
  //   Print out the post per portion.


  }
}
