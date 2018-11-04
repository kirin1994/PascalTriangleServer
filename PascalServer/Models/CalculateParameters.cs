using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PascalServer.Models
{
    public class CalculateParameters
    {
        [Required]
        [Range(1, 10)]
        public double Modulo { get; set; }
        [Required]
        [Range(1, 75)]
        public int NumberOfIterations { get; set; }
    }
}
