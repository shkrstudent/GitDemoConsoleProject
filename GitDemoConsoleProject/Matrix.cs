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
            int[,] matrix = new int[n, m];
            Random random = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = random.Next(-100, 100);
                }
            return matrix;

        }
        
    }
}
