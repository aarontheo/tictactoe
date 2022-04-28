using System;

namespace tictactoe
{
    class Program
    {
        static void print(params string[] args){
            foreach (string str in args){
                Console.Write(str+' ');
            }
            Console.Write('\n');
        }
        static void Main(string[] args)
        {
            int width = 3;
            int height = 3;
            bool[,] board = new bool[width,height];
            board[0,0] = true;
            print("ok","three","hello","cool");
            for (int r = 0; r < height; r++){
                for (int c = 0; c < width; c++){
                    
                }
            }
        }
    }
}
