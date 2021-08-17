using System;

namespace SnakeNLadder2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("welcome to snake and ladder simulation");
            int playerPosition = 0;
            int diceOutput = 0;
            int diceRoll = 0;
            while (playerPosition != 100)
            {
                Random rm = new Random();
                diceOutput = rm.Next(1, 7);
                Console.WriteLine("diceOutput is " + diceOutput);
                Random rm2 = new Random();
                int playerMove = rm2.Next(1, 4);
                switch (playerMove)
                {
                    case 1:
                        Console.WriteLine("no playermove");
                        Console.WriteLine("playerPosition is " + playerPosition);
                        break;
                    case 2:
                        Console.WriteLine(" playermove is ladder");
                        playerPosition += diceOutput;
                        Console.WriteLine("playerPosition is " + playerPosition);
                        if (playerPosition > 100)
                        {
                            playerPosition += 0;
                        }
                        break;
                    case 3:
                        Console.WriteLine("playermove is snake");
                        playerPosition -= diceOutput;
                        Console.WriteLine("playerPosition is " + playerPosition);
                        if (playerPosition < 0)
                        {
                            playerPosition = 0;
                        }
                        break;


                }
            }
        }
    }
}


