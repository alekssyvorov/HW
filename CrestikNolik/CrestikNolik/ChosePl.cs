using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrestikNolik
{
    class ChosePl
    {
        public static int[] Choose(int[] Data)
        {
            Console.WriteLine();
            Console.WriteLine("Куда ходим?");
            var Num = Console.ReadKey();
            bool Er = true;
            switch (Num.Key)
            {
                case ConsoleKey.NumPad1:
                    {
                        if (Data[1] == 0)
                            Data[1] = 1;
                        else if (Data[1] == 1 || Data[1] == 2)
                            Er = false;
                        break;
                    }
                case ConsoleKey.NumPad2:
                    {
                        if (Data[2] == 0)
                            Data[2] = 1;
                        else if (Data[2] == 1 || Data[2] == 2)
                            Er = false;
                        break;
                    }
                case ConsoleKey.NumPad3:
                    {
                        if (Data[3] == 0)
                            Data[3] = 1;
                        else if (Data[3] == 1 || Data[3] == 2)
                            Er = false;
                        break;
                    }
                case ConsoleKey.NumPad4:
                    {
                        if (Data[4] == 0)
                            Data[4] = 1;
                        else if (Data[4] == 1 || Data[4] == 2)
                            Er = false;
                        break;
                    }
                case ConsoleKey.NumPad5:
                    {
                        if (Data[5] == 0)
                            Data[5] = 1;
                        else if (Data[5] == 1 || Data[5] == 2)
                            Er = false;
                        break;
                    }
                case ConsoleKey.NumPad6:
                    {
                        if (Data[6] == 0)
                            Data[6] = 1;
                        else if (Data[6] == 1 || Data[6] == 2)
                            Er = false;
                        break;
                    }
                case ConsoleKey.NumPad7:
                    {
                        if (Data[7] == 0)
                            Data[7] = 1;
                        else if (Data[7] == 1 || Data[7] == 2)
                            Er = false;
                        break;
                    }
                case ConsoleKey.NumPad8:
                    {
                        if (Data[8] == 0)
                            Data[8] = 1;
                        else if (Data[8] == 1 || Data[8] == 2)
                            Er = false;
                        break;
                    }
                case ConsoleKey.NumPad9:
                    {
                        if (Data[9] == 0)
                            Data[9] = 1;
                        else if (Data[9] == 1 || Data[9] == 2)
                            Er = false;
                        break;
                    }
            }
            if (Er == true)
            {
                AImove.AI(Data);
            }
            else if (Er == false)
            {
                Console.WriteLine("Ошибка!Попробуйте еще раз!");
            }
            return Data;
        }
    }
}
