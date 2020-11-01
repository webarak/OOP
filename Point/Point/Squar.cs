using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class Squar
    {
        private MyPoint p1;
        private MyPoint p2;
        private MyPoint p3;
        private MyPoint p4;

        public Squar(MyPoint p1, MyPoint p2, MyPoint p3, MyPoint p4)//בנאי
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            this.p4 = p4;
        }

        public Squar()//בנאי
        {
            this.p1 = new MyPoint();
            this.p2 = new MyPoint();
            this.p3 = new MyPoint();
            this.p4 = new MyPoint();
        }

        public void SetP1(MyPoint p1)
        {
            this.p1 = p1;
        }
        public void SetP2(MyPoint p2)
        {
            this.p2 = p2;
        }
        public void SetP3(MyPoint p3)
        {
            this.p3 = p3;
        }
        public void SetP4(MyPoint p4)
        {
            this.p4 = p4;
        }

        public double GetRib1Length()
        {
            Line Rib1 = new Line(this.p1, this.p2);
            return Rib1.line_length(this.p1, this.p2);
        }

        public double GetRib2Length()
        {
            Line Rib2 = new Line(this.p2, this.p3);
            return Rib2.line_length(this.p2, this.p3);
        }

        public double GetRib3Length()
        {
            Line Rib3 = new Line(this.p3, this.p4);
            return Rib3.line_length(this.p3, this.p4);
        }

        public double GetRib4Length()
        {
            Line Rib4 = new Line(this.p4, this.p1);
            return Rib4.line_length(this.p4, this.p1);
        }

        public double SSquar()//מחזיר שטח ריבוע
        {
            return Math.Pow(GetRib1Length(), 2);
        }

        public double PSquar()//מחזיר היקף ריבוע
        {
            return GetRib1Length() * 4;
        }

        public void print_squar()
        {
            this.p1.print_point();
            this.p2.print_point();
            this.p3.print_point();
            this.p4.print_point();
        }
    }
}
