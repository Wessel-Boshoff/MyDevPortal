using OOPProject.Calculations.Interface;

namespace Shapes
{
    class Cone : I3D
    {
        public double Area(params double[] inputs)
        {
            double length = Math.Sqrt((inputs[1] * inputs[1]) + (inputs[0] * inputs[0]));
            return ((Math.PI * (inputs[0] * inputs[0])) + (Math.PI * inputs[0] * length));
        }

        public double Volume(params double[] inputs)
        {
            return (Math.PI * (inputs[0] * inputs[0]) * (inputs[1] / 3));
        }
    }
}
