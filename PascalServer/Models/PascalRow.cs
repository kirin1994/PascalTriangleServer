using System.Collections.Generic;
using System.Diagnostics;

namespace PascalServer.Models
{
    public class PascalRow
    {
        static int counter = 0;
        int counter2 = 0;
        public List<double> ValuesOfCalculation { get; private set; }
        public PascalRow()
        {
            counter++;
            ValuesOfCalculation = new List<double>();
        }

        public void AddNumberToRow(double value, double modulo = 0)
        {
            if (counter2 == 20 && counter == 63)
            {
                Debug.WriteLine(value);
            }

            if (modulo != 0)

                counter2++;
            ValuesOfCalculation.Add(value);
            return;
        
        }

    }
}
