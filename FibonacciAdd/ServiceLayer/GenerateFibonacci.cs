using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciAdd.ServiceLayer
{
    public class GenerateFibonacci : IGenerateFibonacci
    {
        public GenerateFibonacci()
        { }

        public int[] GenerateArray(int maximumValue)
        {
            int i = 0;
            List<int> listNumbers = new List<int>();
            listNumbers.Add(i);
            i = 1;
            while (i < maximumValue)
            {
                listNumbers.Add(i);
                i = listNumbers[listNumbers.Count - 1] + listNumbers[listNumbers.Count - 2];
            }

            int[] fibonacci = listNumbers.ToArray<int>();
            return fibonacci;

        }

        public List<int> GenerateList(int maximumValue)
        {
            int i = 0;
            List<int> listNumbers = new List<int>();
            listNumbers.Add(i);
            i = 1;
            while (i < maximumValue)
            {
                listNumbers.Add(i);
                i = listNumbers[listNumbers.Count - 1] + listNumbers[listNumbers.Count - 2];
            }

            return listNumbers;



        }

        public int SumArrayEven(int[] inputArray)

        {
            int i = (from x in inputArray 
                     where x % 2 == 0 
                     select x).Sum();
                
                return i;
        }

        public int SumListEven(List<int> inputList)
        {
            int i = (from x in inputList
                     where x % 2 == 0
                     select x).Sum() ;
            return i;
        }
    }
}
