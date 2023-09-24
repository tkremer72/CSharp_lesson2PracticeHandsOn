using System;

namespace lesson2HandsOn
{
     public class Program
{
    private static void Main(string[] args)
    {
        int age = 25; //set the value of age to 25
        double price = 0; //declare a double variable for price and initialize it to 0

        if(age >= 65) {//if senior citizen, pay $7
          price = 7;
        }
        else if(age <= 12) { //if 12 or younger, pay $*
          price = 8;
        }
        else { //everyone else pay $10
          price = 10;
        }
        Console.WriteLine("Your ticket price is $" + price);
    }
}
}