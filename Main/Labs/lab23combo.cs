//Jonathan Grigg
//Lab2.3
//Combination while loop
//09.24.19
using System;
class combinationGuess{
  public static void Main (){
  //Create variables. total, input, counter, output
  double total = 0 , input = 0, counter = 0;
  //use loop to enter numbers in and then exit when a -1 is typed in.
  while (input != -1){
      Console.WriteLine("Please type in a quiz score.\nType -1 to print average score");
      input = double.Parse(Console.ReadLine());
      //Console.WriteLine(input);
      total = total + input;
      counter++;
    }
    //now set up counter and total to account for the -1 command.
    counter--;
    total = total - 1;
    //Print the average score, compute in writeline.
    Console.WriteLine ("average score is " + total/counter);
  }
}
