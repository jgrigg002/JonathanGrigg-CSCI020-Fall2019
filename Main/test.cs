using System;
class testShit{
  public static void Main(){
int i=0, j=0;
  // while (i <5){
  //   while (j < 3){
  //     Console.Write("*");
  //     j++;
  //   }
  //   Console.WriteLine(" ");
  //   j=0;
  //   i++;
  // }
  for (int count = 1; count < 5 ; count++){
    i=1;
    while (i <= count){
      Console.Write(count);
      i++;
    }
    Console.WriteLine(" ");
    i=1;
  }
}
}
