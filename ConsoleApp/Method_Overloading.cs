using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Method_Overloading
    {
        public int PlusMethod(int x, int y)
        {
            return x + y;
        }

        public double PlusMethod(double x, double y)
        {
            return x + y;
        }
    }
}
