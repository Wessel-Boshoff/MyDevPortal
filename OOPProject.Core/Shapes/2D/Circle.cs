using OOPProject.Calculations.Interface;

namespace Shapes
{
    class Circle : I2D
    {
        public double Area(params double[] inputs)=>
            (2 * Math.PI * inputs[0]);

        public double Circumference(params double[] inputs) =>
            2 * Math.PI * inputs[0];
    }
}
