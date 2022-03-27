using System;
using Lab04_TicTacToe.Classes;
namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            StartGame();
        }

        static void StartGame()
        {

            Player p1 = new Player();
            Console.WriteLine("Player 1 please enter your name ");
            p1.Name = Console.ReadLine();
            p1.Marker = "X";
            Player p2 = new Player();
            Console.WriteLine("Player 2 please enter your name ");
            p2.Name = Console.ReadLine();
            p2.Marker = "O";
            
            Game game = new Game(p1,p2);
            Player winer = game.Play();
            if (winer == null)
            {
                Console.WriteLine("There is no winner This game is draw ");
            }
            else
            {
                Console.WriteLine($"{winer.Name} is the winner");
            }
        }


    }
}
