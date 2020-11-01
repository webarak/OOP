using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class MyPoint
    {
        private int x;
        private int y;

        public MyPoint(int x, int y)//בנאי
        {
            if (x >= 0)
            {
                this.x = x;
            }
            else
            {
                this.x = 0;
            }
            if (y >= 0)
            {
                this.y = y;
            }
            else
            {
                this.y = 0;
            }
        }

        public MyPoint()//בנאי
        {
            this.x = 0;
            this.y = 0;
        }

        public int Get_X()//get x
        {
            return this.x;
        }

        public int Get_Y()//get y
        {
            return this.y;
        }
         public void Set_Y(int y)//set y
        {
            if (y >= 0)
            {
                this.y = y;
            }
            else
            {
                this.y = 0;
            }
        }

        public void Set_X(int x)//set x
        {
            if (x >= 0)
            {
                this.x = x;
            }
            else
            {
                this.x = 0;
            }
        }
        public void print_point()
        {
            Console.WriteLine("( " + this.x + " " + this.y + " ) ");
        }

        
    }
}
