// JonathanGrigg
// 9.13.19
// Animal question game or using loops ifs and switches not witches to guess what fish.
using System;

class MainClass
{
  public static void Main ()
  {
    // Initialize variables
    // use string for storing answers
    string question = "no";
    // If statements
    // ask questions and store the asnwers to trigger if statements.
    Console.WriteLine("Are you a bird? \nYes or no?");
    question = Console.ReadLine();
    // Bird yes or no- fish yes or no - bug yes or no - mammal yes or no.
    if (question == "yes"|| question == "Yes" || question == "y" || question == 'Y')
    {
      // Inside bird- are you flightless yes or no
      Console.WriteLine("Are you flightless \nYes or no?");
      if (question == "yes"|| question == "Yes" || question == "y" || question == 'Y')
      {
        Console.WriteLine("You might be a penguin.");
      }
      else
      {
        Console.WriteLine("You might be a sparrow.");
      }
    }
    // are you a fish
    Console.WriteLine("Are you a fish");
    question = Console.ReadLine();
    if (question == "yes"|| question == "Yes" || question == "y" || question == 'Y')
    {
      Console.WriteLine("You might be a salmon.");
    }
    //
    Console.WriteLine("Are you a bug");
    question = Console.ReadLine();
    // are you a bug question
    if (question == "yes"|| question == "Yes" || question == "y" || question == 'Y')
    {
      Console.WriteLine("You might be a lady bug.");
    }
    //
    // Inside mammal- the scope of mammals is to large for this program. congratulations.
    Console.WriteLine("Are you a mammal?");
    question = Console.ReadLine();
    if (question == "yes"|| question == "Yes" || question == "y" || question == 'Y')
    {
      Console.WriteLine("Good for you.");
    }
    else Console.WriteLine("Youre not an animal then");
  }
}
