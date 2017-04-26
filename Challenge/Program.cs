using Accord.MachineLearning;
using Accord.Math.Distances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Challenge
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[][] distM = {
                new int[] { 0, 1, 1, 2, 3, 3 },
                new int[] { 1, 0, 1, 2, 3, 3 },
                new int[] { 1, 1, 0, 1, 2, 2 },
                new int[] { 2, 2, 1, 0, 1, 1 },
                new int[] { 3, 3, 2, 1, 0, 1 },
                new int[] { 3, 3, 2, 1, 1, 0 }
            };

            int k = 2;

            Clustering clusters = new Clustering(distM, k);

            clusters.toConsole();

            Console.ReadKey();
        }
    }
}
