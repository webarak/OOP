using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date
{
    class Students
    {
        private string FirstName;
        private string LastName;
        private MyDate BirthDate;

        public Students(string f, string L, MyDate B)//בנאי
        {
            this.FirstName = f;
            this.LastName = L;
            this.BirthDate = B;
        }

        public Students()//בנאי
        {
            this.FirstName = null;
            this.LastName = null;
            this.BirthDate = new MyDate();
        }

        public void set_f(string f)
        {
            this.FirstName = f;
        }
        public void set_l(string l)
        {
            this.LastName = l;
        }
        public void set_d(MyDate d)
        {
            this.BirthDate = d;
        }

        public string get_f()
        {
            return this.FirstName;
        }
        public string get_l()
        {
            return this.LastName;
        }
        public MyDate get_d()
        {
            return this.BirthDate;
        }
    }
}
