using OOPProject.Calculations.Interface;

namespace Shapes
{
    class Cube : I3D
    {
        public double Area(params double[] inputs)
        {
            return (6 * (inputs[0] * inputs[0]));
        }

        public double Volume(params double[] inputs)
        {
            return (inputs[0] * inputs[0] * inputs[0]);
        }
    }
}
