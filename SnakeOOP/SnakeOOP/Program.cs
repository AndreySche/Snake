using System;
using System.Collections.Generic;

namespace SnakeOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Point> list = new List<Point>()
            {
                new Point(1, 3, '*'),
                new Point(2, 5, '#')
            };

            foreach (Point p in list) p.Draw();

            Console.ReadLine();
        }
    }
}
