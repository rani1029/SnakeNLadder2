using System;

namespace SnakeNLadder2
{
    class Program
    {

        //int playerPosition = 0;
        static void Main(string[] args)
        {
            int playerPosition = 0;
            int diceOutput = 0;


            Console.WriteLine("welcome to snake and ladder simulation");
            Random rm = new Random();
            diceOutput = rm.Next(1, 7);
            Console.WriteLine("diceOutput is " + diceOutput);
            //Random rm2 = new Random();
            //int playerMove = rm2.Next(1, 7);
        }
    }

}
