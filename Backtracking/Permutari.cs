using System;
using System.Collections.Generic;
using System.Text;

using static System.Console;
namespace Backtracking
{
     /*
      * Realizati permutari din multimea M astfel incat primul element din solutie sa fie impar iar ulyimul sa fie par
      */

    class Permutari
    {
        private int[] s;
        private int n;

        public Permutari(int n)
        {
            s = new int[n+1];
            this.n = n;

            back(0);
        }
      
        private void tipar()
        {
            for (int i = 0; i < n; i++)
            {
                Write(s[i] + " ");
            }
            WriteLine();
        }

        private bool valid(int k)
        {

            if (k == 0 && s[k] % 2 == 0)
                return false;

            if (k == n - 1 && s[k] % 2 == 1)
                return false;

            for (int i = 0; i < k; i++)
                if (s[k] == s[i])
                    return false;
            return true;
        }

        private bool solutie(int k)
        {
            if (k == (n- 1))
                return true;
            return false;
        }

        public void back(int k)
        {
            for (int val = 1; val <= n; val++)
            {
                s[k] = val;

                if (valid(k))
                {
                    if (solutie(k))
                    {
                        tipar();
                    }

                    else
                    {
                        back(k+1);
                    }
                }
            }
        }
    }
}
