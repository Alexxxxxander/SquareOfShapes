using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   

namespace SquareOfShapes
{
    public abstract class Shape
    {
        public abstract double Area {  get; set; }
    }

    public class Triangle : Shape
    {
        private double a;
        private double b;
        private double c;

        public bool IsRight = false;

        public Triangle(double a, double b, double c) {
            this.a = Math.Abs(a);
            this.b = Math.Abs(b);
            this.c = Math.Abs(c);
            if (a * a == b * b + c * c || b * b == a * a + c * c || c * c == a * a + b * b)
            {
                IsRight = true;
            }
        }

        public override double Area
        {
            get {
                double p = (a + b + c) / 2;
                return Math.Sqrt(p*(p-a)*(p-b)*(p-c));               
            }
            set { }           
        }

    }


    public class Circle : Shape
    {
        private double radius;

        public Circle(double r) => radius = Math.Abs(r);

        public override double Area
        {
            get => Math.PI * radius * radius;
            set => radius = Math.Sqrt(value/Math.PI);
        }
    }
}
