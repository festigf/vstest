using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Shape 
    {
        private string name;
        public int X0 { get; set; }
        public int Y0 { get; set; }
        public Shape(string s)
        {
            Id = s;
        }

        public string Id
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public abstract double Area
        {
            get;
        }
        public abstract double Length
        {
            get;
        }
       

        public override string ToString()
        {
            return Id + " Area = " + string.Format("{0:F2}", Area);
        }

    
    }
}
