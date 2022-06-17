using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeOOP
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int x, int y, char sym, int count)
        {
            list = new List<Point>(); 
            Foreach(x, y, sym, count, true, list);
            Draw();
        }
    }
}
