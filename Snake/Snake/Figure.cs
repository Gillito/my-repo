using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        protected List<Point> hLines;

        public void DrawLine()
        {
            foreach (Point item in hLines)
            {
                item.Draw();
            }
        }
    }
}
