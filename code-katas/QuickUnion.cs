using System;
using System.Collections.Generic;
using System.Text;

namespace code_katas
{
    public class QuickUnion
    {
        private int[] instanceArray;

        public QuickUnion(int N)
        {
            instanceArray = new int[N];
            for (int i = 0; i < N; i++) instanceArray[i] = i;
        }

        private int Root(int i)
        {
            while (i != instanceArray[i]) i = instanceArray[i];
            return i;
        }

        public bool Connected(int p, int q)
        {
            return Root(p) == Root(q);
        }

        public void Union(int p, int q)
        {
            int i = Root(p);
            int j = Root(q);
            instanceArray[i] = j;
        }
    }
}
