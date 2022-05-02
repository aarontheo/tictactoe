using System;

namespace tictactoe
{
    class Program
    {
        static char[] players = new char[] {'X','O'};
        static void DrawBoard(int[,] board)
        /*
        TODO: Change the way that boards larger than 3x3 are displayed,
        some ideas:
        -display in HEX instead, supports a 4x4 board without kerning issue
        -use char codes, add to display index to start with uppercase alphabet codes?
        */
        {
            int cols = board.GetLength(0); //gets the number of columns
            int rows = board.GetLength(1); //gets the number of rows
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (board[i, j] != 'f') //if the square has a character
                    {
                        Console.Write('X');
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

        static void MakeTurn(int[,] board,char playerChar)
        {

        }
        static int CheckWin()
        {
            return 5;
        }
        static void Main(string[] args)
        {
            
            int size = 3;
            char[,] board = new char[size, size];
            board[0, 0] = 'X';
            Console.Write("This is an empty character: "+board[1,1]);
            //do while loop
                //foreach player
                    //print the board to the console
                    //prompt current player for their move
                //DrawBoard(board);
            //while game is running
        }
    }
}
