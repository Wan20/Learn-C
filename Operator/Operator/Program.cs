using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 8;
            int c;
            c = a + b;
            Console.WriteLine("Line 1 : {0}", c);
            c += 2;
            Console.WriteLine("Line 1 : {0}", c);
            ++c;
            Console.WriteLine("Line 1 : {0}", c);
            c++;
            Console.WriteLine("Line 1 : {0}", c);
            
            Console.ReadLine();
        }
    }
}
