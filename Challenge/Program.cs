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
            var input = new Input();

            Console.WriteLine("Reading File...");
            input.read("TEST7834.txt");
            Console.Clear();

            int m = input.getM();
            int n = input.getN();
            int[][] adjM = input.getAdjMatrix();

            Console.WriteLine("Computing Distance Matrix...");
            var distM = DistanceMatrix.compute(adjM);
            Console.Clear();

            double bestScore=0;
            List<List<int>> bestClusters = new List<List<int>>();

            int t = 20;

            
            for (int k = 1; k <= n; k++)
            {
                for (int i = 0; i < t; i++)
                {
                    var clusters = new Clustering(distM, k).getClusters();

                    var score = ModularityFunction.Rating(m, adjM, clusters);

                    if (score>bestScore)
                    {
                        bestScore = score;
                        bestClusters = clusters;
                    }
                    Console.Clear();
                    Console.Write("Clustering: "+Math.Round(((double)(k-1) * t + i)*100 / ((double)n * t ),1)+ "%");
                }

            }

            Console.Clear();
            Output.toConsole(bestClusters, bestScore);

            Console.ReadKey();
        }
    }
}
