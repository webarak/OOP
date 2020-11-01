using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p18_19t19
{
    class Program
    {
        static void Main(string[] args)
        {
            MyTraveler T1 = new MyTraveler(new MyPassport("shahaf", new MyDate(1, 12, 2007)), true);
            MyTraveler T2 = new MyTraveler(new MyPassport("barak", new MyDate(1, 7, 2019)), false);
            MyTraveler T3 = new MyTraveler(new MyPassport("segev", new MyDate(11, 8, 2009)), true);

            MyDate d1 = new MyDate(1, 1, 2007);
            if (T1.CheckTravel(d1)==true)
            {
                Console.WriteLine(T1.ToString());
            }

            if (T2.CheckTravel(d1) == true)
            {
                Console.WriteLine(T2.ToString());
            }

            if (T3.CheckTravel(d1) == true)
            {
                Console.WriteLine(T3.ToString());
            }
        }
    }
}
