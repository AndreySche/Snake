using System.Collections.Generic;

namespace SnakeOOP
{
    class Figure
    {
        protected List<Point> list;

        public void Draw()
        {
            foreach (Point p in list) p.Draw();
        }
    }
}
