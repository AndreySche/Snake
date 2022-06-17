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

            HorizontalLine hLine = new HorizontalLine(4, 3, '+', 5);
            VerticalLine vline = new VerticalLine(4, 3, '+', 7);
            VerticalLine vline2 = new VerticalLine(4 + 5 - 1, 3, '+', 7);
            HorizontalLine hLine2 = new HorizontalLine(4, 3 + 7 - 1, '+', 5);


            Console.ReadLine();
        }
    }
}
