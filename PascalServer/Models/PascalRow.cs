using System.Collections.Generic;

namespace PascalServer.Models
{
    public class PascalRow
    {
        static int counter = 0;
        public List<double> ValuesOfCalculation { get; private set; }
        public PascalRow()
        {
            counter++;
            ValuesOfCalculation = new List<double>();
        }

        public void AddNumberToRow(double value, long modulo = 0)
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
