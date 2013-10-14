﻿//Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

using System;

class AlternateNumberSigns
{
    static void Main()
    {
        Console.WriteLine("2, -3, 4, -5, 6, -7, 8, -9, 10, -11");

        //or using 'for' loop
        byte counter = 10;

        Console.WriteLine("Enter the starting number of the sequence: ");
        int startNumber = int.Parse(Console.ReadLine());

        for (int i = startNumber; i < startNumber + counter; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + ", ");
            }
            else
            {
                Console.Write(-i + ", ");
            }
        }

    }
}