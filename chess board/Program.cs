using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess_board
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    if ((row+col)%2 ==0)
                    {
                        Console.Write('X');
                    }
                    else
                    {
                        Console.Write('O');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
