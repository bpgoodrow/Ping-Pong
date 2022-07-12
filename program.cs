using System;

namespace Program
{
  class PingPong
  {
    static void Main()
    {
      Console.WriteLine("Enter a number:");
      string userInput = Console.ReadLine();
      int intUserInput = int.Parse(userInput);
      for (int i = 1; i <= intUserInput; i ++)
      {
        if (i % 3 == 0 && i % 5 == 0)
        {
          Console.WriteLine("ping-pong");
        }
        else if (i % 5 == 0)
        {
          Console.WriteLine("pong");
        }
        else if (i % 3 == 0)
        {
          Console.WriteLine("ping");
        }
        else
        {
          Console.WriteLine(i);
        }
      }
    }
  }
}