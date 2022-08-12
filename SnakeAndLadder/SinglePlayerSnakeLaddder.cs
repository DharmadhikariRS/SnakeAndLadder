using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class SinglePlayerSnakeLaddder
    {
        public void SinglePlayerGame()
        {
            Console.WriteLine("Hello, World!");
            int RandomCount = 0;
            int WinningPosition = 100;
            int RepeatationCount = 0;
            var track = new List<int>();
            
            while (RandomCount < WinningPosition)
            {

                Random random = new Random();
                int DieceVal = random.Next(1, 7);
                int Check = random.Next(3);

                switch (Check)
                {
                    case 1:
                        Console.WriteLine("You are on Ladder point");
                        RandomCount += DieceVal;
                        if (RandomCount > 100)
                        {

                            RandomCount -= DieceVal;
                        }
                        break;
                    case 2:
                        Console.WriteLine("You are on Snake point");
                        RandomCount -= DieceVal;
                        if (RandomCount < 0)
                        {
                            RandomCount = 0;
                        }
                        break;

                    default:
                        Console.WriteLine("You Chose No Play");
                        continue;

                }

                RepeatationCount++;
                //Console.WriteLine("Your Position is " + RandomCount);

                track.Add(RandomCount);
                

            }
            Console.WriteLine("Your positioms after every die roll are: ");
            foreach (int i in track)
            {

                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("You played {0} times ", RepeatationCount);
           
            Console.WriteLine("You Won");
        }

    }
}
