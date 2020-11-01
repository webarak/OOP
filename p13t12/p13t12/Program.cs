using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p13t12
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student("barak w", "11g", true, 100, 5, 98, 5, 95, 5);
            Student st2 = new Student("shahaf m", "11g", true, 69, 3, 69, 3, 69, 3);
            Student st3 = new Student("segev dh", "11e", false, 78, 5, 98, 5, 100, 4);

            Console.WriteLine();
            st1.Show();
            Console.WriteLine();
            st2.Show();
            Console.WriteLine();
            st3.Show();
            Console.WriteLine();

            Console.WriteLine(st3.AvgCalc(16, 32));
            Console.WriteLine(st3.AvgCalc(false));

        }
    }
}
