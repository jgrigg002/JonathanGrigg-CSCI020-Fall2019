//JonathanGrigg
//9.19.19
//updated animal
using System;
class MainClass{
  public static void Main (){
    //use switches to set off chain questions
    //use string for storing answers
    string promptAnswer = null;
    string secondLevel = null;
    //giest is to promt the user for what animal the are and then input their answer into the string
    Console.WriteLine("Welcome to the animal guessing game \nWhere I ask you a question, you answer and then I guess what animal you are in a very poor manner.\nPlease type your answer exactly as it's written");
    Console.WriteLine("\nAre you a\n\n1.bird \n2.fish\n3.mammal.");
    promptAnswer = Console.ReadLine();
    //Next we use switch statements to direct the code towards the next level of questions
    //Questons are if you're a bird, fish, or mammal. Using multiple sets of cases to cover different words
    switch (promptAnswer){
      case "1":
      case "bird":
      case "Bird":
        Console.WriteLine("\nAre you \n1.flightless\n2.flying");
        secondLevel = Console.ReadLine();
      //Next switch is for the second lever asking what type of bird the are.
      switch (secondLevel){
        case "1":
        case "Flightless":
        case "flightless":
          Console.WriteLine("You might be a penguin");
        break;
        case "2":
        case "flying":
        case "Flying":
          Console.WriteLine("You might be an Albatross!!");
          break;
      }
      break;
      //fish questions
      case "2":
      case "fish":
      case "Fish":
        Console.WriteLine("Do you live in\n1.ocean\n2.rivers");
        secondLevel = Console.ReadLine();
      //Second level for fish more of the same print answer after case is succesful
      switch (secondLevel){
        case "1":
        case "ocean":
        //case "flightless":
        case "Ocean":
          Console.WriteLine("You might be a tuna!");
          break;
        case "2":
        case "rivers":
        case "Rivers":
          Console.WriteLine("You might be a Trout");
          break;
      }
        break;
      //mammal questions
      case "3":
      case "Mammal":
      case "mammal":
        Console.WriteLine("Legs \n1.two\n2.four");
        secondLevel = Console.ReadLine();
      //second level based on leg count
      switch (secondLevel){
        case "1":
        case "two":
        case "Two":
          Console.WriteLine("you are a Simian!");
          break;
        case "2":
        case "Four":
        case "four":
          Console.WriteLine("You're a unicorn <3!!");
          break;
      }
      break;
    }
  Console.WriteLine("\nDone!\nMaybe you're questions on life are answered.");

  }
}
