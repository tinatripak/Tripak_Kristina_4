using System;

namespace geometry
{
    /*
        Створити суперклас Геометрична фігура і підкласи Квадрат, Коло, Відрізок.
        За допомогою конструктора задати колір фігури. 
        Визначити довжину відрізків, з яких складається квадрат.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your lenght : ");
            double lenght = double.Parse(Console.ReadLine());
            Console.WriteLine(new string('-', 110));
            Square square = new Square(lenght);;
            Circle circle = new Circle(lenght);
            Console.WriteLine("Lenght of segments of a squre is (squared all lengths are equal) : ");
            Console.WriteLine(square.LengthOfSegments());
            Console.WriteLine(new string('-', 110));
            Console.Write("Select “1” if you want, find the length R (r) of the circle when the circle is squared, and “2” if you want, find the length R (r) of the circle when the square is in the circle : ");
            Console.WriteLine("The lenght is " + circle.LengthOfSegments());
            Console.WriteLine(new string('-', 110));
            Console.WriteLine("Enter your lenght1");
            double lenght1 = double.Parse(Console.ReadLine());
            Console.WriteLine(new string('-', 110));
            Console.Write("If true,lenght is equal,if false, lenght is equal : ");
            Console.WriteLine(lenght1.Equals(lenght));
            Console.WriteLine(new string('-', 110));
            GeometricFigure color1 = new Square();
            color1.ShowInfo();
            GeometricFigure color2 = new Circle();
            color2.ShowInfo();
            GeometricFigure color3 = new Segment();
            color3.ShowInfo();
            Console.WriteLine(new string('-', 110));
        }
    }
    abstract class GeometricFigure
    {
        public abstract string Name();
        public abstract double LengthOfSegments();
        abstract public string Color { get; set; }
        public GeometricFigure()
        {
            Color = "";
        }
        public void ShowInfo()
        {
            Console.WriteLine(Color + " is a " + Name());
        }
    }
    class Square : GeometricFigure
    {
        public double Section { get; set; }
        public Square(double section)
        {
            this.Section = section;
        }
        public override double LengthOfSegments()
        {
            return Section;
        }
        public override string Name()
        {
            return "square";
        }
        public override string Color { get; set; }

        public Square() : base() 
        {
            Color = "Blue";
        }
       
    }
    class Segment : GeometricFigure
    {
        public double Section { get; set; }
        public Segment(double section)
        {
            this.Section = section;
        }
        public override double LengthOfSegments()
        {
            return Section;
        }
        public override string Name()
        {
            return "segment";
        }
        public override string Color { get; set; }

        public Segment() : base()
        {
            Color = "White";
        }
    }

    class Circle : GeometricFigure
    {
        public double Section { get; set; }
        public Circle(double section)
        {
            this.Section = section;
        }
        public override double LengthOfSegments()
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                Section /= 2;
                return Section;
            }
            if (n == 2)
            {
                Section /= (Math.Sqrt(2) * 2);
                return Section;
            }
            else
            {
                return 0;
            }
        }
        public override string Name()
        {
            return "circle";
        }
        public override string Color { get; set; }
        public Circle() : base() 
        {
            Color = "Purple";
        }
    }
}
