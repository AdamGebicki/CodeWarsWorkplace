using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Kata : IKataNames
    {
        public string CardMask(string cc)
        {
            int offset = 4;
            char[] ccAsCharList = cc.ToCharArray();
            for (int index = 0; index < cc.Length - offset; index++) 
            {
                ccAsCharList[index] = '#';
            }
            return new string(ccAsCharList);
        }

        public int Devided(int value)
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