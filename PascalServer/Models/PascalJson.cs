using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PascalServer.Models
{
    public class PascalJson
    {
        public List<PascalRow> TriangleRows { get; private set; }

        public PascalJson(double[,] pascalTriangleTable, int tableLength, double modulo = 0)
        {
            TriangleRows = new List<PascalRow>();
            BuildTriangle(pascalTriangleTable, tableLength, modulo);
        }

        private void BuildTriangle(double[,] pascalTriangleTable, int tableLength, double modulo = 0)
        {
            for (int columnNumber = 0; columnNumber < tableLength; columnNumber++)
            {
                var row = new PascalRow();
                for (int rowNumber = 0; rowNumber < tableLength; rowNumber++)
                {
                    if(rowNumber <= columnNumber)
                    row.AddNumberToRow(pascalTriangleTable[columnNumber, rowNumber], modulo);
                }

                TriangleRows.Add(row);
            }
        }
    }
}

