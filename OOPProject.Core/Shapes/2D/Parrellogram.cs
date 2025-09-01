using OOPProject.Calculations.Interface;

namespace Shapes
{
    class Parrellogram : Rectangle, I2D
    {
        public override double Area(params double[] inputs) =>
            base.Area(inputs);

        public override double Circumference(params double[] inputs) =>
            base.Circumference(inputs);
    }
}
