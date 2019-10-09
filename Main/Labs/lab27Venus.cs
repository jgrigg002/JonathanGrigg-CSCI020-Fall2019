//Jonathan Grigg
//10.08.19
//lab2.7
//venus location tester

using System;
using System.IO;
class MeteorTest {
  public static void Main(){
    //create string array to read data into
    string inputString;
    double[] sortingDouble = new double[3];
    //open read and write fnctions
    StreamReader reader = new StreamReader("venus.csv");
    StreamWriter writer;
    writer = new StreamWriter("venusPost.csv");
    inputString = reader.ReadLine();
    while (reader.EndOfStream == false)
    {
      inputString = reader.ReadLine();
      //create loop to read in a line starting at 2nd line. Using split.
      string[] sortingString = inputString.Split(",");
      sortingDouble[0] = Double.Parse(sortingString[2]);
      sortingDouble[1] = Double.Parse(sortingString[3]);
      sortingDouble[2] = Double.Parse(sortingString[4]);
      //inset a loop to read the locations and then parse them into a double array.
      //after the read in test the double's values and then write the string array if true.
      if (sortingDouble[0] >= -40 && sortingDouble[0] <= 50 && sortingDouble[1] >= 40 && sortingDouble[1] >= 135 && sortingDouble[2] >=60){
        Console.WriteLine(sortingString);
        writer.WriteLine(sortingString);
      }

      //close the read and write fnctions
    }
    reader.Close();
    writer.Close();
  }
}
