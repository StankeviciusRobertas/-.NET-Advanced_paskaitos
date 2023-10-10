namespace _4.Abstract_uzduotys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Square square = new Square(2);

            Triangle triangle1 = new Triangle(5, 10, 7);
            Square square1 = new Square(5);

            Triangle triangle2 = new Triangle(2, 4, 8);
            Square square2 = new Square(10);

            Triangle triangle3 = new Triangle(8, 14, 15);
            Square square3 = new Square(12);

            List<GeometricShape> geometricShapes = new List<GeometricShape>();

            geometricShapes.Add(triangle);
            geometricShapes.Add(triangle1);
            geometricShapes.Add(triangle2);
            geometricShapes.Add(triangle3);

            geometricShapes.Add(square);
            geometricShapes.Add(square1);
            geometricShapes.Add(square2);
            geometricShapes.Add(square3);

            foreach (var shape in geometricShapes)
            {
                if (shape is Triangle)
                {                    
                    Console.WriteLine($"Trikampio Perimetras: {shape.GetPerimeter()}");
                    Console.WriteLine($"Trikampio Plotas: {shape.GetArea()}");
                    Console.WriteLine("================");
                }
                else
                {
                    Console.WriteLine($"Trikampio Perimetras: {shape.GetPerimeter()}");
                    Console.WriteLine($"Trikampio Plotas: {shape.GetArea()}");
                    Console.WriteLine("================");
                }
                
            }

            //Console.WriteLine($"Triangle Area: {triangle.GetArea()}");
            //Console.WriteLine($"Triangle Perimeter: {triangle.GetPerimeter()}");

            //Console.WriteLine($"Square Area: {square.GetArea()}");
            //Console.WriteLine($"Square Perimeter: {square.GetPerimeter()}");

            Console.WriteLine("=================================================");

            //Dog dog = new Dog("Barklis");
            //Cat cat = new Cat("Tomas");

            //Console.WriteLine($"Suns garsas: {dog.MakeNoise()}");
            //Console.WriteLine($"Kates garsas: {cat.MakeNoise()}");
        }
    }
}