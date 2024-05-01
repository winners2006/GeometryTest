namespace GeometryTest
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Круг

			double radius = 5;
			Circle circle = new Circle(radius);
			Console.WriteLine($"Площадь круга с радиусом {radius} равна {circle.GetArea()}");

			// Ттеугольник
			double sideA = 3;
			double sideB = 4;
			double sideC = 5;
			Triangle triangle = new Triangle(sideA, sideB, sideC);
			Console.WriteLine($"Площадь треугольника со сторонами {sideA}, {sideB} и {sideC} равна {triangle.GetArea()}");
			if (triangle.IsRightTriangle())	
				Console.WriteLine("Треугольник является прямоугольным.");
			else 
				Console.WriteLine("Треугольник не является прямоугольным.");
			
		}
	}
}
