using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FibonacciNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            FibNumber f = new FibNumber();
            Console.WriteLine(f[7]);
            Console.ReadKey();
        }
    }
}
