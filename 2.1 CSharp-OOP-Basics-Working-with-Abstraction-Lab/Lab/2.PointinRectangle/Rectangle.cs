using System;
using System.Collections.Generic;
using System.Text;


public class Rectangle
{
    public Point TopLeft { get; set; }
    public Point BottomRight { get; set; }

    public Rectangle(int topX, int topY, int bottomX, int bottomY)
    {
        TopLeft = new Point(topX, topY);
        BottomRight = new Point(bottomX, bottomY);
    }

    public bool Contains(Point point)
    {
        return TopLeft.X <= point.X && point.X <= BottomRight.X &&
        TopLeft.Y <= point.Y && point.Y <= BottomRight.Y;
    }
}

