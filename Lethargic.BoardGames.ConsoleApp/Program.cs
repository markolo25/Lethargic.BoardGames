using Lethargic.BoardGames.Model;
using Lethargic.BoardGames.View;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lethargic.BoardGames.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IGameBoard board = ...;
            IConsoleView view = ...;

            //Game Loop
            while (!board.IsFinished)
            {
                //Print Board
                Console.WriteLine(view.BoardToString(board));

                //Print Possible Moves
                Console.WriteLine("Possible moves:");
                IEnumerable<IGameMove> possibleMoves = board.GetPossibleMoves();
                Console.WriteLine(string.Join(",", possibleMoves.Select(view.MoveToString)));

                //Print the current player and input their move.
                Console.WriteLine("It is {0}’s turn.", view.PlayerToString(board.CurrentPlayer));
                Console.WriteLine("Enter a move: ");
                string input = Console.ReadLine();

                // Parse move and check if it's possible/valid
                IGameMove toApply = view.ParseMove(input);
                IGameMove foundMove = possibleMoves.FirstOrDefault(toApply.Equals);
                if (foundMove == null)
                {
                    Console.WriteLine("Sorry, that move is invalid.");
                }
                else
                {
                    board.ApplyMove(foundMove);
                }
            }
        }
    }
}
