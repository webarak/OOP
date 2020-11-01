using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDate d = new MyDate(30, 2, 2009);
            MyDate d2 = new MyDate(5, 11, 2003);

            Console.WriteLine( d.before(d2));
            Console.WriteLine(d.date());

            Students s1 = new Students("Barak", "Weisler", d);
        }
    }
}
