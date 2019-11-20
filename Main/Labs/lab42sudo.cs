//Jonathan Grigg
//11.19.19
//lab4.2b
//cardCreator

using System;
class CardCreator{

 //    data
 //      string suit
 private string suit;
 //      string value
 private string value;
 private int valueI;

 // constructors
 //    default
 public CardCreator(){
  Random rnd = new Random();
  int index1;
  int index2;

  string[] suitR = {"Hearts", "Clubs", "Spades", "Diamonds"};
  string[] valueR = {"ace", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "jack", "queen", "king",}
  index1 = rnd.Next(suitR.Length);
  index2 = rnd.Next(valueR.Length);

  suit = suitR[index1].ToLower();
  value = valueR[index2].ToLower();
  switch (value){
    case "ace":
        valueI = 1;
        break;
    case "two":
        valueI = 2;
        break;
    case "three":
        valueI = 3;
        break;
    case "four":
        valueI = 4;
        break;
    case "five":
        valueI = 5;
        break;
    case "six":
        valueI = 6;
        break;
    case "seven":
        valueI = 7;
        break;
    case "eight":
        valueI = 8;
        break;
    case "nine":
        valueI = 9;
        break;
    case "ten":
        valueI = 10;
        break;
    case "jack":
        valueI = 10;
        break;
    case "queen":
        valueI = 10;
        break;
    case "king":
        valueI = 10;
        break;
  }
 }
 //    set character and suit
public CardCreator(string suitSet, string valueSet){
  suit = suitSet.ToLower();
  value = valueSet.ToLower();

  switch (value){
    case "ace":
        valueI = 1;
        break;
    case "two":
        valueI = 2;
        break;
    case "three":
        valueI = 3;
        break;
    case "four":
        valueI = 4;
        break;
    case "five":
        valueI = 5;
        break;
    case "six":
        valueI = 6;
        break;
    case "seven":
        valueI = 7;
        break;
    case "eight":
        valueI = 8;
        break;
    case "nine":
        valueI = 9;
        break;
    case "ten":
        valueI = 10;
        break;
    case "jack":
        valueI = 10;
        break;
    case "queen":
        valueI = 10;
        break;
    case "king":
        valueI = 10;
        break;
      }
}
 //    functions
 //      toString
 //        returns string with suit and value
public string toString(){
  return suit + " of " + value + ".";
}
 //      isFaceCard
 //        check if it's a facecard
 public string isFaceCard(){
   if (value == "jack" || value == "queen" || value == "king"){
     return value;
   }
 }
 //      isRedCard
 //        check if its red}
 public string isBlackCard(){
   if (suit == "clubs" || value == "spades"){
     return "Is Black";
   }
 }
 //      isBlackCard
 //        check if its black
 public string isRedCard(){
   if (suit == "hearts" || value == "daimonds"){
     return "Is Red";
   }
 }
 //      equals
 //        adds value of card to card input
 public int equals(int inp){
   return inp + valueI;
 }
 //      hasSameRank
 //        check the rank against input
 public string hasSameRank(string rank){
   if (rank.ToLower() == value){
     return "Same Rank";
   }
   else{
     return "not same rank";
   }
 }
 //      hasSameSuit
 //        check against input suit
 public string hasSameSuit(string inp){
   if (inp.ToLower() == suit){
     return "same suit";
   }
   else {
     return "not same suit";
   }
 }
 //      hasGreaterRank
 //        check if it has grater value then what's input
 public string hasGreaterRank(int inp){
   switch (value){
     case "ace":
         valueI = 1;
         break;
     case "two":
         valueI = 2;
         break;
     case "three":
         valueI = 3;
         break;
     case "four":
         valueI = 4;
         break;
     case "five":
         valueI = 5;
         break;
     case "six":
         valueI = 6;
         break;
     case "seven":
         valueI = 7;
         break;
     case "eight":
         valueI = 8;
         break;
     case "nine":
         valueI = 9;
         break;
     case "ten":
         valueI = 10;
         break;
     case "jack":
         valueI = 11;
         break;
     case "queen":
         valueI = 12;
         break;
     case "king":
         valueI = 13;
         break;
       }
   if (inp.ToLower() > valueI){
     return "your card has a higher rank";
   }
   else{
     return "your card has a lower rank";
   }
   switch (value){
     case "ace":
         valueI = 1;
         break;
     case "two":
         valueI = 2;
         break;
     case "three":
         valueI = 3;
         break;
     case "four":
         valueI = 4;
         break;
     case "five":
         valueI = 5;
         break;
     case "six":
         valueI = 6;
         break;
     case "seven":
         valueI = 7;
         break;
     case "eight":
         valueI = 8;
         break;
     case "nine":
         valueI = 9;
         break;
     case "ten":
         valueI = 10;
         break;
     case "jack":
         valueI = 10;
         break;
     case "queen":
         valueI = 10;
         break;
     case "king":
         valueI = 10;
         break;
       }
 }
}
 //  main
 //
 //    create object
 //
 //    give option to set value
 //      use second constructor
 //
 //    run through a yes or no for all the options use a switch.
 //    ask for input before checking.
