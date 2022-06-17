
using System.Collections.Generic;

namespace SnakeOOP
{
    class Snake : Figure
    {
        public Snake(Point tail, int length, Direct direction)
        {
            list = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                list.Add(p);
            }
            Draw();
        }
    }
}
