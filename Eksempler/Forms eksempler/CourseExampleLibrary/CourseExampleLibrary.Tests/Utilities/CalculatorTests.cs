using CourseExampleLibrary.Utilities;

namespace CourseExampleLibrary.Tests.Utilities
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Add_2Plus2_Returns4()
        {
            // ARRANGE
            // sut = SubjectUnderTest
            var sut = new Calculator();
            const double expectedResult = 4;

            // ACT
            var result = sut.Add(2, 2);

            // ASSERT
            Assert.IsTrue(result == expectedResult);
        }

        [TestMethod]
        public void Add_2PlusMinus4_ReturnsMinus2()
        {
            // ARRANGE
            // sut = SubjectUnderTest
            var sut = new Calculator();
            const double expectedResult = -2;

            // ACT
            var result = sut.Add(2, -4);

            // ASSERT
            Assert.IsTrue(result == expectedResult);
        }

        [TestMethod]
        public void Add_3MultipliedWith3_Returns9()
        {
            // ARRANGE
            // sut = SubjectUnderTest
            var sut = new Calculator();
            const double expectedResult = 9;

            // ACT
            var result = sut.Multiply(3, 3);

            // ASSERT
            Assert.IsTrue(result == expectedResult, "Multiply 3 with 3 did not return 9");
        }
    }
}
