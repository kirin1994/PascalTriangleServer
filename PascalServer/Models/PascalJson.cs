using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PascalServer.Models
{
    public class PascalJson
    {
        public List<PascalRow> TriangleRows { get; private set; }

        public PascalJson(long[,] pascalTriangleTable, int tableLength, int modulo = 0)
        {
            TriangleRows = new List<PascalRow>();
            BuildTriangle(pascalTriangleTable, tableLength, modulo);
        }

        private void BuildTriangle(long[,] pascalTriangleTable, int tableLength, int modulo = 0)
        {
            for (int i = 0; i < tableLength; i++)
            {
                var row = new PascalRow();
                for (int j = 0; j < tableLength; j++)
                {
                    row.AddNumberToRow(pascalTriangleTable[i, j], modulo);
                }

                TriangleRows.Add(row);
            }
        }
    }
}

