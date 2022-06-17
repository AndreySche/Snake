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

            FoodCreator foodCreator = new FoodCreator(sizeX, sizeY, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else Thread.Sleep(100);
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
