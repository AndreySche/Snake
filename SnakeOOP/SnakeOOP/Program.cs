using System;
using System.Collections.Generic;

namespace SnakeOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeX = 80, sizeY = 25;
            //Console.SetBufferSize(sizeX, sizeY);
            SetBorder(sizeX, sizeY);

            /*List<Point> list = new List<Point>()
            {
                new Point(1, 3, '*'),
                new Point(2, 5, '#')
            };
            foreach (Point p in list) p.Draw();*/
            Point p = new Point(1, 3, '*');
            Snake snake = new Snake(p, 3, Direct.right);

            Console.ReadLine();
        }

        private static void SetBorder(int sizeX, int sizeY)
        {
            HorizontalLine hLine = new HorizontalLine(0, 0, '+', sizeX);
            VerticalLine vline = new VerticalLine(0, 0, '+', sizeY);

            HorizontalLine hLine2 = new HorizontalLine(0, sizeY - 1, '+', sizeX);
            VerticalLine vline2 = new VerticalLine(sizeX - 1, 0, '+', sizeY);
        }
    }
}
