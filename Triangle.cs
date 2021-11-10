using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trianglePetrov
{
    class Triangle
    {
        private double a,b,c;
        public Triangle(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
        }
        public double Perimeter()
        {
            return a+b+c;
        }
        public double Surface()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
        }
        public bool RealityCheck()
        {
            return (a > b + c) && (b > c + a) && (c > b + a) ? false : true;
        }
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
    }
}
