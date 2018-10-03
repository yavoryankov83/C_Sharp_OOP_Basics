using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Shapes
{
    class Rectangle : Shape
    {
        private double height;
        private double width;

        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public double Width
        {
            get { return width; }
            protected set { width = value; }
        }

        public double Height
        {
            get { return height; }
            protected set { height = value; }
        }

        public override double CalculateArea()
        {
            return this.Height * this.Width;
        }

        public override double CalculatePerimeter()
        {
            return 2 * this.Height + 2 * this.Width;
        }

        public override string Draw()
        {
            return base.Draw() + "Rectangle";
        }
    }
}
