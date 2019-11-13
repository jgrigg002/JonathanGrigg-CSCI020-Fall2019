//Jonathan Grigg
//lab 4.1
//11.12.2019
//Customer record lab

using System;
using System.IO;
class lab41{
// Create struct for storing customer data.
  public struct customerS{
// String First Name,
    public string fName;
// String Middle Initial,
    public string mName;
// String Last Name,
    public string lName;
// String Street Address
    public string streetAdress;
// String City,
    public string city;
// String State,
    public string state;
// Int Zip Code,
    public int zipCode;
// String Country,
    public string country;
// String Email Address,
    public string email;
// Int Telephone Number,
    public int tellephone;
// String Gender,
    public string gender;
// String Birthday
    public string birthday;
  }
// Create class and then main
  public static void Main(){
    // int for storing line count
    int i = 0;
    int lineCount = 0;
    string fileName;
    string inputBuffer;
    fileName = Console.ReadLine();
    // Load in file and do a count of number of lines and then store the count into the line count int
    StreamReader reader = new StreamReader(fileName);
    //     Loop where count is triggered by end of line and loop ends based on end of file trigger?
    //         Black magic! spooky
    while (reader.EndOfStream == false){
      inputBuffer = reader.ReadLine();
      lineCount++;
    }
    reader.Close();
    reader = new   StreamReader(fileName);
    customerS[] cust = new customerS[lineCount];
    // Use customer struct to create array and set the array size to the line count
    // Create loop for reading in file by line and then read the data into the struct array position tied to the line count
    while (reader.EndOfStream == false){
      inputBuffer = reader.ReadLine();
      // Read in each line using split on a comma into an array.
      string[] sortingString = inputBuffer.Split(",");
      // Then store them into the struct
      cust[i].fName = sortingString[0];
      cust[i].mName = sortingString[1];
      cust[i].lName = sortingString[2];
      cust[i].streetAdress = sortingString[3];
      cust[i].city = sortingString[4];
      cust[i].state = sortingString[5];
      cust[i].zipCode = int.Parse(sortingString[6]);
      cust[i].country = sortingString[7];
      cust[i].email = sortingString[8];
      cust[i].tellephone = int.Parse(sortingString[9]);
      cust[i].gender = sortingString[10];
      cust[i].birthday = sortingString[11];
      i++;
    }
    i=0;
    reader.Close();
    // Create loop to output everything.
    while (i <= lineCount){
      Console.WriteLine("Customer "+ i);
      Console.Write(cust[i].fName+" ");
      Console.Write(cust[i].mName+" ");
      Console.WriteLine(cust[i].lName);
      Console.WriteLine(cust[i].streetAdress);
      Console.WriteLine(cust[i].city);
      Console.WriteLine(cust[i].state);
      Console.WriteLine(cust[i].zipCode);
      Console.WriteLine(cust[i].country);
      Console.WriteLine(cust[i].email);
      Console.WriteLine(cust[i].tellephone);
      Console.WriteLine(cust[i].gender);
      Console.WriteLine(cust[i].birthday);
    }
  }
}
