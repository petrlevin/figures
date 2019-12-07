using System;

namespace Figures
{
    public class Round : IFigure
    {
        public Round(double radius)
        {
            Radius = radius;
        }

        public double GetArrea()
        {
           return Math.PI*Radius*Radius;
        }

        public double Radius { get;}
    }
}