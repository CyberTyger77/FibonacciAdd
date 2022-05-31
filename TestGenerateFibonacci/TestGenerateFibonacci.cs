using Microsoft.VisualStudio.TestTools.UnitTesting;
using FibonacciAdd.ServiceLayer;

namespace TestGenerateFibonacci
{
    [TestClass]
    public class TestGenerateFibonacci
    {
        #region Generate Array
        [TestMethod]
        public void GivenGenerate_WhenZeroMaximum_ReturnZero()
        {
            //Arrange
            GenerateFibonacci _test = new GenerateFibonacci();

            //Act
            int[] result =  _test.GenerateArray(0);


            // Assert 
            int[] expectedResult = new int[1] { 0 };
            Assert.AreEqual(expectedResult.Length, result.Length);
            Assert.AreEqual(expectedResult[0], result[0]);
        }


        [TestMethod]
        public void GivenGenerate_When10Maximum_ReturnValidFibArray()
        {
            //Tests by explicit comparison
            //Arrange
            GenerateFibonacci _test = new GenerateFibonacci();

            //Act
            int[] result = _test.GenerateArray(10);


            // Assert 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144...
            int[] expectedResult = new int[7] { 0, 1, 1, 2, 3, 5, 8 };
            Assert.AreEqual(expectedResult.Length, result.Length);

            for (int i = 0; i > result.Length; i++)
                Assert.AreEqual(expectedResult[i], result[i]);
        }


        [TestMethod]
        public void GivenGenerate_When150Maximum_ReturnValidFibArray()
        {
            // Tests by checking each element is the product of previous 2 items
            //Arrange
            GenerateFibonacci _test = new GenerateFibonacci();

            //Act
            int[] result = _test.GenerateArray(150);


            // Assert 
            for (int i = result.Length; i > 2; i--)
            {
                Assert.AreEqual(result[i - 3] + result[i-2], result[i -1]);
            }
        }

        #endregion

        #region SumArrayEven
        [TestMethod]
        public void GivenAnyArray_WhenEven_ThenReturnEvenTotal()
        {
            //Arrange
            GenerateFibonacci _test = new GenerateFibonacci();

            //Act
            int[] inputArray = new int[7] { 0, 1, 1, 2, 3, 5, 8 };
            int result = _test.SumArrayEven(inputArray);

            //Assert
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void GivenAnyArray_WhenNoEven_ThenReturnZero()
        {
            //Arrange
            GenerateFibonacci _test = new GenerateFibonacci();

            //Act
            int[] inputArray = new int[7] { 3, 1, 13, 9, 3, 5, 81 };
            int result = _test.SumArrayEven(inputArray);

            //Assert
            Assert.AreEqual(0, result);
        }



        #endregion
    }
}
