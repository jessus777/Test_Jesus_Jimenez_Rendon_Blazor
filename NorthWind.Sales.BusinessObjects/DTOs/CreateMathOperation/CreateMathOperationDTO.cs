using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Sales.BusinessObjects.DTOs.CreateMathOperation
{
    public class CreateMathOperationDTO
    {
        public int MathOperationType { get; set; }
        public decimal NumberOne { get; set; }
        public decimal NumberTwo { get; set; }
    }
}
