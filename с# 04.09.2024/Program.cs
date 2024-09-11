namespace с__04._09._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1
            Product product = new Product("Чайник", "Отдел бытовой техники", 200);
            Toy toy = new Toy("Конструктор LEGO", "Магазин детских игрушек", 600, "3+", "Одесса");

            toy.Info();
            Console.WriteLine($"GetHashCode: {toy.GetHashCode()}");
            Console.WriteLine();
            Console.ReadKey();

            //Task2 
            Tiger tiger = new Tiger(60, "Анатолий", 5);
            Crocodile crocodile = new Crocodile(18, "Гена", 52);
            Kangaroo kangaroo = new Kangaroo(20, "Гриша", 2);

            tiger.Info();
            Console.WriteLine($"GetHashCode: {tiger.GetHashCode()}");
            Console.WriteLine();

            crocodile.Info();
            Console.WriteLine($"GetHashCode {crocodile.GetHashCode()}");
            Console.WriteLine();

            kangaroo.Info();
            Console.WriteLine($"GetHashCode: {kangaroo.GetHashCode()}");
            Console.WriteLine();
            Console.ReadKey();

            //Task3
            Figure[] figures = new Figure[]
            {
                new Rectangle(5, 10),
                new Circle(7),
                new RightTriangle(3, 4),
                new Trapezoid(3, 5, 4)
            };

            foreach (var figure in figures)
            {
                Console.WriteLine($"Площадь фигуры: {figure.CalculateArea()}, GetHashCode: {figure.GetHashCode()}");
                Console.WriteLine();
                Console.ReadKey();
            }

        }
    }
}