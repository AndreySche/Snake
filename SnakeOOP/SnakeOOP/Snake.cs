
using System.Linq;
using System.Collections.Generic;
using System;

namespace SnakeOOP
{
    class Snake : Figure
    {
        private Direction _direction;
        public Snake(Point tail, int length, Direction direction)
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
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                JoyStick(key.Key);
            }

            Point tail = list.First();
            list.Remove(tail);
            Point head = GetNextPoint();
            list.Add(head);

            tail.Clear();
            head.Draw();
        }

        public bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.Sym = head.Sym;
                list.Add(food);
                return true;
            }
            return false;
        }

        internal bool IsHitTail()
        {
            var head = list.Last();
            for (int i=0; i<list.Count - 2;i++)
            {
                if (head.IsHit(list[i])) return true;
            }
            return false;
        }

        public Point GetNextPoint()
        {
            Point head = list.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, _direction);
            return nextPoint;
        }

        public void JoyStick(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                _direction = Direction.LEFT;
            if (key == ConsoleKey.RightArrow)
                _direction = Direction.RIGHT;
            if (key == ConsoleKey.UpArrow)
                _direction = Direction.UP;
            if (key == ConsoleKey.DownArrow)
                _direction = Direction.DOWN;
        }
    }
}
