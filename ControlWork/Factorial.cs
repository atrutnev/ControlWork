using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ControlWork
{
    class Factorial
    {
        //Рекурсивное вычисление факториала
        internal BigInteger recursiveFact(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                BigInteger res = recursiveFact(x - 1) * x;
                return res;               
            }
        }

        //Вычисление факториала циклом
        internal BigInteger cycleFact(int x)
        {
            BigInteger res = 1;
            for (int i = 2; i <= x; i++)
            {
                res *= i;
            }
            return res;
        }
    }
}
