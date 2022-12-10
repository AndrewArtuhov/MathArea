namespace MathArea.Interface
{
    public abstract class Figure : IFigure
    {
        public Figure(params double[] input)
        {
            if (input.Any(x => x <= 0))
                throw new ArgumentException("Все значения должны быть положительные");
        }

        public abstract double GetArea();
    }
}
