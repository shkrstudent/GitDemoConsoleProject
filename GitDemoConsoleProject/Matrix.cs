using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitDemoConsoleProject
{
    public class Matrix
    {
        public static int[,] Generate(int n, int m)
        { 
            Random random = new Random();
            int[,] matrix = new int[n, m];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = random.Next(0, 100);
                }
            return matrix;

        }
        
    }
}
