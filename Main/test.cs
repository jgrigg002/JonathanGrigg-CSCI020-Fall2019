using System;
class testShit{
  public static void Main(){
    int i =1;
    i = int.Parse(Console.ReadLine());
    int [] count = new int [i];

    for (int j = 0; j<i; j++)
    {
      count[j]=2;
      Console.WriteLine("x");
      Console.WriteLine(count[j]);
    }
  }
}
