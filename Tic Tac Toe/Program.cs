using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    class Program
    {
        private static bool[,] fields = new bool[3,3];

        static void Main(string[] args)
        {
            ResetFields();

            Console.WriteLine("|---|---|---|");
            Console.WriteLine("| X | X | X |");
            Console.WriteLine("|---|---|---|");
            Console.WriteLine("| X | X | X |");
            Console.WriteLine("|---|---|---|");
            Console.WriteLine("| X | X | X |");
            Console.WriteLine("|---|---|---|");
        }

        private static void ResetFields()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    fields[i,j] = false;
                }
            }
        }
    }
}
