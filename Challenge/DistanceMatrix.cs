using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    public class DistanceMatrix
    {
        static int maxValue = 99999999;

        public static int[][] compute(int[][] adjacencyMatrix)
        {
            int size = adjacencyMatrix.Length;
            int[][] dist = new int[size][];
            int[][] cost = new int[size][];

            for (int i = 0; i < size; i++)
            {
                dist[i] = new int[size];
                cost[i] = new int[size];

                for (int j = 0; j < size; j++)
                {
                    if (i != j && adjacencyMatrix[i][j] == 0)
                    {
                        cost[i][j] = maxValue;
                    }
                    else
                    {
                        cost[i][j] = adjacencyMatrix[i][j];
                    }
                }
            }


            for (int i = 0; i < size; i++)
            {
                for (int j = i; j < size; j++)
                {
                    if (i == j)
                    {
                        dist[i][j] = 0;
                    }
                    else if (adjacencyMatrix[i][j] == 1)
                    {
                        dist[j][i] = dist[i][j] = 1;
                    }
                    //Compute shortest distance between i and j
                    else
                    {
                        //Console.WriteLine(i + " " + j);
                        dist[j][i] = dist[i][j] = dijkstra(cost, i, j);
                    }
                }
            }

            return dist;
        }

        static int dijkstra(int[][] cost, int source, int target)
        {
            int size = cost.Length;
            int start;
            int[] dist = new int[size];
            int[] prev = new int[size];
            int[] selected = new int[size];

            //Initialize dijkstra's algorithm parameters

            for (int i = 0; i < size; i++)
            {
                dist[i] = maxValue;
                prev[i] = -1;
                selected[i] = 0;
            }

            dist[source] = 0;
            selected[source] = 1;
            start = source;

            //While the target has not been selected, keep on searching
            while (selected[target] == 0)
            {
                int minDistance = maxValue;
                int minPosition = 0;

                for (int i = 1; i < size; i++)
                {
                    int d = dist[start] + cost[start][i];

                    if (selected[i] == 0 && d < dist[i])
                    {
                        dist[i] = d;
                        prev[i] = start;
                    }

                    if (selected[i] == 0 && minDistance > dist[i])
                    {
                        minDistance = dist[i];
                        minPosition = i;
                    }
                }

                start = minPosition;
                selected[start] = 1;
            }

            return dist[target];
        }

    }
}

