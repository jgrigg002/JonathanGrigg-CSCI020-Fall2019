//Jonathan Grigg
//11.14.19
//lab4.2
//Eggs

//I just learned this term egg can refer to a trans gender individual who is not aware they are trans yet.

using System;
class EggCarton{
  private int brownEggs;
  private int whiteEggs;

  public EggCarton(){
      brownEggs = 0;
      whiteEggs = 0;
  }

  public EggCarton (int a, int b){
    brownEggs = a;
    whiteEggs = b;
  }

  public void setBrownEggs(int bEggs){
    brownEggs = bEggs;
  }

  public void setWhiteEggs(int wEggs){
    whiteEggs = wEggs;
  }

  public void addEggs(int amount, string type){
    type = type.ToLower();
    type = type[0].ToString();
    if (type == "w"){
      whiteEggs = amount;
    }
    else if (type == "b"){
      brownEggs = amount;
    }
  }

  public int getBrownEggs(){
    return brownEggs;
  }

  public int getWhiteEggs(){
    return whiteEggs;
  }

  public int getTotalEggs(){
    return whiteEggs+brownEggs;
  }

}

class MainClass{

  public static void Main(){
    string choice;
    int inputA = 0;
    int inputB = 0;
    EggCarton egg;

    Console.WriteLine("create carton default. y or n");
    choice = Console.ReadLine();
    choice = choice.ToLower();
    choice = choice[0].ToString();

    if (choice == "y"){
      egg = new EggCarton();
    }

    Console.WriteLine("create carton with eggs. y or n?");
    choice = Console.ReadLine();
    choice = choice.ToLower();
    choice = choice[0].ToString();
    if (choice == "y"){

      Console.WriteLine("how many brown eggs?");
      inputA = int.Parse(Console.ReadLine());

      Console.WriteLine("How many white eggs");
      inputB = int.Parse(Console.ReadLine());

      egg = new EggCarton(inputA,inputB);
    }

    Console.WriteLine("add white eggs. y or n");
    choice = Console.ReadLine();
    choice = choice.ToLower();
    if (choice[0].ToString() == "y"){
      Console.WriteLine("how many?");
      choice = Console.ReadLine();
      egg.setWhiteEggs(int.Parse(choice));
    }

    Console.WriteLine("add brown eggs. y or n");
    choice = Console.ReadLine();
    choice = choice.ToLower();
    if (choice[0].ToString() == "y"){
      Console.WriteLine("how many?");
      choice = Console.ReadLine();
        egg.setBrownEggs(int.Parse(choice));
    }

    Console.WriteLine("add eggs by choice. y or n");
    choice = Console.ReadLine();
    choice = choice.ToLower();
    if (choice[0].ToString() == "y"){

      Console.WriteLine("what color?");
      choice = Console.ReadLine();
      Console.WriteLine("how many?");
      inputA = int.Parse(Console.ReadLine());
      egg.addEggs(inputA,choice);

      }
      Console.WriteLine("Brown egg count: " + egg.getBrownEggs());
      Console.WriteLine("White egg count: " + egg.getWhiteEggs());
      Console.WriteLine("Total egg count: " + egg.getTotalEggs());


    }
  }
