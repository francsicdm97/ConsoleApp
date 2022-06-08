using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
         {
             //implicit conversion

             int num = 123905322;
             long bignum = num;

             float myFloat = 13.37f;
             double myNewdouble = myFloat;

             double myDouble = 13.37;
             int myInt;

             //explicit conversion
             //cast double to int
             myInt = (int)myDouble;

             //type conversion
             string myDoubleString = myDouble.ToString(); //"13.37"
             string myFloatString = myFloat.ToString();

             bool sunIsShining = true;
             string myBoolString = sunIsShining.ToString();

             string myString = "15";
             string myString2 = "13";
             int num1 = Int32.Parse(myString);
             int num2 = Int32.Parse(myString2);
             int resultInt = num1 + num2;
             string result = myString + myString2;


             Console.WriteLine(resultInt);
             Console.ReadKey();
         } 


       

    }
}

