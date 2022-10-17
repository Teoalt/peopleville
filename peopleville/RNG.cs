using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace peopleville
{
    public static class RNG
    {
        private static Random random = new Random();
        public static int Random(int min, int max)
        {
            return random.Next(min, max+1);
        }
    }
}
