using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Kata
    {
        public static int Solution(int value)
        {
            int res = 0;
            for (int index = 0; index < value; index++)
            {
                if (index % 3 == 0 || index % 5 == 0)
                {
                    res += index;
                }
            }
            return res;
        }
    }
}
