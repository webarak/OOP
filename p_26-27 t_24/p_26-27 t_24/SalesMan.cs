using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_26_27_t_24
{
    class SalesMan:Worker
    {
        private float bonus;

        public SalesMan(string first, string last, byte age, string id, string num, string dpt, float sal, float hours,float bonus) : base(first, last, age, id, num, dpt,sal,hours)
        {
            this.bonus = bonus;
        }

        public SalesMan():base()
        {
            this.bonus = 0;
        }

        public void SetSalesMan(string first, string last, byte age, string id, string num, string dpt, float sal, float hours, float bonus)  
        {
            base.Set_Worker(first, last, age, id, num, dpt, sal, hours);
            this.bonus = bonus;
        }

        public void SetSalesManSalary(float sal, float hours, float bonus)
        {
            this.bonus = bonus;
            base.set_salary(sal);
            base.set_month(hours);
        }

        public float CalcSalesManSalary()
        {
            return base.CalcWorkerSalary() + bonus;
        }

        public float Get_Bonus()
        {
            return this.bonus;
        }

        public override string ToString()
        {
            return base.ToString() + "\nBonus: " + this.bonus;
        }


    }
}
