//Jonathan Grigg
//10.22.19
//lab 3.2
//unit conversions

using System;
class UnitConversion{
  //for all of these functions I'm going to use the same basic structure.
  /* void double functionName(double input){
  double output = 0;
  output = input * (conversion shit);
  return output;
  }       */
  //inch to centimeter function
  static double inchCentimeter(double inp){
      double output;
      output = 2.54*inp;
      return output;
    }
  //centimeter to inch function
  static double centimeterInch(double inp){
      double output;
      output = inp/2.54;
      return output;
    }
  //inch to feet function
  static double inchFeet(double inp){
      double output;
      output = inp/12;
      return output;
    }
  //feet to inch function
  static double feetInch(double inp){
      double output;
      output = inp*12;
      return output;
    }
  //liters to gallons function
  static double literGallon(double inp){
      double output;
      output = inp*0.26;
      return output;
    }
  //gallons to liters function
  static double gallonLiter(double inp){
      double output;
      output = inp/0.26;
      return output;
    }
  //ounces to liters function
  static double OunceLiter(double inp){
      double output;
      output = inp/33.814;
      return output;
    }
  //liters to ounces function
  static double literOunce(double inp){
      double output;
      output = inp*33.814;
      return output;
    }
  public static void Main(){
    int choice = 0;
    double inputValue = 0;
    double outputValue = 0;

    Console.WriteLine("Hey, Listen!!\n\nthis program converts unit types");
    Console.WriteLine("Please type a number and press enter to select your choice.");
    Console.WriteLine("1 for inch to centimeter\n2 for centimeter to inch.\n3 for inch to feet.\n4 for feet to inch.");
    Console.WriteLine("5 for liter to gallon.\n6 for gallon to liter/\n7 for ounce to liter.\n8 for liter to ounce");
    //format will be to ask the user which choice they want.
    choice = int.Parse(Console.ReadLine());
    //they type in a number selecting the choice and then type in the value they want converted
    switch (choice){
      //choices
      //1 inch to centimete
      //3 inch to feet
      //5 liter to gallon
      //7 ounce to liter
      case 1:
        Console.Write("type in the value you want to convert. ");
        inputValue = double.Parse(Console.ReadLine());
        outputValue = inchCentimeter(inputValue);
        Console.WriteLine("Your value is " + outputValue + "centimeters.");
        break;
      case 2:
        Console.Write("type in the value you want to convert. ");
        inputValue = double.Parse(Console.ReadLine());
        outputValue = centimeterInch(inputValue);
        Console.WriteLine("Your value is " + outputValue + "inches.");
        break;
      case 3:
        Console.Write("type in the value you want to convert. ");
        inputValue = double.Parse(Console.ReadLine());
        outputValue = inchFeet(inputValue);
        Console.WriteLine("Your value is " + outputValue + "feet.");
        break;
      case 4:
        Console.Write("type in the value you want to convert. ");
        inputValue = double.Parse(Console.ReadLine());
        outputValue = feetInch(inputValue);
        Console.WriteLine("Your value is " + outputValue + "inches.");
        break;
      case 5:
        Console.Write("type in the value you want to convert. ");
        inputValue = double.Parse(Console.ReadLine());
        outputValue = literGallon(inputValue);
        Console.WriteLine("Your value is " + outputValue + "gallons.");
        break;
      case 6:
        Console.Write("type in the value you want to convert. ");
        inputValue = double.Parse(Console.ReadLine());
        outputValue = gallonLiter(inputValue);
        Console.WriteLine("Your value is " + outputValue + "liters.");
        break;
      case 7:
        Console.Write("type in the value you want to convert. ");
        inputValue = double.Parse(Console.ReadLine());
        outputValue = literOunce(inputValue);
        Console.WriteLine("Your value is " + outputValue + "ounces.");
        break;
      case 8:
        Console.Write("type in the value you want to convert. ");
        inputValue = double.Parse(Console.ReadLine());
        outputValue = OunceLiter(inputValue);
        Console.WriteLine("Your value is " + outputValue + "liters.");
        break;
      default:
        break;
    }
    //it inputs the function and then returns it to the output variable. Values will be rounded to three decimals.
  }
}
