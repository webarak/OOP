using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class Circle
    {
        private Line Radius;

        public Circle(Line R)//בנאי
        {
            this.Radius = R;
        }
         public Circle()// בנאי
        {
            this.Radius = new Line();
        }

        public void set_Radius(Line R)
        {
            this.Radius = R;
        }

        public Line get_Radius()
        {
            return this.Radius;
        }

        public double GetPCircle()//מחזיר את היקף המעגל
        {
            return 2 * Math.PI * this.Radius.line_length(this.Radius.Get_p1(), this.Radius.Get_p2());
        }

        public double GetSCircle()//מחזיר את שטח המעגל
        {
            return Math.PI * Math.Pow(this.Radius.line_length(this.Radius.Get_p1(), this.Radius.Get_p2()), 2);
        }

        
    }
}
