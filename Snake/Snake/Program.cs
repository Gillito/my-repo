using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            HorizontalLines hTopLine = new HorizontalLines(0, 78, 0, '+');
            hTopLine.DrawLine();
            HorizontalLines hBottomLine = new HorizontalLines(0, 78, 24, '+');
            hBottomLine.DrawLine();
            VerticalLines vLeftLine = new VerticalLines(0, 24, 0, '+');
            vLeftLine.DrawLine();
            VerticalLines vRightLine = new VerticalLines(0, 24, 78, '+');
            vRightLine.DrawLine();

            Console.ReadLine();
        }
    }
}
