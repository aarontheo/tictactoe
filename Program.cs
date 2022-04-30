using System;

namespace tictactoe
{
    class Program
    {
        static void DrawBoard(int[,] board)
        {
            int cols = board.GetLength(1); //gets the number of columns
            int rows = board.GetLength(0); //gets the number of rows
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (board[i, j] == 1) //if the square is 1, draw X
                    {
                        Console.Write('X');
                    }
                    else if (board[i, j] == 2) //if the square is 2, draw O
                    {
                        Console.Write('O');
                    }
                    else //if the square is 0, draw the index+1
                    {
                        Console.Write(i+rows*j+1);
                    }
                }
                Console.Write('\n');
            }
        }
        static void Main(string[] args)
        {
            int size = 3;
            int[,] board = new int[size, size];
            board[0, 0] = 1;
            //print the board to the console
            DrawBoard(board);
        }
    }
}
