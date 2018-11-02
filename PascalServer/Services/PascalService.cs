using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PascalServer.Services
{
    public class PascalService
    {
        public static long[,] CalculatePascalTriangle(int numberOfIterations)
        {
            var iterationNumber = numberOfIterations;
            long[,] pascalValues = new long[iterationNumber, iterationNumber];
            pascalValues[0, 0] = 1;

            for (var i = 1; i <= iterationNumber - 1; i++)
            {
                for (var j = 0; j <= i && j < iterationNumber; j++)
                {
                    if (j == 0)
                    {
                        pascalValues[i, j] = pascalValues[i - 1, j];
                        Console.Write(pascalValues[i, j] + "  ");
                        continue;
                    }

                    pascalValues[i, j] = pascalValues[i - 1, j - 1] + pascalValues[i - 1, j];
                }
            }

            return pascalValues;
        }
    }
}
