using Accord.MachineLearning;
using Accord.Math.Distances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    public class Clustering
    {
        List<List<int>> Clusters;

        public Clustering(int[][] distanceMatrix, int k)
        {
            var dist = new VertexDistance(distanceMatrix);

            Clusters = KMeansCluster(distanceMatrix.Length, dist, k);

        }

        protected List<List<int>> KMeansCluster(int n, IDistance distance, int k)
        {
            List<List<int>> results = new List<List<int>>();

            double[][] vertices = new double[n][];

            for (int i = 0; i < n; i++)
            {
                double[] vertex = new double[1];
                vertex[0] = i + 1;
                vertices[i] = vertex;
            }

            KMeans kmeans = new KMeans(k)
            {
                Distance = distance
            };

            var clusters = kmeans.Learn(vertices);

            int[] decisions = clusters.Decide(vertices);

            for (int i = 0; i < k; i++)
            {
                List<int> cluster = new List<int>();
                for (int j = 0; j < n; j++)
                {
                    if (decisions[j] == i) cluster.Add(j);
                }
                results.Add(cluster);
            }

            return results;
        }

        public List<List<int>> getClusters()
        {
            return Clusters;
        }

        public void toConsole()
        {
            Clusters.ForEach(item =>
            {
                item.ForEach(Console.Write);
                Console.WriteLine();
            });
        }

    }
}
