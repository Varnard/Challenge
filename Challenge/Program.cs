using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            a.Add(1);
            a.Add(2);
            a.Add(3);

            List<int> b = new List<int>();
            b.Add(4);
            b.Add(5);

            List<List<int>> clusters = new List<List<int>>();

            clusters.Add(a);
            clusters.Add(b);

            Output.toConsole(clusters, 0.357);

            Console.ReadKey();
        }
    }
}
