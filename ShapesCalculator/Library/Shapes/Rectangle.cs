using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Shapes
{
    public class Rectangle : Shapes
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea() => Width * Height;

        //public override double CalculateArea()
        //{
        //    return Height * Width;
        //}
    }
}
