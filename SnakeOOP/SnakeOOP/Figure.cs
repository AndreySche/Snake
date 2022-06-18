using System.Collections.Generic;

namespace SnakeOOP
{
    class Figure
    {
        protected List<Point> list;

        public virtual void Draw() // virtual -- чтобы можно было переопределить
        {
            foreach (Point p in list) p.Draw();
        }

        internal bool IsHit(Figure figure)
        {
            foreach(Point p in list)
            {
                if (figure.IsHit(p)) return true;
            }
            return false;
        }

        internal bool IsHit(Point point)
        {
            foreach (Point p in list)
            {
                if (point.IsHit(p)) return true;
            }
            return false;
        }


    }
}
