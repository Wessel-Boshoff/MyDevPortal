using OOPProject.Calculations.Interface;

namespace Shapes
{
    class Cylinder : I3D
    {
        public double Area(params double[] inputs)
        {
            return (2 * Math.PI * (inputs[0] * inputs[0]) + 2 * Math.PI * inputs[0] * inputs[1]);
        }

        public double Volume(params double[] inputs)
        {
            return Math.PI * Math.Pow(inputs[0], 2) * inputs[1];
        }
    }
}
