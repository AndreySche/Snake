using System;
using System.Collections.Generic;
using System.Threading;

namespace SnakeOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeX = 80, sizeY = 25;
            //Console.SetBufferSize(sizeX, sizeY);
            SetBorder(sizeX, sizeY);

            Point p = new Point(5, 5, '*');
            Snake snake = new Snake(p, 5, Direct.right);

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.JoyStick(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }

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
