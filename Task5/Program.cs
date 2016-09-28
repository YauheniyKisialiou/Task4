using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.RectangleCounter(100.242, 2.342);
            Console.WriteLine(r.RectangleCounter(100.242, 2.342));
            Console.ReadLine();
        }
    }
}
