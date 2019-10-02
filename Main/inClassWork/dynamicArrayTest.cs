using System;
class dynamicArrayTest{
  public static void Main(){
    int i =1;
    Console.Write("How many array locations do you need? ");
    i = int.Parse(Console.ReadLine());
    int [] count = new int [i];
    Console.WriteLine("printing test for dynamic assigned array.");
    for (int j = 0; j<i; j++)
    {
      count[j]=j;
      Console.Write("Array Location: ");
      Console.WriteLine(count[j]);
    }
  }
}
