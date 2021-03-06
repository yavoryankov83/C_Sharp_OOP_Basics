﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Shapes
{
    class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get { return radius; }
            protected set { radius = value; }
        }

        public override double CalculateArea()
        {
            return Math.PI * this.Radius * this.Radius;
        }

        public override double CalculatePerimeter()
        {
            return 2 + Math.PI * this.Radius;
        }

        public override string Draw()
        {
            return base.Draw() + "Circle";
        }
    }
}
