using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public static class Sequence
    {
        public static int FibanachiSequence(int n)
        {
            return n > 1 ? FibanachiSequence(n - 1) + FibanachiSequence(n - 2) : n;
        }

        public static int Factarial(int n)
        {
            return n == 1 ? 1 : Factarial(n-1)*n;
        }
    }
}
