using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PascalServer.Models
{
    public class PascalRow
    {
        static int counter = 0;
        public List<long> ValuesOfCalculation { get; private set; }
        public PascalRow()
        {
            counter++;
            ValuesOfCalculation = new List<long>();
        }

        public void AddNumberToRow(long value, long modulo = 0)
        {
            if (value == 0)
            {
                return;
            }

            if (modulo != 0)
            {
                ValuesOfCalculation.Add(value % modulo);
                return;
            }

            ValuesOfCalculation.Add(value);
        }

    }
}
