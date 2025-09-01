using OOPProject.Calculations.Interface;

namespace Shapes
{
    class Triangle : I2D
    {
        public double Area(params double[] inputs) =>
            ((inputs[0] / 2) * inputs[1]);

        public double Circumference(params double[] inputs) =>
            (inputs[0] + inputs[1] + inputs[2]);
    }
}
