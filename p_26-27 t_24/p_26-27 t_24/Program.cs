using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_26_27_t_24
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[5];
            people [0] = new Person("shahaf", "mor", 17, "23423432");
            people [1] = new Employee("segev", "david", 16, "4237462384", "234", "math");
            people [2] = new Worker("barak", "weisler", 15, "325770063", "111", "geo", 150, 6);
            people [3]= new SalesMan("yahali", "mashich", 20, "32345234", "2222", "cyber", 2, 200, 0);
            people [4] = new Person("almog", "Hemo", 18, "2234214325");

            for (int i = 0; i<people.Length; i++)
            {
                Console.WriteLine(people[i].ToString());
                Console.WriteLine();
                Console.WriteLine();
            }

            Person[] people2 = new Person[5];
            people2[0] = new Person("shahaf", "mor", 17, "23423432");
            people2[1] = new Employee("segev", "david", 16, "4237462384", "234", "math");
            people2[2] = new Worker("barak", "weisler", 15, "325770063", "111", "geo", 150, 6);
            people2[3] = new SalesMan("yahali", "mashich", 20, "32345234", "2222", "cyber", 2, 200, 0);
            people2[4] = new Student("almog", "hemo", 18, "42342342", "ya", true, 89,5,23,2,98,3);

            for (int i = 0; i < people2.Length; i++)
            {
                Console.WriteLine(people2[i].ToString());
                Console.WriteLine();
                Console.WriteLine();
            }

        }
    }
}
