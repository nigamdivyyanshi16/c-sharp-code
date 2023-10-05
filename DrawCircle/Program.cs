// See https://aka.ms/new-console-template for more information
using System.IO;

namespace DrawCircle
{
    class Circle
    {
        double radius;
        Circle()
        {
            radius = 0.0;
        }

        Circle(double r)
        {
            radius=r;
        }
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }

        double getArea()
        {
            double a = radius * radius * Math.PI;
            return a;
        }

        double getCircumference()
        {
            return (2 * Math.PI * 2);
        }

       static void Main(string[] args)
        {
            Circle ob = new Circle();
            Console.WriteLine(ob.radius);
            Circle ob1 = new Circle(1.1);
            Console.WriteLine(ob1.radius);

            Circle ob3 = new Circle();
            ob3.Radius = 2.1;
            Console.WriteLine(ob3.Radius);

          double a=ob3.getArea(); 
            double c=ob3.getCircumference();
            Console.WriteLine("Area=" + a);
            Console.WriteLine("Circumference="+c);

        }

    }

}
