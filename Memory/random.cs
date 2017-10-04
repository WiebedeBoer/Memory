using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    class random
    {

        public static void Rand(int []shuf)
        {
            int[] shuf = new int[16] { 1, 2, 3, 4, 5, 6, 7, 8, 1, 2, 3, 4, 5, 6, 7, 8};
            for (int t = 0; t < shuf.Length; t++)
            {
                int tmp = shuf[t];
                int r = Random.Range(t, shuf.Length);
                shuf[t] = shuf[r];
                shuf[r] = tmp;
            }
        }

    }
}
