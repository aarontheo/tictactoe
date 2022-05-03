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
            Console.Write("Player " + players[player] + ", pick a square on the board: ");
            int pos;
        //Guarantee the input is a valid int on the board
        input: //HOLY MOLY THATS COOL
            while (!int.TryParse(Console.ReadLine(), out pos) || pos < 1 || pos > (board.GetLength(0) * board.GetLength(1)))
            {
                Console.Write("That's not a valid input! Try again: ");
            }
            pos--; //subtract 1 fromt he user input because the display values start at 1, not 0
            if (board[pos / height, pos % width] != 0)
            {
                Console.Write("That space is already taken! Try again: ");
                goto input; //IM FREAKING OUT RN this is so cool
            }
            board[pos / height, pos % width] = player + 1;
        }
        static bool CheckWin(int[,] board, int player)
        {
            int height = board.GetLength(0);
            int width = board.GetLength(1);
            //check rows, check columns, check the two diagonals
            //check rows
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (board[x, y] != player)
                    {
                        goto skip; //if the line is not contiguous, no need to continue with the loop
                    }
                }
                return true;
                skip:;
            }
            //check columns
            for (int y = 0; y < width; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (board[y, x] != player)
                    {
                        goto skip; //if the line is not contiguous, no need to continue with the loop
                    }
                    return true;
                }
                skip:;
            }
            //check the two diagonals
            //top-left to bottom-right
            for (int i = 0; i < height; i++)
            {
                if (board[i, i] == player)
                {
                    continue; //if the line is not contiguous, no need to continue with the loop
                }
                break;
            }
            for (int i = 0; i < height; i++)
            {
                if (board[i, height - i] == player)
                {
                    continue; //if the line is not contiguous, no need to continue with the loop
                }
                break;
            }
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
            int[,] board = new int[size,size];
            for (int b = 0; b < board.GetLength(0) * board.GetLength(1); b++)
            {
                for (int i = 0; i < players.Length; i++)
                {
                    Console.Clear();
                    DrawBoard(board);
                    MakeTurn(board, i);
                    if (CheckWin(board, i))
                    {
                        Console.WriteLine("Congratulations, "+players[i]+" wins!");
                        goto win;
                    }
                }
            }
            Console.WriteLine("The game is a draw! Nobody wins.");
            win:
            Console.WriteLine("Thank you for playing!");
        }
    }
}
