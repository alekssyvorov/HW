using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrestikNolik
{
    class DrawF
    {
        public static void DrawField(string[] Section, int[] Data)
        {
            Console.Clear();
            for (int i = 1; i < 10; i++)
            {
                if (Data[i] == 0)
                {
                    Section[i] = " ";
                }
                else if (Data[i] == 1)
                {
                    Section[i] = "X";
                }
                else if (Data[i] == 2)
                {
                    Section[i] = "O";
                }
                Console.Write(Section[i]);
                if (i % 3 != 0)
                {
                    Console.Write("#");
                }
                else if (i % 3 == 0 && i != 9)
                {
                    Console.WriteLine();
                    Console.WriteLine("#####");
                }
            }
        }
    }
}
