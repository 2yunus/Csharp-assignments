using System;
namespace my
{
    abstract class  shape
    {
        public abstract double calc_Area();
        public abstract double calc_Perimeter();

    }
    class Circle : shape
    {
        static readonly double PI = 3.14;
        public double Radius { get; set; }

        public override double calc_Area()
        {
            return 2 * PI * Radius;
        }
        public override double calc_Perimeter()
        {
            return PI * Radius * 2;
        }

        class Rectangle : shape
        {
            public double length { get; set; }
            public double width { get; set; }

            public override double calc_Perimeter()
            {
                return 2 * width + 2 * length;
            }
            public override double calc_Area()
            {
                return length * length;
            }
            class lab3
            {
                static void Main()
                {
                    Circle circle = new Circle();
                    Rectangle rectangle = new Rectangle();
                    Console.WriteLine("enter radius");
                    circle.Radius = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter width");
                    rectangle.width = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("enter length");
                    rectangle.length = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Radius: " + circle.Radius + "\nArea: " + circle.calc_Area());
                    Console.WriteLine("length: " + rectangle.length + "\nwidth: " + rectangle.width + "\n"+ "Area" + rectangle.calc_Area() + "\nperimeter: "+ rectangle.calc_Perimeter());
                }
            }
        }

    }
    


}
