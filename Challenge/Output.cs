using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    class Output
    {

    public static void toConsole(List<List<int>> clusters, double modularity)
    {
            Console.WriteLine(modularity);
            Console.WriteLine(clusters.Count);
            foreach (List<int> community in clusters)
            {
                Console.WriteLine(community.Count);
                foreach (int vertex in community)
                {
                    Console.Write(vertex + " ");
                }
                Console.WriteLine();
            }
    }

    }
}
