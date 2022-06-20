using System;
using System.Collections.Generic;

namespace SnakeOOP
{
    class Food : Figure
    {
        Random rnd = new Random();
        private Point _endPoint;
        public Point food { get; private set; }

        public Food(Point endPoint)
        {
            pointList = new List<Point>();
            _endPoint = endPoint;
            Create();
        }

        public void Create()
        {
            int x = rnd.Next(2, _endPoint.X - 4);
            int y = rnd.Next(2, _endPoint.Y - 4);
            food = new Point(x, y, '$');
            food.Draw();
        }

    }
}