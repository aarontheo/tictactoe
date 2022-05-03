using System;

namespace tictactoe
{
    class Program
    {
        static char[] players = new char[] { 'X', 'O' };

        static void MakeTurn(int[,] board, int player)
        {
            //prompt player for position
            Console.Write(players[player]+", enter a position on the board!");
            int pos = Console.Read();
            //check if the square is a zero
            while (true)
            {
                
            }
        }
        static int CheckWin(int[,] board, int player)
        {
            //check for a line of the given int in the table board.
            return 5;
        }
        static void DrawBoard(int[,] board)
        {
            int cols = board.GetLength(0); //gets the number of columns
            int rows = board.GetLength(1); //gets the number of rows
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (board[i, j] == 1) //if the square has a character
                    {
                        Console.Write('X');
                    }
                    else if (board[i, j] == 2)
                    {
                        Console.Write('O');
                    }
                    else //if the square is 0, draw the index+1
                    {
                        Console.Write(j+rows*i+1);
                    }
                    if (j != cols-1){
                        Console.Write('|');
                    }
                }
                Console.Write('\n');
            }
        }
        static int CheckWin(int[,] board,int player)
        {
            return 5;
        }
        static void Main(string[] args)
        {
            int size = 3;
            int[] players = new int[2];
            int[,] board = new int[size, size];
            do {
                Console.Clear();
                DrawBoard(board);

            } while(true);
        }
    }
}
