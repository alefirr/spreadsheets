using Microsoft.VisualStudio.TestTools.UnitTesting;
using Olena_Spreadsheets;

namespace Tests
{
    [TestClass]
    public class GridTests
    {
        [TestMethod]
        public void Calculate_Method_Calculates_Expression_Correctly()
        {
            string expression = "max(12, -3) + 12 / 2";
            string expectedVal = "18";

            Grid grid = new Grid();

            string result = grid.Calculate(expression);

            Assert.AreEqual(expectedVal, result);
        }

        [TestMethod]
        public void Calculate_Method_Returns_Error_For_Wrong_Expression()
        {
            string expression = "3397&&&99))))lol";
            string expectedVal = "ПОМИЛКА";

            Grid grid = new Grid();

            string result = grid.Calculate(expression);

            Assert.AreEqual(expectedVal, result);
        }

        [TestMethod]
        public void FullName_Methods_Gets_Cell_Name_Correctly()
        {
            Grid grid = new Grid();

            string expectedVal1 = "A0";
            string result1 = grid.FullName(0, 0);

            Assert.AreEqual(expectedVal1, result1);

            string expectedVal2 = "XX200";
            string result2 = grid.FullName(49, 200);

            Assert.AreEqual(expectedVal2, result2);
        }
    }
}
