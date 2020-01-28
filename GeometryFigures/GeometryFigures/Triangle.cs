using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryFigures
{
    public class Triangle : IFigure
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        private  double _p;

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;

        }

        private double Perimetr()
        {
            _p = (A + B + C) / 2;

            return _p;
        }

        public double Area()
        {
            double result = Math.Sqrt(Perimetr() * (Perimetr() - A) * (Perimetr() - B) * (Perimetr() - C));
            return result;
        }
    }
}
