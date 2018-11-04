using System.Collections.Generic;
using System.Diagnostics;

namespace PascalServer.Models
{
    public class PascalRow
    {
        static int rowNumber = 0;
        int valueNumber = 0;
        public List<double> ValuesOfCalculation { get; private set; }
        public PascalRow()
        {
            rowNumber++;
            ValuesOfCalculation = new List<double>();
        }

        public void AddNumberToRow(double value, double modulo = 0)
        {
            if (valueNumber == 20 && rowNumber == 63)
            {
                Debug.WriteLine(value);
            }

            if (modulo != 0)
            {
                valueNumber++;
                ValuesOfCalculation.Add(value);
            }
        
        }

    }
}
