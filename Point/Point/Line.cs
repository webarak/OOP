using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class Line
    {
        private MyPoint p1;
        private MyPoint p2;

        public Line(MyPoint p1, MyPoint p2)//בנאי
        {
            this.p1 = p1;
            this.p2 = p2;
        }

        public Line()//בנאי
        {
            this.p1 = new MyPoint();
            this.p2 = new MyPoint();
        }

        public void Set_p1(MyPoint p1)//set p1
        {
            this.p1 = p1;
        }

        public void Set_p2(MyPoint p2)//set p2
        {
            this.p2 = p2;
        }

        public MyPoint Get_p1()//get p1
        {
            return this.p1;
        }

        public MyPoint Get_p2()//get p2
        {
            return this.p2;
        }

        public double line_length(MyPoint p1, MyPoint p2)//פעולה המחזירה את אורך הישר
        {
            double length = Math.Sqrt(Math.Pow((p1.Get_X() - p2.Get_X()), 2) + Math.Pow((p1.Get_Y() - p2.Get_Y()), 2));
            return length;
        }

        public void print_deatails()//פעולה המדפיסה את נתוני הישר
        {
            Console.WriteLine("start point : ({0},{1}) " ,this.p1.Get_X(), this.p1.Get_Y());
            Console.WriteLine("end point : ({0},{1}) ", this.p2.Get_X(), this.p2.Get_Y());
            Console.WriteLine("line length: {0}", line_length(this.p1, this.p2));
        }
    }
}
