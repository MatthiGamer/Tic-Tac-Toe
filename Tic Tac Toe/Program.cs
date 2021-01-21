using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class Program
    {
        private static string[,] fields = new string[3,3];
        private static int player = 0;

        static void Main(string[] args)
        {
            ResetFields();

            Console.WriteLine("|---|---|---|");
            Console.WriteLine("| 1 | 2 | 3 |");
            Console.WriteLine("|---|---|---|");
            Console.WriteLine("| 4 | 5 | 6 |");
            Console.WriteLine("|---|---|---|");
            Console.WriteLine("| 7 | 8 | 9 |");
            Console.WriteLine("|---|---|---|");

            Console.ReadLine();
        }

        private static void ResetFields()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    fields[i,j] = "";
                }
            }
        }

        private static string WriteInField()
        {
            return player == 0 ? "X" : "O";
        }
    }
}
