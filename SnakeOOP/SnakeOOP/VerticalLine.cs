using System.Collections.Generic;

namespace SnakeOOP
{
    class VerticalLine : Figure
    {
        public VerticalLine(int x, int y, char sym, int count)
        {
            list = new List<Point>();
            for (int i = 0; i < count; i++)
            {
                list.Add(new Point(x, y + i, sym));
            }

            Draw();
        }
    }
}
