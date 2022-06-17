using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeOOP
{
    class VerticalLine
    {
        private List<Point> list;

        public VerticalLine(int x, int y, char sym, int count)
        {
            list = new List<Point>();
            for (int i = 0; i < count; i++)
            {
                list.Add(new Point(x , y + i, sym));
            }

            Draw();
        }

        public void Draw()
        {
            foreach (Point p in list) p.Draw();
        }
    }
}
