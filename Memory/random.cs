using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    class random
    {

        public static void Rand()
        {
            string[] shuf = new string[16] {"1", "2", "3", "4", "5", "6", "7", "8", "1", "2", "3", "4", "5", "6", "7", "8"};
            Random rnd = new Random();
            for (int t = 0; t < shuf.Length; t++)
            {
                string tmp = shuf[t];
                int r = rnd.Next(t, shuf.Length);
                shuf[t] = shuf[r];
                shuf[r] = tmp;
            }
        }

    }
}
