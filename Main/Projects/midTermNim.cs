//Jonathan Grigg
//10.09.19
//mid term
//game of nim

using System;
class gameOfNim{
  public static void Main(){
    //create two piles for the gameOfNim using double array
    Random rnd =new Random();
    int[] pile = new int[2];
    int playerSwitch = 2;
    int playerChoice = 1;
    //call random class and generate random number into two piles. probably no more then 25
    pile[0] = rnd.Next(1,25);
    pile[1] = rnd.Next(1,25);
    Console.WriteLine("welcome to the game of nim.\nBefore you have two piles with between 1 and 25 stones in them.");
    Console.WriteLine("First pile has {0}, Second pile has {1}", pile[0], pile[1]);
    Console.WriteLine("You will be playing against the computer. You go first. Each turn you will choose to remove either 1, 2, or 3 stones.");
    Console.WriteLine("First choose a pile then choose how many stones. player to remove the last stone wins.");
    //create loop for gameOfNim use 0 zalue for piles as exit req.
    while (pile[0] > 0 || pile[1] > 0){
      Console.WriteLine("First pile has {0}, Second pile has {1}", pile[0], pile[1]);
      //use int counter in player1 mod inside the switch case
      playerSwitch = playerSwitch % 2;
      switch (playerSwitch){
        //for human read values in and them prompt them to choose a pile an how many to take, between 1 and 3.
        //for computer read in the values of the piles.
        case 0: //for player
          //promt player and then let them choose to remove stones.
          while (playerChoice > 0){
            Console.WriteLine("which pile would you like to choose? \n1 or 2?");
              playerChoice = int.Parse(Console.ReadLine());
              switch(playerChoice){
                case 1:
                //use while loop to ask how many stones to remove
                while (playerChoice > 0){
                Console.WriteLine("Please choose how many stones to remove.\n1, 2, or 3.");
                playerChoice = int.Parse(Console.ReadLine());
                //use switch to remove stones based on choice
                switch(playerChoice){
                  //case 1 removes one stone, case 2 removes 2... ect.
                  case 1:
                    pile[0] = pile[0]-1;
                    playerChoice = 0;
                    break;
                  case 2:
                    pile[0] = pile[0]-2;
                    playerChoice = 0;
                    break;
                  case 3:
                    pile[0] = pile[0]-3;
                    playerChoice = 0;
                    break;
                  default:
                    playerChoice = 4;
                    break;
                  }
                }
                playerChoice = 0;
                break;

                case 2:
                while (playerChoice > 0){
                Console.WriteLine("Please choose how many stones to remove.\n1, 2, or 3.");
                playerChoice = int.Parse(Console.ReadLine());
                //use switch to remove stones based on choice
                switch(playerChoice){
                  //case 1 removes one stone, case 2 removes 2... ect.
                  case 1:
                    pile[1] = pile[1]-1;
                    playerChoice = 0;
                    break;
                  case 2:
                    pile[1] = pile[1]-2;
                    playerChoice = 0;
                    break;
                  case 3:
                    pile[1] = pile[1]-3;
                    playerChoice = 0;
                    break;
                  default:
                    playerChoice = 4;
                    break;
                  }
                }
                playerChoice = 0;
                break;
                default:
                playerChoice = 3;
                break;
              }
            }
            if (pile[0] == 0 && pile[1] == 0)
            Console.WriteLine("Player wins!");
            playerChoice = 4;
          playerSwitch++;
          break;
        case 1: //for computer
          //call computer function/class and based on stone count choose answer.
          Console.WriteLine("Computer's turn.");
          if (pile[0]>0){
            pile[0] = pile[0] - rnd.Next(1,3);
          }
          else if (pile[1]>0){
            pile[1] = pile[1] - rnd.Next(1,3);
          }
          if (pile[0] == 0 && pile[1] == 0)
          Console.WriteLine("computer wins");
          //if with greater then zero
          //remove random between 1 and 3.
          playerSwitch++;
          break;

      }
    //for human read values in and them prompt them to choose a pile an how many to take, between 1 and 3.
    //for computer read in the values of the piles.
    }

  }
}
