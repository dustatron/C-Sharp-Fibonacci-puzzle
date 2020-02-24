using System;

class Fibonacci
{
  static void Main()
  {
    Console.WriteLine("Welcome to the Fibonacci list maker");
    Console.WriteLine("Please enter ending number");
    Console.Write("Number: ");
    int userInput = int.Parse(Console.ReadLine());
    makeFib(userInput);
  }

  static void makeFib(int input)
  {
    int a = 0;
    int b = 1;
    int lastNumber;
    
    while (a < input)
    {
      lastNumber = a + b;
      Console.WriteLine(lastNumber);
      a = b;
      b = lastNumber;

    }

  }
}