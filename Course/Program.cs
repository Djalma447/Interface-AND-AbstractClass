using System;
using Course.Models.Entities;
using Course.Models.Enums;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape s1 = new Circle() { Color = Color.Black, Radius = 2.7 };
            Shape s2 = new Rectangle() { Color = Color.White, Height = 4.2, Width = 2.8 };

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
