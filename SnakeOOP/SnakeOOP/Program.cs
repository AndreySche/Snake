using System;
using System.Collections.Generic;
using System.Threading;

namespace SnakeOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeX = 80, sizeY = 30;

            HorizontalLine h1 = new HorizontalLine(0, 0, '=', sizeX);
            VerticalLine v1 = new VerticalLine(0, 1, '|', sizeY - 2);
            HorizontalLine h2 = new HorizontalLine(0, sizeY - 1, '=', sizeX);
            VerticalLine v2 = new VerticalLine(sizeX - 1, 1, '|', sizeY - 2);

            Point p = new Point(4, 5, '*');
            Figure fSnake = new Snake(p, 5, Direct.right);
            Snake snake = (Snake)fSnake;

            List<Figure> fList = new List<Figure>() { v1, h1, v2, h2, fSnake };
            foreach (Figure f in fList) f.Draw();

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
        }

        private static void Draw(Figure figur)
        {
            figur.Draw();
        }
    }
}
