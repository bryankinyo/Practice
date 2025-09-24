using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Shapes
{
    public class Circle : Shapes
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea() => Math.PI * Radius * Radius;

        //public override double CalculateArea()
        //{
        //    return Math.PI * Radius * Radius;
        //}
    }
}
