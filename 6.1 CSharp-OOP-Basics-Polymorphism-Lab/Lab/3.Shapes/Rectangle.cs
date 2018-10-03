using System;
using System.Collections.Generic;
using System.Text;


public class Rectangle : Shape
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
        private set { width = value; }
    }

    public double Height
    {
        get { return height; }
        private set { height = value; }
    }

    public override double CalculateArea()
    {
        var area = this.Width * this.Height;
        return area;
    }

    public override double CalculatePerimeter()
    {
        var perimeter = 2 * this.Width + 2 * this.Height;
        return perimeter;
    }

    public override string Draw()
    {
        return $"{base.Draw()}Rectangle";
    }
}

