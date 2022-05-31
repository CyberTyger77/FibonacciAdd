using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FibonacciAdd.ServiceLayer;

namespace FibonacciAdd
{
    class Program
    {
        static IGenerateFibonacci _generateFibonacci;
        public Program(IGenerateFibonacci generateFibonacci)
        {
            _generateFibonacci = generateFibonacci;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            if (_generateFibonacci == null)
                _generateFibonacci = new GenerateFibonacci();
            int i =  _generateFibonacci.SumArrayEven(_generateFibonacci.GenerateArray(1000000));
            Console.Write(i);
        }
    }
}
