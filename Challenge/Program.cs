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
            int[][] adjM = {
                new int[] { 0, 1, 1, 0, 0, 0 },
                new int[] { 1, 0, 1, 0, 0, 0 },
                new int[] { 1, 1, 0, 1, 0, 0 },
                new int[] { 0, 0, 1, 0, 1, 1 },
                new int[] { 0, 0, 0, 1, 0, 1 },
                new int[] { 0, 0, 0, 1, 1, 0 }
            };

            int k = 2;
            int m = 7;

            var distM = DistanceMatrix.compute(adjM);

            Clustering clusters = new Clustering(distM, k);

            var score = ModularityFunction.Rating(m, adjM, clusters.getClusters());

            Output.toConsole(clusters.getClusters(), score);

            Console.ReadKey();
        }
    }
}
