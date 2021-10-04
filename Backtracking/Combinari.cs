using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Backtracking
{
    /*
     * Realizati combinari astfel incat primul element sa fie patrat perfect
     */

    class Combinari
    {
        private int[] s;
        private int n, m;

        public Combinari(int n, int m)
        {
            this.n = n;
            this.m = m;
            s = new int[n];

            back(0);
        }

        private void tipar()
        {
            for (int i = 0; i < m; i++) 
            {
                Write(s[i] + " ");
            }
            WriteLine();
        }

        private bool valid(int k)
        {
            if (k == 0 && pp(s[k]) == false) 
            {
                return false;
            }

            for (int i = 0; i < k; i++) 
            {
                if (s[i] >= s[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        private bool solutie(int k)
        {
            if (k == m - 1) 
            {
                return true;
            }
            return false;
        }

        private void back(int k)
        {
            for (int val = 1; val <= n; val++) 
            {
                s[k] = val;
                if(valid(k))
                {
                    if(solutie(k))
                    {
                        tipar();
                    }
                    else
                    {
                        back(k + 1);
                    }
                }
            }
        }

        private bool pp(int nr)
        {
            return Math.Sqrt(nr) == ((int)Math.Sqrt(nr));
        }
    }
}
