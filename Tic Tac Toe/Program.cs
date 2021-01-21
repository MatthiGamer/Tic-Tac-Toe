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
        private static bool[] fieldAvailability = new bool[9];
        private static bool player = true;

        static void Main(string[] args)
        {
            ResetFields();

            Console.WriteLine("-|---|---|---|-");
            Console.WriteLine("-| 0 | 1 | 2 |-");
            Console.WriteLine("-|---|---|---|-");
            Console.WriteLine("-| 3 | 4 | 5 |-");
            Console.WriteLine("-|---|---|---|-");
            Console.WriteLine("-| 6 | 7 | 8 |-");
            Console.WriteLine("-|---|---|---|-");

            Console.ReadLine();
        }

        private static void ResetFields()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    fields[i,j] = "";
                    fieldAvailability[(j + 1) + (i * 3) - 1] = false;
                }
            }
        }

        private static string WriteInField()
        {
            return player ? "X" : "O";
        }

        private static void ChangePlayer()
        {
            player = !player;
        }

        private static bool IsAvailable(int field)
        {
            return fieldAvailability[field];
        }
    }
}
