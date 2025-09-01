using OOPProject.Calculations.Interface;

namespace Shapes
{
    class Square : I2D
    {
        public virtual double Area(params double[] inputs) =>
            (inputs[0] * inputs[0]);

        public virtual double Circumference(params double[] inputs) =>
            (2 * (inputs[0] + inputs[0]));
    }
}
