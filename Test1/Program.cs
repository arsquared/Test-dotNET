using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void foo(int x)
        {
            Console.WriteLine(x.ToString() + " is why I live");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Yodeling Yak!");
            foo(37);
        }
    }
}
