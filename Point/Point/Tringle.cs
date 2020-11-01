using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class Tringle
    {
        private MyPoint p1;
        private MyPoint p2;
        private MyPoint p3;

        public Tringle(MyPoint p1, MyPoint p2, MyPoint p3)//בנאי
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
        }

        public Tringle()//בנאי
        {
            this.p1 = new MyPoint();
            this.p2 = new MyPoint();
            this.p3 = new MyPoint();
        }

        public void Set_P1(MyPoint p1)
        {
            this.p1 = p1;
        }

        public void Set_P2(MyPoint p2)
        {
            this.p2 = p2;
        }

        public void Set_P3(MyPoint p3)
        {
            this.p3 = p3;
        }

        public double Get_rib1_length()
        {
            Line rib1 = new Line(p2, p3);
            return rib1.line_length(p2, p3);
        }

        public double Get_rib2_length()
        {
            Line rib2 = new Line(p1, p3);
            return rib2.line_length(p1, p3);
        }
        public double Get_rib3_length()
        {
            Line rib3 = new Line(p1, p2);
            return rib3.line_length(p1, p2);
        }

        public double PTriangle()//מחזיר את היקף המשולש
        {
            return Get_rib1_length() + Get_rib2_length() + Get_rib3_length();
        }

         public double STriangle()//מחזיר את שטח המשולש
        {
            double gama = Math.Acos((Math.Pow(Get_rib3_length(),2)-Math.Pow(Get_rib1_length(),2)-Math.Pow(Get_rib2_length(),2))/(-2*Get_rib2_length()*Get_rib1_length()));
            double S = (Get_rib1_length() * Get_rib2_length() * Math.Sin(gama)) / 2;
            return S;
        }

        public void print_triangle()
        {
            this.p1.print_point();
            this.p2.print_point();
            this.p3.print_point();
        }
    }
}
