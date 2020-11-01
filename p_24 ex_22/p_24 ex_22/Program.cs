using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_24_ex_22
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("shahaf", "mor", 17, "23423432");
            Employee e = new Employee("segev", "david", 16, "4237462384", "234", "math");
            Worker w = new Worker("barak", "weisler", 15, "325770063", "111", "geo", 150, 6);
            SalesMan s = new SalesMan("yahali", "mashich", 20, "32345234", "2222", "cyber", 2, 200, 0);
            Console.WriteLine(p.ToString());
            Console.WriteLine();
            Console.WriteLine(e.ToString());
            Console.WriteLine();
            Console.WriteLine(w.ToString());
            Console.WriteLine();
            Console.WriteLine(s.ToString());
            Console.WriteLine();
            Console.WriteLine(s.CalcSalesManSalary());
            p.SetPerson("idan", "mor", 17, "23423432");
            Console.WriteLine(p.ToString());
        }
    }
}
