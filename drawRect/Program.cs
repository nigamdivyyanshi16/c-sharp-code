// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using System.IO;
namespace drawRect
{
    class Rectangle
    {
        float length, width;
        Rectangle()
        {
            length = 0;
            width = 0;
        }

        Rectangle(float l, float w)
        {
            length = l;
            width = w;
        }

        public float Length
        {
            get { return length; }
            set { length = value; }
        }

        public float Width
        {
            get { return width; }
            set { width = value; }
        }

        double getArea()
        {
            return length * width;
        }

        double getPerimeter()
        {
            return (2 * length * width);
        }

        static void Main(string[] args)
        {
            Rectangle ob = new Rectangle();
            Console.WriteLine("length=" + ob.length);
            Console.WriteLine("width=" + ob.width);

            Rectangle ob1 = new Rectangle(3.4f, 2.6f);
            Console.WriteLine("length=" + ob1.length);
            Console.WriteLine("width=" + ob1.width);
            Console.WriteLine("Area=" + ob1.getArea());
            Console.WriteLine("Perimeter=" + ob1.getPerimeter());

            Rectangle ob2 = new Rectangle();
            ob2.Length = 5.1f;
            ob2.Width = 2.3f;
            Console.WriteLine("length=" + ob2.Length);
            Console.WriteLine("width=" + ob2.Width);
            Console.WriteLine("Area=" + ob2.getArea());
            Console.WriteLine("Perimeter=" + ob2.getPerimeter());
        }

    }
}
