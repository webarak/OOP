using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_24_ex_22
{
    class Employee : Person
    {
        private string emp_num;
        private string department;

        public Employee(string first, string last, byte age, string id, string num, string dpt) : base(first, last, age, id)
        {
            this.emp_num = num;
            this.department = dpt;
        }

        public Employee() : base()
        {
            this.emp_num = null;
            this.department = null;
        }

        public void Set_Employee(string first, string last, byte age, string id, string num, string dpt)
        {
            base.SetPerson(first, last, age, id);
            this.emp_num = num;
            this.department = dpt;
        }

        public string Get_EmpNum()
        {
            return emp_num;
        }

        public string Get_Department()
        {
            return department;
        }

        public string ToString()
        {
            return base.ToString() + "\nEmp Number: " + this.emp_num + "\nDepartment: " + this.department;
        }


    }
}
