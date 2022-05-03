using System;

namespace tictactoe
{
    class Program
    {
        static char[] players = new char[] { 'X', 'O' };
        static void MakeTurn(int[,] board, int player)
        {
            int width = board.GetLength(0);
            int height = board.GetLength(1);
            Console.WriteLine("DEBUG Player: " + players[player] + player);
            Console.WriteLine("Player " + players[player] + ", pick a square on the board: ");
            int pos;
            //Guarantee the input is a valid int on the board
            input: //HOLY MOLY THATS COOL
            while (!int.TryParse(Console.ReadLine(), out pos) || pos < 1 || pos > (board.GetLength(0) * board.GetLength(1)))
            {
                Console.Write("That's not a valid input! Try again: ");
            }
            pos--;
            if (board[pos / height, pos % width] != 0){
                Console.WriteLine("That space is already taken! Try again:");
                goto input; //IM FREAKING OUT RN
            }
                board[pos / height, pos % width] = player + 1;
        }
        static bool CheckWin(int[,] board, int player)
        {
            //check for a line of the given int in the table board.
            return false;
        }
        static void DrawBoard(int[,] board)
        {
            int cols = board.GetLength(0); //gets the number of columns
            int rows = board.GetLength(1); //gets the number of rows
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (board[i, j] == 0) //if the square is 0, draw the index+1
                    {
                        Console.Write(j + rows * i + 1);
                    }
                    else
                    {
                        Console.Write(players[board[i, j] - 1]);
                    }
                    if (j != cols - 1)
                    {
                        Console.Write('|');
                    }
                }
                Console.Write('\n');
            }
        }

        static void Main(string[] args)
        {
            int size = 3;
            int[,] board = new int[size, size];
            for (int b=0;b<board.GetLength(0)*board.GetLength(1);b++)
            {
                for (int i = 0; i < players.Length; i++)
                {
                    Console.Clear();
                    DrawBoard(board);
                    MakeTurn(board, i);
                }
            }
        }
    }
}
