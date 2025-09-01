using OOPProject.Calculations.Interface;

namespace Shapes
{
    class RectangularPrisim : I3D
    {
        public double Area(params double[] inputs)
        {
            return 2 * (inputs[0] * inputs[1] + inputs[0] * inputs[2] + inputs[1] * inputs[2]);
        }

        public double Volume(params double[] inputs)
        {
            return inputs[0] * inputs[1] * inputs[2];
        }
    }
}
