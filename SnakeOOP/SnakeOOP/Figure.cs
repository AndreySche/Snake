using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeOOP
{
    class Figure
    {
        protected List<Point> list;

        public void Draw()
        {
            foreach (Point p in list) p.Draw();
        }

        public List<Point> Foreach(int _x, int _y, char _sym, int count, bool horizontal, List<Point> list)
        {
            int plus1, plus2;            
            for (int i = 0; i < count; i++)
            {
                plus1 = horizontal ? i : 0;
                plus2 = horizontal ? 0 : i;
                list.Add(new Point(_x + plus1, _y + plus2, _sym));
            }
            return list;
        }
    }
}
