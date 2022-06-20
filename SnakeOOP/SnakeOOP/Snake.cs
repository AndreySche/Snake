using System;
using System.Collections.Generic;
using System.Linq;

namespace SnakeOOP
{
    class Snake : Figure
    {
        private Point direction;
        private Dictionary<ConsoleKey, Point> plusDirect;
        private Point endPoint;

        public Snake(ref Point endPoint, char sym, int count)
        {
            this.endPoint = endPoint;
            direction = DirectionInit();
            pointList = new List<Point>();
            for (int i = 0; i < count; i++)
            {
                pointList.Add(new Point(endPoint.X / 2 + i, endPoint.Y / 2, sym));
            }
        }

        public void HandleKey(ConsoleKey key)
        {
            if (!plusDirect.ContainsKey(key)) return;
            direction = plusDirect[key];
        }

        public void Move()
        {
            Point tail = pointList.First();
            pointList.Remove(tail);
            tail.Clear();

            Point head = pointList.Last();
            head += direction;
            head = WallFerify(ref head);
            pointList.Add(head);

            head.Draw();
        }

        private Point WallFerify(ref Point head)
        {
            if (head.X >= endPoint.X - 1) return new Point(1, head.Y, head.Sym);
            if (head.X <= 1) return new Point(endPoint.X - 2, head.Y, head.Sym);
            if (head.Y >= endPoint.Y) return new Point(head.X, 1, head.Sym);
            if (head.Y <= 0) return new Point(head.X, endPoint.Y - 1, head.Sym);
            return head;
        }

        private Point DirectionInit()
        {
            char head = '*';
            plusDirect = new Dictionary<ConsoleKey, Point>();
            plusDirect.Add(ConsoleKey.LeftArrow, new Point(-1, 0, head));
            plusDirect.Add(ConsoleKey.RightArrow, new Point(1, 0, head));
            plusDirect.Add(ConsoleKey.UpArrow, new Point(0, -1, head));
            plusDirect.Add(ConsoleKey.DownArrow, new Point(0, 1, head));

            return plusDirect[ConsoleKey.RightArrow];
        }
    }
}
