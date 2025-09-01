using OOPProject.Common.Enums;

namespace OOPProject.Tests
{
    [TestClass]
    public class RectangleTests : BaseTests
    {
        [TestMethod]
        public void AreaTest()
        {
            //Arrange
            Calculation calculation = Calculation.Area;
            Shape shape = Shape.Rectangle;
            double[] inputs =
            {
                10,
                5
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
            Shape shape = Shape.Rectangle;
            double[] inputs =
            {
                10,
                5
            };

            //Act
            var result = RunCalculationTest(calculation, shape, inputs);

            //Assert
            Assert.IsFalse(result.Item1 == 0);
            Assert.IsFalse(result.Item2 > MaxTimeInMiliseconds);
        }
    }
}
