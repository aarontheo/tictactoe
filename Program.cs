using System;

namespace tictactoe
{
    class Program
    {
        static char[] players = new char[] { 'X', 'O' };

        static void MakeTurn(int[,] board, int player)
        {
            //prompt player for position
            Console.Write(players[player] + ", enter a position on the board: ");
            int position;
            while (!int.TryParse(Console.ReadLine(),out position));
            Console.WriteLine("DEBUG position"+position);
            var pos = (x: position-1 % board.GetLength(0), y: position-1 / board.GetLength(1));
            //check if the square is a zero, prompt again until it is
            while (true)
            {
                if (board[pos.x, pos.y] != 0)
                {
                    Console.Write("\nThat space is already taken! Try again: ");
                    while (!int.TryParse(Console.ReadLine(),out position));
                    pos = (x: position-1 % board.GetLength(0), y: position-1 / board.GetLength(1));
                    Console.WriteLine("DEBUG: pos: "+pos);
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("PLAYER: "+player);
            board[pos.x, pos.y] = player;
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
            board[0, 0] = 1;
            while (true)
            {
                for (int i = 0; i < players.Length; i++)
                {
                    //Console.Clear();
                    DrawBoard(board);
                    MakeTurn(board,i);
                }
            }
        }
    }
}
