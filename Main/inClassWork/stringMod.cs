using System;
class stringMod{
  public static void Main(){
    string inputFirst, inputLast = {null, null};
    while (inputFirst.Length <=10){
      Console.WriteLine("Please type in first name must be no more then 10 characters");
      Console.ReadLine(inputFirst);
    }
    while (inputLast.Length <= 20){
      Console.WriteLine("Please type in first name must be no more then 20 characters");
      Console.ReadLine(inputLast);
    }
    Console.WriteLine(inputFirst[0]+inputFirst[1]+inputLast + "; " + inputFirst+inputLast + "; " +inputFirst[0]+inputLast + "; ");

  }
}
