using System;
using System.Collections.Generic;
using System.Text;


public class Rectangle
{
    private string id;
    private double width;
    private double height;
    private double top;
    private double left;

    public Rectangle(string id, double width, double height, double top, double left)
    {
        this.Id = id;
        this.Width = Math.Abs(width);
        this.Height = Math.Abs(height);
        this.Top = top;
        this.Left = left;
    }

    public double Left
    {
        get { return left; }
        set { left = value; }
    }


    public double Top
    {
        get { return top; }
        set { top = value; }
    }


    public double Height
    {
        get { return height; }
        set { height = value; }
    }


    public double Width
    {
        get { return width; }
        set { width = value; }
    }


    public string Id
    {
        get { return id; }
        set { id = value; }
    }


    public bool IsIntersect(Rectangle rectangle)
    {
        return rectangle.top + rectangle.width >= this.top &&
                rectangle.top <= this.top + this.width &&
                rectangle.left >= this.left - this.height &&
                rectangle.left - rectangle.height <= this.left;
    }
}

