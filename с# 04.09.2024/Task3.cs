namespace с__04._09._2024
{
    abstract class Figure
    {
        public abstract double CalculateArea();
        public abstract override int GetHashCode();
    }
    class Rectangle : Figure
    {
        public double width { get; set; }
        public double height { get; set; }

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public override double CalculateArea()
        {
            return width * height;
        }
        public override int GetHashCode()
        {
            return width.GetHashCode() ^ height.GetHashCode();
        }
    }
    class Circle : Figure
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
        public override int GetHashCode()
        {
            return Radius.GetHashCode();
        }
    }
    class RightTriangle : Figure
    {
        public double Base { get; set; }
        public double height { get; set; }

        public RightTriangle(double Base, double height)
        {
            this.Base = Base;
            this.height = height;
        }
        public override double CalculateArea()
        {
            return 0.5 * Base * height;
        }
        public override int GetHashCode()
        {
            return Base.GetHashCode() ^ height.GetHashCode();
        }
    }
    class Trapezoid : Figure
    {
        public double base1 { get; set; }
        public double base2 { get; set; }
        public double height { get; set; }

        public Trapezoid(double base1, double base2, double height)
        {
            this.base1 = base1;
            this.base2 = base2;
            this.height = height;
        }
        public override double CalculateArea()
        {
            return 0.5 * (base1 + base2) * height;
        }
        public override int GetHashCode()
        {
            return base1.GetHashCode() ^ base2.GetHashCode() ^ height.GetHashCode();
        }
    }
}
