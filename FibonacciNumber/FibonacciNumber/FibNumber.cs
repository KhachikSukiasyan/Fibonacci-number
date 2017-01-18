using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumber
{
    public class FibNumber
    {

        public int this[int k]
        {
           get
           {
                if (k < 0)
                {
                    Console.WriteLine("You can't pass negative index");
                    return int.MinValue;
                }
                else
                    return function(k);
           }
        }

       private int function(int k)
        {
            if (k == 0 || k == 1)
                return 1;
            if (k == 2)
                return 2;

            int k1 = 1;
            int k2 = 1;
            int k3 = 2;

            for (int i = 0; i < k - 2; i++)
            {
                k1 = k2;
                k2 = k3;
                k3 = k1 + k2;  
            }

            return k3;
        }

    }
}
