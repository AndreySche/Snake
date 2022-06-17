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
    }
}
