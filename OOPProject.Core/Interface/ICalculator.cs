using OOPProject.Calculations.Results;
using OOPProject.Common.Enums;

namespace OOPProject.Calculations.Interface
{
    public interface ICalculator
    {
        CalculationResult Calculate(Shape shape, Calculation calculationType, params double[] inputs);
    }
}
