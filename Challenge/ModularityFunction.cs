using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    public class ModularityFunction
    {
        public static double Rating(int m, int[][] A, List<List<int>> P)
        {
            int n = A.Length;

            int[] N;
            N = nullGraph(A); //null graph
            int i;
            int j;
            int k;
            int sizeP;
            double M = 0;

            sizeP = (int)P.LongCount();
            for (k = 0; k <= sizeP - 1; k++)
            {
                for (i = 0; i < P[k].Count; i++)
                {

                    for (j = 0; j < P[k].Count; j++)
                    {
                        M += A[i][j] - ((double)(N[i] * N[j]) / (2 * m));
                    }
                }
            }

            M /= (2 * m);

            return M;
        }

        static int[] nullGraph(int[][] A)
        {
            int n = A.GetLength(0);
            int[] N = new int[n];
            for (int i = 0; i < n; i++)
            {
                N[i] = 0;
                for (int j = 0; j < n; j++)
                {
                    N[i] = N[i] + A[i][j];
                }
            }
            return N;
        }

    }
}
