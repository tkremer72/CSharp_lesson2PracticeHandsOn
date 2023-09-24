using System;

namespace lesson2HandsOn
{
     public class Program
{
    private static void Main(string[] args)
    {
          //Part 1 add a value of your choice to the variable age
        int age = 25;
          //Part 2 Declare a boolean variable isStudent and give it a value
          bool isStudent = true;
          //Part 1 create a double variable price and initialize it to 0
        double price = 0; 

          //Part 1 if the age is greater than or equal to 65, pay $7
        if(age >= 65) {
          price = 7;
        }
        //Part 1 if the age is less than or equal to 12, pay $8
        else if(isStudent || age <= 12) {  //Part 2 include isStudent in this check
          price = 8;
        }
        //Part 1 Everyone else, pay $10
        else { 
          price = 10;
        }
        Console.WriteLine("Your ticket price is $" + price);
    }
}
}