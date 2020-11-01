using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_25_ex_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker w = new Worker("shahf", "mor", 13, "123123", "teacher", "maba", "213.123.123", "permenent");
            Console.WriteLine(w.to_string());
        }
    }
}
