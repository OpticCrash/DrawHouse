using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            House h = new House(100);
            h.RendSpeed = 10;
            h.DrawSquare();
            h.DrawRoof();
            h.DrawWindw();
            Console.ReadKey();
        }
    }
}
