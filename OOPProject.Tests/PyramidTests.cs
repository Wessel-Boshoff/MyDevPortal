using OOPProject.Common.Enums;

namespace OOPProject.Tests
{
    [TestClass]
    public class PyramidTests : BaseTests
    {
        [TestMethod]
        public void AreaTest()
        {
            //Arrange
            Calculation calculation = Calculation.Area;
            Shape shape = Shape.Pyramid;
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
        public void VolumeTest()
        {
            //Arrange
            Calculation calculation = Calculation.Volume;
            Shape shape = Shape.Pyramid;
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
