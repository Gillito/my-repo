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
            HorizontalLines hLine = new HorizontalLines(15, 35, 10, '-');
            hLine.DrawHLine();

            Console.ReadLine();
        }
    }
}
