using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Backtracking
{
    class ProdusCartezian
    {
        int[] s;
        int n, m, t;
        int[] p, i;

        public ProdusCartezian(int n, int m, int t)
        {
            this.n = n;
            this.m = m;
            this.t = t;
            s = new int[2];
            p = new int[n];
            i = new int[m];

            back(0);
        }

        private void tipar()
        {
            for (int i = 0; i < 2; i++)
            {
                Write(s[i] + " ");
            }
            WriteLine();
        }

        private bool valid(int k)
        {
            if (k == 0 && s[k] % t == 0)
            {
                return false;
            }
            return true;
        }

        private bool solutie(int k)
        {
            if (k == 1) 
            {
                return true;
            }
            return false;
        }

        private void back(int k)
        {
            int j, z;
            if(k==0)
            {
                z = n;
            }
            else
            {
                z = m;
            }

            for (j = 0; j < t; j++) 
            {
                if (k == 0)
                {
                    s[k] = p[j];
                }
                else
                {
                    s[k] = i[j];
                }
                if (valid(k))
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
