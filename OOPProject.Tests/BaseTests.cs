using OOPProject.Calculations;
using OOPProject.Common.Enums;
using System.Diagnostics;

namespace OOPProject.Tests
{
    public class BaseTests
    {
        private readonly Calculator calculator;
        private int Times { get; set; } = 500000;
        public decimal MaxTimeInMiliseconds { get; set; } = 5000;
        public BaseTests()
        {
            calculator = new Calculator();
        }

        internal Tuple<double, decimal> RunCalculationTest(Calculation calculation, Shape shape, params double[] inputs)
        {
            double result = default;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < Times; i++)
            {
                var calculationResult = calculator.Calculate(shape, calculation, inputs);
                if (!calculationResult.Success)
                {
                    throw new Exception(calculationResult.ErrorsDisplay);
                }
                result = calculationResult.Result;
            }
            sw.Stop();
            return new Tuple<double, decimal>(result, sw.ElapsedMilliseconds);
        }
    }
}
