using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class point
    {
        public int X { get; set; } = 1;
        public int Y { get; set; } = 1;

        public override string ToString()
        {
            return ($"x={X},y={Y}");
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X,Y);
        }
        public override bool Equals(object? obj)
        {
            point? other=(point?)obj;
            return this.X==other?.X && this.Y ==other?.Y;
        }
    }
    
  

    class point3d : point
    {
        public int z
        {
            get; set;
        }
    }
}
