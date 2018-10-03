using System;
using System.Collections.Generic;
using System.Text;


public class Box
{
    public double Length { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }

    public Box(double length, double width, double height)
    {
        Length = length;
        Width = width;
        Height = height;
    }

    public double CalculateVolume()
    {
        return Length * Width * Height;
    }

    public double CalculateSurfaceArea()
    {
        return 2 * Length * Width + 2 * Length * Height + 2 * Width * Height;
    }

    public double CalculateLateralSurfaceArea()
    {
        return 2 * Length * Height + 2 * Width * Height;
    }
}

