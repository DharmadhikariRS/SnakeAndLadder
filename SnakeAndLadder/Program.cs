namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake Ladder Game");
            Console.WriteLine("Press 1 for Single Player");
            Console.WriteLine("Press 2 for Single Player");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    SinglePlayerSnakeLaddder singlePlayerSnakeLaddder = new SinglePlayerSnakeLaddder();
                    singlePlayerSnakeLaddder.SinglePlayerGame();
                    break;
                case 2:
                    DoublePlayerSnakeLadder doublePlayerSnakeLadder= new DoublePlayerSnakeLadder();
                    doublePlayerSnakeLadder.Winning();
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
            }
    }
}