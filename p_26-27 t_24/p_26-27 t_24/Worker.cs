using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_26_27_t_24
{
    class Worker:Employee
    {
        private float sal_per_hour;
        private float monthly_working_hour;

        public Worker(string first, string last, byte age, string id, string num, string dpt, float sal, float hours) : base(first, last, age, id, num, dpt)
        {
            this.sal_per_hour = sal;
            this.monthly_working_hour = hours;
        }

        public Worker():base()
        {
            this.sal_per_hour = 0;
            this.monthly_working_hour = 0;
        }

        public void SetWorkerSalary(float s, float m)
        {
            this.sal_per_hour = s;
            this.monthly_working_hour = m;
        }

        public float CalcWorkerSalary()
        {
            return this.sal_per_hour * this.monthly_working_hour;
        }

        public void Set_Worker(string first, string last, byte age, string id, string num, string dpt, float sal, float hours)
        {
            base.Set_Employee(first, last, age, id, num, dpt);
            this.sal_per_hour = sal;
            this.monthly_working_hour = hours;
        }
        public void set_salary(float s)
        {
            this.sal_per_hour = s;
        }
        public void set_month(float m)
        {
            this.monthly_working_hour = m;
        }
        public float Get_Salary_PerHour()
        {
            return this.sal_per_hour;
        }

        public float Get_Monthly_WorkingHour()
        {
            return this.monthly_working_hour;
        }

        public override string ToString()
        {
            return base.ToString() + "\nSalary Per Hour: " + this.sal_per_hour + "\nMonthly Working Hour: " + this.monthly_working_hour;
        }
    }
}
