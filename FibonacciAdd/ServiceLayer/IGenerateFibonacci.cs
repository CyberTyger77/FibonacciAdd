using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciAdd.ServiceLayer
{
    interface IGenerateFibonacci
    {
        int[] GenerateArray(int maximumValue);
        int SumArrayEven(int[] arrayInt);
    }
}
