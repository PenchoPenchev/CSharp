﻿//Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

using System;
class CheckPointInCircle
{
    static void Main()
    {
        double raduis = 5;

        Console.WriteLine("Enter X coordinate");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Y coordinate");
        double y = double.Parse(Console.ReadLine());

        double point = Math.Sqrt((x * x) + (y * y));

        Console.WriteLine(point <= raduis ?
                            "The Point is IN the Circle"
                            : "The Point is OUT of the Circle");
    }
}