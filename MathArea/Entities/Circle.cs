using MathArea.Interface;

namespace MathArea.Entities
{
    public class Circle : Figure
    {
        public double Radius { get; set; }

        public Circle(double radius) : base(radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            var area = Math.PI * Math.Pow(Radius, 2);
            return Math.Round(area, 2);
        }
    }
}
