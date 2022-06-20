using System.Collections.Generic;

namespace SnakeOOP
{
    class Line : Figure
    {
        public Line(int x, int y, char sym, int count, bool horizontal)
        {
            int xx = horizontal ? 1 : 0;
            int yy = horizontal ? 0 : 1;

            pointList = new List<Point>();
            for (int i = 0; i < count; i++)
            {
                pointList.Add(new Point(x + i * xx, y + i * yy, sym));
            }
        }
    }
}
