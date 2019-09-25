//Jonathan Grigg
//Lab2.3 ASCII art
//09.24.19
using System;

class loopASCIIArt{
  public static void Main (){
    // use a while loop to create ASCII art
    // Make a T
    int i = 0, j = 0, k = 0;
    // use while loop x12 for printing top row, nest and repreat once.
    while (i < 2){
      j=0;
      while (j<12){
        Console.Write("T");
        j++;
      }
      Console.WriteLine();
      i++;
    }
    // use loop to create six 0 then two T then six 0. repeat 8 times.
    i = 0;
    while (i < 8){
      Console.WriteLine("00000TT00000");
      i++;
      }
    }
    // use loop to create twelve 0 then repeat 2.

}
