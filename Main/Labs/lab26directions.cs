//Jonathan Grigg
//10.3.19
//lab2.6
//reverse directions given


using System;
class directionReverse {
  public static void Main(){
    //create string Array
    string[] directions = new string [99];
    string[] returnDirections = new string [99];
    //create integer counter for reading location.
    int i = 1;
    int j = 1;
    //promt user to type in directions pressing enter for everystep till they type Stop
    Console.WriteLine("Please type in your directions.\nPress enter after everystep.\nType stop to have directions read back in reverse.");
    //use while loop set to read the previous entry to test for stop
    while (directions[i-1] != "stop"){
      directions[i] = Console.ReadLine();
      directions[i] = directions[i].ToLower();
      i++;
    }
    //use for loop to iterate through each line and then use if statements to test for cases.
    for (j = 1; j < i; j++ ){
      Console.WriteLine("Loop triggered");
      if (directions[j].Contains("left")){
        //next use .Replace to change left to right and visa versa.
        returnDirections[j] = directions[j].Replace("left","right");
        //Console.WriteLine("Line:"+j+"\nCase1:\n" + returnDirections[j]);

      }
      else if (directions[j].Contains("right")){
        returnDirections[j] = directions[j].Replace("right","left");
        //Console.WriteLine("Line:"+j+"\nCase2:\n" + returnDirections[j]);
      }
      else {
        returnDirections[j] = directions[j];
        //Console.WriteLine("Line:"+j+"\nCase3:\n" + returnDirections[j]);

      }
    }
    //use while loop to read backwards till i count is 0 minus the last entry
    i--;
    while (i != 1){
      Console.WriteLine(returnDirections[i-1]);
      i--;
    }
  }
}
