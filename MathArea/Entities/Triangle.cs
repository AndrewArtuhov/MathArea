using MathArea.Interface;

namespace MathArea.Entities
{
    public class Triangle : Figure
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double a, double b, double c) : base(a, b, c)
        {      
            SideA = a;
            SideB = b;
            SideC = c;
        }

        public override double GetArea()
        {
            double semPer = (SideA + SideB + SideC) / 2;
            var area = Math.Sqrt(semPer * (semPer - SideA) * (semPer - SideB) * (semPer - SideC));
            return Math.Round(area, 2);
        }

        public bool IsRight()
        {
            var sides = new List<double> { SideA, SideB, SideC };
            sides.Sort();
            var hypotenuse = sides[2];
            return Math.Pow(hypotenuse, 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
        }
    }
}
