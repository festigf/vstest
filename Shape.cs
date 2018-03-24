using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Shape
    {
        
        public int X { get; set; }
        public int Y { get; set; }
      
        public virtual double Area()
        {
            return 0;
        }

        public override string ToString()
        {
            return "X="+X.ToString()+";Y="+Y.ToString();
        }
    }
}
