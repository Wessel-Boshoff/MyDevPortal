using Microsoft.CSharp.RuntimeBinder;
using OOPProject.Calculations.Interface;
using OOPProject.Calculations.Results;
using OOPProject.Common.Enums;
using Shapes;

namespace OOPProject.Calculations
{
    public class Calculator : ICalculator
    {
        public CalculationResult Calculate(Shape shape, Calculation calculationType, params double[] inputs)
        {
            CalculationResult result = new();
            try
            {
                result.Result = shape switch
                {
                    Shape.Circle => DoCalculation(new Circle(), calculationType, inputs),
                    Shape.Cone => DoCalculation(new Cone(), calculationType, inputs),
                    Shape.Cube => DoCalculation(new Cube(), calculationType, inputs),
                    Shape.Cylinder => DoCalculation(new Cylinder(), calculationType, inputs),
                    Shape.Parrellogram => DoCalculation(new Parrellogram(), calculationType, inputs),
                    Shape.Pyramid => DoCalculation(new Pyramid(), calculationType, inputs),
                    Shape.Rectangle => DoCalculation(new Rectangle(), calculationType, inputs),
                    Shape.RectangularPrisim => DoCalculation(new RectangularPrisim(), calculationType, inputs),
                    Shape.Rhombus => DoCalculation(new Rhombus(), calculationType, inputs),
                    Shape.Sphere => DoCalculation(new Sphere(), calculationType, inputs),
                    Shape.Square => DoCalculation(new Square(), calculationType, inputs),
                    Shape.Triangle => DoCalculation(new Triangle(), calculationType, inputs),
                    _ => throw new ArgumentOutOfRangeException("Shape not supported"),
                };
            }
            catch (RuntimeBinderException ex)
            {
                result.Errors.Add("Could not find calculation on object.");
            }
            catch (DivideByZeroException ex)
            {
                result.Errors.Add("Cannot divide by zero. Please check your values and try again.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                result.Errors.Add("Arguments was out of range. Please make different selections and try again.");
            }
            catch (Exception ex)
            {
                result.Errors.Add("An unknown error has occurred.");
            }

            return result;
        }

        private double DoCalculation(dynamic instanceObject, Calculation calculationType, params double[] inputs) =>
        calculationType switch
        {
            Calculation.Area => (double)instanceObject.Area(inputs),
            Calculation.Circumference => (double)instanceObject.Circumference(inputs),
            Calculation.Volume => (double)instanceObject.Volume(inputs),
            _ => throw new ArgumentOutOfRangeException("Calculation not supported"),
        };
        
    }
}
