using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IcomparableAufgabe
{
    class House : IComparable<House>
    {

        private int height;

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public int CompareTo(House other)
        {
            if (this.Height > other.Height)
            {
                return 1;
            }
            else if (this.Height < other.Height)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
