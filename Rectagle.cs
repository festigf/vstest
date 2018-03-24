using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Rectagle: Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public Rectagle(int x0,int y0, int Height,int Width, string id) : base(id)
        {
            this.X0 = x0;
            this.Y0 = y0;
            this.Height = Height;
            this.Width = Width;
        }

        public override  double Area
        {
            get { return Width * Height; }
        }
        public override double Length
        {
            get
            {
                return Width * 2+ Height*2;
            }
        }
    }
}
