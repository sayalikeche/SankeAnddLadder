

using System;

namespace SnakeAndLadder
{
    class Program
    {

        public const int NO_PLAY = 0;
        public const int LADDER = 1;
        public const int SNAKE = 2;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the snake and ladder game.");
            Console.WriteLine();
            Console.WriteLine("Player mode:single: Starting position at 0");
            Console.WriteLine("*Start Game*");



            int position = 0;

            Random die = new Random();
            Random options = new Random();
            int dice = die.Next(1, 7);
            Console.WriteLine("The number on this die roll is: " + dice);

            int opt = options.Next(0, 3);


            if (opt == NO_PLAY)
            {
                Console.WriteLine("No play: Player in same position-- " + position);
                Console.ReadLine();
            }
            else if (opt == LADDER)
            {
                position = position + dice;
                Console.WriteLine("Ladder! new postion-- " + position);
                Console.ReadLine();
            }
            else
            {
                position = position - dice;
                Console.WriteLine("Oops,Snake! new position-- " + position);
                Console.ReadLine();
            }
        }
    }
}