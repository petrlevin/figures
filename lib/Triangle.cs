using System;

namespace Figures
{
    public class Triangle : IFigure
    {
        private double[]_sides;
        public Triangle(double a_b,double b_c, double c_d)
        {
            _sides =new double[]{a_b,b_c,c_d};
            Array.Sort(_sides);
            if (_sides[0]+_sides[1]<_sides[2])
                throw new ArithmeticException("sides of triangle are not correct");
            A_B = a_b;
            B_C = b_c;
            C_D = c_d;
        }

        public double A_B { get; }
        public double B_C { get; }
        public double C_D { get; }

        public double GetArrea()
        {
            if  (_sides[0]*_sides[0]+_sides[1]*_sides[1]==_sides[2]*_sides[2])
                return _sides[0]*_sides[1] /2;
            double  semiperimeter = (A_B+B_C+C_D)/2;
            return Math.Sqrt(semiperimeter*(semiperimeter-A_B)*(semiperimeter-B_C)*(semiperimeter-C_D));    
        }

    }
}