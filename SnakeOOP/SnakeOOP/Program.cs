using System;
using System.Collections.Generic;
using System.Threading;

namespace SnakeOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Walls walls = new Walls(80, 30);

            Point p = new Point(4, 5, '*');
            Figure fSnake = new Snake(p, 5, Direction.RIGHT);
            Snake snake = (Snake)fSnake;
            fSnake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 30, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if(walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                else if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else Thread.Sleep(100);
                snake.Move();
            }
        }
    }
}
