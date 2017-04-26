using Accord.Math.Distances;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge
{
    public class VertexDistance : IDistance
    {
        int[][] distanceMatrix { get; set; }

        public VertexDistance(int[][] distanceMatrix)
        {
            this.distanceMatrix = distanceMatrix;
        }

        public double Distance(double[] x, double[] y)
        {
            return (double)distanceMatrix[(int)x[0]-1][(int)y[0]-1];
        }
    }
}
