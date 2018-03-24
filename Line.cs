using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Line:Shape
    {
        public int X1 { get; set; }
        public int Y1 { get; set; }

        public new void Area()
        {
            throw new Exception("Error: a line don't have area");
        }

        public double Length()
        {
            return Math.Sqrt(Math.Pow(X1 - X, 2) + Math.Pow(Y1 - Y, 2));
        }
        public override string ToString()
        {
            return base.ToString()+"X1="+X1.ToString()+";Y1="+Y1.ToString();
        }
    }
}
