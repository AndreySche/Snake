using System.Collections.Generic;

namespace SnakeOOP
{
    class Figure
    {
        public List<Point> pointList;

        /// <summary>
        /// Рисуем линии
        /// </summary>
        /// <param name="startPoint"></param>
        /// <param name="count"></param>
        /// <param name="sym"></param>
        /// <param name="horizontal">вертикальная true|false</param>
        public Figure() { }

        public void Draw()
        {
            foreach (Point p in pointList)
            {
                p.Draw();
            }
        }
    }
}