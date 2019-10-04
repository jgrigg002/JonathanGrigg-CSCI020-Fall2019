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
    //promt user to type in directions pressing enter for everystep till they type Stop
    Console.WriteLine("please type in your directions. press enter after everystep. \n type stop to repeat directions in reverse.");
    //use while loop set to read the previous entry to test for stop
    while (directions[i-1] != "stop" && directions[i-1] != "Stop"){
      directions[i] = Console.ReadLine();
      i++;
    }
    for (int j = 1; j == i; j++ ){
      if (directions[j].Contains("left") || directions[j].Contains("Left")){
        returnDirections[j] = directions[j].Replace("left","right");
        returnDirections[j] = directions[j].Replace("Left","Right");
      }
      else if (directions[j].Contains("right") || directions[j].Contains("Right")){
        returnDirections[j] = directions[j].Replace("right","left");
        returnDirections[j] = directions[j].Replace("Right","Left");
      }
      else {
        returnDirections[j] = directions[j]; 
      }
    }
    //use while loop to read backwards till i count is 0 minus the last entry
    directions[i] = null;
    returnDirections[i] = null;
    i--;
    while (i != 1){
      Console.WriteLine(directions[i-1]);
      i--;
    }
  }
}
