//Jonathan Grigg
//10.08.19
//lab2.7
//venus location tester

using System;
class MeteorTest {
  public static void Main(){
    //create string array to read data into
    string inputString;
    string[] sortingString;
    double[] sortingDouble = new double[3];
    //open read and write fnctions
    StreamReader reader = new StreamReader("venus.csv");
    StreamWriter write;
    writer = new StreamWriter("venusPost.csv");
    inputString = reader.ReadLine();
    while (reader.EndOfStream == false)
    {
      inputString = reader.ReadLine();
      //create loop to read in a line starting at 2nd line. Using split.
      sortingString = inputString.split(",");
      sortingDouble[0] = double.Parse.sortingString[3];
      sortingDouble[1] = double.Parse.sortingString[4];
      sortingDouble[2] = double.Parse.sortingString[5];
      //inset a loop to read the locations and then parse them into a double array.
      if (sortingDouble[0] >= -40 && sortingDouble[0] <= 50 && sortingDouble[1] >= 40 && sortingDouble[1] >= 135 && sortingDouble[2] >=60){
        writer.WriteLine(sortingString);
      }
      //after the read in test the double's values and then write the string array if true.
      //close the read and write fnctions
    }
    reader.Close();
    writer.Close();
  }
}
