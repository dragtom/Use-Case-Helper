using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Use_Case_helper
{
    class Actor
    {
        private int x1;
        private int y1;
        private int x2;
        private int y2;
        private string name;

        public int X1
        {
            get { return x1; }
            set { x1 = value; }
        }
        public int Y1
        {
            get { return y1; }
            set { y1 = value; }
        }
        public int X2
        {
            get { return x2; }
            set { x2 = value; }
        }
        public int Y2
        {
            get { return y2; }
            set { y2 = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Actor(int x1, int y1, int width, int height)
        {

        }
    }
}
