using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trianglePetrov
{
    class Triangle
    {
#pragma warning disable IDE0044 // добавить использования для  углов
        private double a,b,c,h, alpha, beta, gamma;
        private bool pryamoiUgol;
#pragma warning restore IDE0044 
        public Triangle(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
        }
        public Triangle(double A, double B, double C, double H)
        {
            a = A;
            b = B;
            c = C;
            h = H;
        }
        public Triangle() { }
        public double Perimeter()
        {
            return a+b+c;
        }
        public double Area()
        {
            if (h != 0.0)
            {
                return (a * h) / 2;
            }
            else if (a != 0 && b != 0 && c != 0)
            {
                double p = Perimeter() / 2;
                return Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
            }
            else if (alpha != 0.0 && a != 0.0 && b != 0.0)
            {
                return (a * b) / 2 * Math.Sin(alpha);
            }
            else if (beta != 0.0 && b != 0.0 && c != 0.0)
            {
                return (b * c) / 2 * Math.Sin(beta);
            }
            else if (gamma != 0.0 && c != 0.0 && b != 0.0)
            {
                return (c * b) / 2 * Math.Sin(gamma);
            }
            else if (pryamoiUgol)
            {
                return (a * b) / 2;
            }
            else return 0.0;
        }
        public bool RealityCheck()
        {
            return (a > b + c) && (b > c + a) && (c > b + a) ? true : false;
        }
        public double Height()
        {
            return (Area() * 2) / a;
        }
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
        public double h { get; set; }
        public double alpha { get; set; }
        public double beta { get; set; }
        public double gamma { get; set; }
        public bool Exists { get; set; }
        public bool Isosceles { get; set; }
        public bool Equilateral { get; set; }
    }
}
