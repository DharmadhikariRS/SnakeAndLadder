using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class DoublePlayerSnakeLadder
    {
        public void Winning()
        {
            Console.WriteLine("Welcome to snake ladder game");
            Console.WriteLine("Enter first player name");
            string name1 = Console.ReadLine();
            Console.WriteLine("Enter seconds player name");
            string name2 = Console.ReadLine();
            int count = 0;
            var track_Position1 = new List<int>();
            var track_Position2 = new List<int>();


            int position1 = 0;
            int position2 = 0;
            bool a;

            while (position1 < 100 && position2 < 100)
            {
                count++;


                (position1, a) = SnakeLadder(position1);
                track_Position1.Add(position1);
                Console.WriteLine("position1= " + position1);
                while (a)
                {
                    Console.WriteLine("position1= " + position1);
                    (position1, a) = SnakeLadder(position1);
                    if (position1 < 100)
                    {
                        track_Position1.Add(position1);
                    }
                }
                (position2, a) = SnakeLadder(position2);
                track_Position2.Add(position2);
                Console.WriteLine("position2= " + position2);
                while (a)
                {
                    Console.WriteLine("position1= " + position1);
                    (position2, a) = SnakeLadder(position2);
                    if (position2 < 100)
                    {
                        track_Position2.Add(position2);
                    }
                }
            }

            Console.WriteLine(name1 + " positins are");

            foreach (var track1 in track_Position1)
            {
                Console.Write(track1 + " ");
            }
            Console.WriteLine();
            Console.WriteLine(name2 + " positins are");
            foreach (var track2 in track_Position2)
            {
                Console.Write(track2 + " ");
            }
            Console.WriteLine();

            if (position1 == 100)
            {
                Console.WriteLine(name1 + " Wins");
            }
            if (position2 == 100)
            {
                Console.WriteLine(name2 + " Wins");
            }

            Console.WriteLine("Total iteration: " + count);
        }

        public (int, bool) SnakeLadder(int RandomCount)
        {

            Random random = new Random();

            int DieceVal = random.Next(1, 7);
            int Check = random.Next(3);
            bool ladder = false;

            switch (Check)
            {
                case 1:
                    Console.WriteLine("You are on Ladder point");
                    RandomCount += DieceVal;
                    if (RandomCount > 100)
                    {

                        RandomCount -= DieceVal;
                    }
                    ladder = true;

                    break;
                case 2:
                    Console.WriteLine("You are on Snake point");
                    RandomCount -= DieceVal;
                    if (RandomCount < 0)
                    {
                        RandomCount = 0;
                    }
                    ladder = false;
                    break;

                default:
                    Console.WriteLine("You Chose No Play");
                    break;


            }



            Console.WriteLine("Your Position is " + RandomCount);

            return (RandomCount, ladder);


        }
    }
}
