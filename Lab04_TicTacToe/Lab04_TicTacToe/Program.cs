using Lab04_TicTacToe.Classes;
using System;
using System.Text;
namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            bool rungame = true;

            while (rungame==true)
            {

                Console.WriteLine("Welcome to Tic-Tac-Toe");
                Console.WriteLine("What is player1 name: ");
                string name1 = Console.ReadLine();
                Console.WriteLine($"Hi {name1} ! Your marker is \"X\", have fun!");

                Player p1 = new Player();
                p1.Name = name1;

                Console.WriteLine("What is player2 name: ");
                string name2 = Console.ReadLine();
                Console.WriteLine($"Hi {name2} ! Your marker is \"O\", have fun!");
                Player p2 = new Player();
                p2.Name = name2;

                Game game = new Game(p1, p2);
                Player winner = game.Play();
                if (winner!= null)
                {
                    Console.WriteLine($"Winner is {winner.Name}! Congradulations!");
                }

                Console.WriteLine("Do you want to restart the game? y/n");

                string input = Console.ReadLine();
                string input2 = input.ToLower();
                if (input == "y") rungame = true;
                else rungame=false;

            }

            Environment.Exit(0);

        }


    }
}
