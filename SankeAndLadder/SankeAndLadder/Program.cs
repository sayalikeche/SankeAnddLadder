using System;

namespace SnakeAndLadder
{
    class Program
    {

        public const int NO_PLAY = 0;
        public const int LADDER = 1;
        public const int SNAKE = 2;
        public const int FINAL = 100;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the snake and ladder game.");
            Console.WriteLine();
            Console.WriteLine("Player mode:single: Starting position at 0");
            Console.WriteLine("*Start Game*");


            int position = 0;

            Random die = new Random();
            Random options = new Random();

            while (position < FINAL)
            {
                int dice = die.Next(1, 7);
                Console.WriteLine("The number on this die roll is: " + dice);
                int opt = options.Next(0, 3);


                if (opt == NO_PLAY)
                {
                    Console.WriteLine("No play: Player in same position-- " + position);
                }
                else if (opt == LADDER)
                {
                    position = position + dice;
                    if (position > 100)
                    {
                        Console.WriteLine("Try Again, throw exceeded 100!");
                        position = position - dice;
                    }
                    else
                    {
                        Console.WriteLine("Ladder! new postion-- " + position);
                    }

                }
                else
                {
                    position = position - dice;
                    Console.WriteLine("Oops,Snake! new position-- " + position);
                }

                if (position < 0)
                {
                    position = 0;
                }
            }

        }




    }
}