using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrestikNolik
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sections = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            int[] NumSect = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            bool Win = false;
            while (Win == false)
            {
                DrawF.DrawField(sections, NumSect);
                ChosePl.Choose(NumSect);
                
                if (NumSect[1] == NumSect[4] && NumSect[4] == NumSect[7] && NumSect[4] != 0)
                {
                    if (NumSect[1] == 1)
                    {
                        Console.WriteLine("Игрок выйграл!");
                        Win = true;
                    }
                    else if (NumSect[1] == 2)
                    {
                        Console.WriteLine("Бот выйграл!");
                        Win = true;
                    }
                }
                else if (NumSect[2] == NumSect[5] && NumSect[5] == NumSect[8] && NumSect[5] != 0)
                {
                    if (NumSect[1] == 1)
                    {
                        Console.WriteLine("Игрок выйграл!");
                        Win = true;
                    }
                    else if (NumSect[1] == 2)
                    {
                        Console.WriteLine("Бот выйграл!");
                        Win = true;
                    }
                }
                else if (NumSect[3] == NumSect[6] && NumSect[6] == NumSect[9] && NumSect[6] != 0)
                {
                    if (NumSect[1] == 1)
                    {
                        Console.WriteLine("Игрок выйграл!");
                        Win = true;
                    }
                    else if (NumSect[1] == 2)
                    {
                        Console.WriteLine("Бот выйграл!");
                        Win = true;
                    }
                }
                else if (NumSect[1] == NumSect[2] && NumSect[2] == NumSect[3] && NumSect[2] != 0)
                {
                    if (NumSect[1] == 1)
                    {
                        Console.WriteLine("Игрок выйграл!");
                        Win = true;
                    }
                    else if (NumSect[1] == 2)
                    {
                        Console.WriteLine("Бот выйграл!");
                        Win = true;
                    }
                }
                else if (NumSect[4] == NumSect[5] && NumSect[5] == NumSect[6] && NumSect[5] != 0)
                {
                    if (NumSect[1] == 1)
                    {
                        Console.WriteLine("Игрок выйграл!");
                        Win = true;
                    }
                    else if (NumSect[1] == 2)
                    {
                        Console.WriteLine("Бот выйграл!");
                        Win = true;
                    }
                }
                else if (NumSect[7] == NumSect[8] && NumSect[8] == NumSect[9] && NumSect[8] != 0)
                {
                    if (NumSect[1] == 1)
                    {
                        Console.WriteLine("Игрок выйграл!");
                        Win = true;
                    }
                    else if (NumSect[1] == 2)
                    {
                        Console.WriteLine("Бот выйграл!");
                        Win = true;
                    }
                }
                else if (NumSect[1] == NumSect[5] && NumSect[5] == NumSect[9] && NumSect[5] != 0)
                {
                    if (NumSect[1] == 1)
                    {
                        Console.WriteLine("Игрок выйграл!");
                        Win = true;
                    }
                    else if (NumSect[1] == 2)
                    {
                        Console.WriteLine("Бот выйграл!");
                        Win = true;
                    }
                }
                else if (NumSect[3] == NumSect[5] && NumSect[5] == NumSect[7] && NumSect[5] != 0)
                {
                    if (NumSect[1] == 1)
                    {
                        Console.WriteLine("Игрок выйграл!");
                        Win = true;
                    }
                    else if (NumSect[1] == 2)
                    {
                        Console.WriteLine("Бот выйграл!");
                        Win = true;
                    }
                }

            }
        }
    }
}
