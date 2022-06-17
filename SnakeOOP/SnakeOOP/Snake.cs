
using System.Linq;
using System.Collections.Generic;

namespace SnakeOOP
{
    class Snake : Figure
    {
        private Direct _direction;
        public Snake(Point tail, int length, Direct direction)
        {
            _direction = direction;
            list = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                list.Add(p);
            }
            Draw();
        }

        public void Move()
        {
            Point tail = list.First();
            list.Remove(tail);
            Point head = GetNextPoint();
            list.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = list.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, _direction);
            return nextPoint;
        }
    }
}
