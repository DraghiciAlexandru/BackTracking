using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Backtracking
{
    /*
     * Sa se afiseze aranjamente de n luate cate m unde primul element este diferit de t citit
     * 1 2 3 4
     *  n = 4, m = 2
     *  
     * 1 2 | 4 3 X
     * 1 3 | 2 4 ok
     * 
     */

    class Aranjamente
    {
        private int[] s;
        private int n, m, t;

        public Aranjamente(int n, int m)
        {
            this.n = n;
            this.m = m;

            WriteLine("T:");

            t = int.Parse(ReadLine());

            back(0);
        }

        public Aranjamente(int n, int m, int t)
        {
            this.n = n;
            s = new int[n];
            this.m = m;
            this.t = t;
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
            if (k == 0 && s[k] == t)
            {
                return false;
            }

            for (int i = 0; i < k; i++)
            {
                if (s[k] == s[i])
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
            else
            {
                return false;
            }
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
    }
}
