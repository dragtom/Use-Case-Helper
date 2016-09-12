using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Use_Case_helper
{
    class Line : Element
    {
        public Line(int x1, int y1, int x2, int y2, string name) : base(x1, y1, x2, y2, name)
        {
            /*
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x1 + width;
            this.y2 = y1 + height;
            this.name = name;
            */
            type = "Line";
        }
    }
}
