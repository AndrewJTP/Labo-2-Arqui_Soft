using System;

namespace labo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape Square1 = new Square(5);
            Square Square2 = new Square(4);
            IPolygon Square3 = new Square(7);
            Circle Circle1 =new Circle(3);
            IPolygon Triangle1= new Triangle(3,4);
            Console.WriteLine(Square1.Area());
            Console.WriteLine(Square2.Area());
            Console.WriteLine(Square3.NumeroLados());
            Console.WriteLine(Circle1.Area());
            Console.WriteLine(Triangle1.NumeroLados());
        }
    }
}
