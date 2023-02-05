using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrestikNolik
{
    class AImove
    {
        public static int[] AI(int[] Data)
        {
            Random random = new Random();
            int Sect = random.Next(0,9);
            while (Data[Sect] != 0)
            {
                Sect = random.Next(1, 9);
            }
            Data[Sect] = 2;

            return Data;
        }
    }
}
