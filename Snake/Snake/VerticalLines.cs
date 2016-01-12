using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLines : Figure
    {
        public VerticalLines(int yTop, int yBottom, int x, char sym)
        {
            hLines = new List<Point>();

            for (int i = yTop; i <= yBottom; i++)
            {
                Point p = new Point(x, i, sym);
                hLines.Add(p);
            }
        }
    }
}
