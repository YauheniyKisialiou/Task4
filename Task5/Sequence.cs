using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public static class Sequence
    {
        public static List<BigInteger> FibanachiSequence(int n)
        {
            List<BigInteger> list = new List<BigInteger>();
            BigInteger first = 0;
            BigInteger second = 1;
            BigInteger third = 0;
            n = n - 2;
            list.Add(first);
            list.Add(second);
            while (n != 0)
            {

                third = first + second;
                list.Add(third);
                first = second;
                second = third;
                n--;
            }
            return list;
        }

        public static int Factarial(int n)
        {
            return n == 1 ? 1 : Factarial(n-1)*n;
        }
    }
}
