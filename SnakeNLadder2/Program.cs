using System;

namespace SnakeNLadder2
{
    class Program
    {

        int playerPosition = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to snake and ladder simulation");
            Random rm2 = new Random();
            int playerMove = rm2.Next(1, 7);
        }
    }

}
