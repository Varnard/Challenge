using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    class Input
    {
        int m;
        int n;
        int[][] adjM;


        public void read(string filename)
        {           
            string[] lines = System.IO.File.ReadAllLines(@"D:\Varn\Documents\Visual Studio 2015\Projects\Challenge\Challenge\" + filename);

            int[][] array = lines.Where(line => !String.IsNullOrWhiteSpace(line)) // Use this to filter blank lines.
                .Select(line => line.Split((string[])null, StringSplitOptions.RemoveEmptyEntries))
                .Select(line => line.Select(element => int.Parse(element)))
                .Select(line => line.ToArray())
                .ToArray();

            m = array[0][0];
            n = array[1][0];
            adjM = new int[n][];

            int i, j;

            for (int k = 0; k < n-1; k++)
            {
                adjM[k] = new int[n];
                i = array[2][k];
                j= array[2][k+1];

                for (int l=i-1; l<j-1; l++)
                {
                    adjM[k][array[3][l] - 1] = 1;
                }
            }
            adjM[n-1] = new int[n];
            i = array[2][n-1];
            j = array[2][n];

            for (int l = i - 1; l < j - 1; l++)
            {
                adjM[n - 1][array[3][l] - 1] = 1;
            }

        }

        public int getM()
        {
            return m;
        }

        public int getN()
        {
            return n;
        }

        public int[][] getAdjMatrix() {
            return adjM;
        }

    }
}
