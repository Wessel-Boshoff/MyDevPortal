using OOPProject.Common.Enums;

namespace OOPProject.Tests
{
    [TestClass]
    public class TriangleTests : BaseTests
    {
        [TestMethod]
        public void AreaTest()
        {
            //Arrange
            Calculation calculation = Calculation.Area;
            Shape shape = Shape.Triangle;
            double[] inputs =
            {
                10,
                20,
                30
            };

            //Act
            var result = RunCalculationTest(calculation, shape, inputs);

            //Assert
            Assert.IsFalse(result.Item1 == 0);
            Assert.IsFalse(result.Item2 > MaxTimeInMiliseconds);
        }

        [TestMethod]
        public void CircumferenceTest()
        {
            //Arrange
            Calculation calculation = Calculation.Circumference;
            Shape shape = Shape.Triangle;
            double[] inputs =
            {
                10,
                20,
                30
            };

            //Act
            var result = RunCalculationTest(calculation, shape, inputs);

            //Assert
            Assert.IsFalse(result.Item1 == 0);
            Assert.IsFalse(result.Item2 > MaxTimeInMiliseconds);
        }
    }
}
