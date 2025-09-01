using OOPProject.Calculations.Interface;

namespace Shapes
{
    class Sphere : I3D
    {
        public double Area(params double[] inputs)
        {
            return (4 * Math.PI * (inputs[0] * inputs[0]));
        }

        public double Volume(params double[] inputs)
        {
            return Math.PI * Math.Pow(inputs[0], 3) * 4 / 3;

        }
    }
}
