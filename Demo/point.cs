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
    }

    class point3d : point
    {
        public int z
        {
            get; set;
        }
    }
}
