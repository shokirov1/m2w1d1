using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m2w1d1.Task1
{
    public static class Counter
    {
        public static int? count;
        public static void Increment()
        {
            count++;
        }
        public static void Reset() 
        { 
            count = 0; 
        }
    }
}
