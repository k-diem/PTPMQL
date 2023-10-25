using System;

namespace DemoMVC.Models
{
    public class QuadraticEquationModel
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double Discriminant { get; set; }
        public double Root1 { get; set; }
        public double Root2 { get; set; }

        public void Solve()
        {
            Discriminant = B * B - 4 * A * C;
            if (Discriminant > 0)
            {
                Root1 = (-B + Math.Sqrt(Discriminant)) / (2 * A);
                Root2 = (-B - Math.Sqrt(Discriminant)) / (2 * A);
            }
            else if (Discriminant == 0)
            {
                Root1 = Root2 = -B / (2 * A);
            }
            else
            {
                Root1 = Root2 = double.NaN; // No real roots
            }
        }
    }
}
