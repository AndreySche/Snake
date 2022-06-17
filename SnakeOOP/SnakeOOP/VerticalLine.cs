using System.Collections.Generic;

namespace SnakeOOP
{
    class VerticalLine : Figure
    {
        public VerticalLine(int x, int y, char sym, int count)
        {
            list = new List<Point>();
            Foreach(x, y, sym, count, false,ref list);
            Draw();
        }
    }
}
