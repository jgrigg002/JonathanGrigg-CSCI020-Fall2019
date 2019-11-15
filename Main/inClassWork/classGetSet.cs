
using System;

class Salary{

    //Constructor
    public Salary(){
      annual_ = 0;
    }
    //OverLoaded Constructor
    public Salary(int a){
      if (a>0){
        annual_ = a;
      }
      else{
        annual_ = 0;
      }
    }
    //Datafield
  private double annual_;
    //mutator function
  public void SetAnnualSalary(double salary)
  {
    if (salary < 0){

      annual_ = salary;
    }
    else{

      annual_ = 0;
    }
  }
  //accessor function
  public double GetAnnualSalary(){

  return annual_;
  }
  public void Print(){

  Console.WriteLine("$"+annual_);
  }
}

class MainClass {

  public static void Main () {
  Salary newSalary = new Salary();


  }
}

//Comment the class per the class style guide
//Identify the following parts of the class
// data field
// mutator function
// accessor function
//Create a main function that creates an object and runs all of the functions in order
