using System.Collections.Generic;

namespace SnakeOOP
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int x, int y, char sym, int count)
        {
            list = new List<Point>(); 
            Foreach(x, y, sym, count, true,ref list);
            Draw();
        }
    }
}
