using System.Collections.Generic;

namespace SnakeOOP
{

    class HorizontalLine : Figure
    {
        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            list = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                list.Add(p);
            }
        }
    }
}
