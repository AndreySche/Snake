using System;
using System.Collections.Generic;
using System.Threading;

namespace SnakeOOP
{
    class Program
    {
        static private List<Figure> list;

        static void Main(string[] args)
        {
            Point endPoint = new Point(80, 20, '+');
            Walls walls = new Walls(endPoint);
            Food food = new Food(endPoint);
            Figure snake = new Snake(ref endPoint, '*', 5);

            list = walls.walls;
            list.Add(snake);

            Draw();
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    (snake as Snake).HandleKey(key.Key);
                }
                (snake as Snake).Move();
                Thread.Sleep(100);
            }
        }

        static private void Draw()
        {
            foreach (Figure f in list) f.Draw();
        }
    }
}