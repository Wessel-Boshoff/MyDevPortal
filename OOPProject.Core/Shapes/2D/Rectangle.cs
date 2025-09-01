using OOPProject.Calculations.Interface;

namespace Shapes
{
    class Rectangle : I2D
    {
        public virtual double Area(params double[] inputs) =>
             ((inputs[0] * inputs[1]));

        public virtual double Circumference(params double[] inputs) =>
            (2 * (inputs[0] + inputs[1]));
    }
}
