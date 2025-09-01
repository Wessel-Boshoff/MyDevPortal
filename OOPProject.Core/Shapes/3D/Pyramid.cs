using OOPProject.Calculations.Interface;

namespace Shapes
{
    class Pyramid : I3D
    {
        public double Area(params double[] inputs)
        {
            double baseSurfaceArea = Math.Pow(inputs[0], 2);
            double lateralSurfaceArea = 2 * inputs[0] * Math.Sqrt(Math.Pow(inputs[0] / 2, 2) + Math.Pow(inputs[1], 2));
            return baseSurfaceArea + lateralSurfaceArea;
        }

        public double Volume(params double[] inputs)
        {
            double x = Math.Pow(inputs[0], 2) / 3;
            double y = x * inputs[1];
            return y;
        }
    }
}
