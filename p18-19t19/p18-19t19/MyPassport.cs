using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p18_19t19
{
    class MyPassport
    {
        private string Name;
        private static int NumberOfPassport;
        private int PasportNumber;
        private MyDate ExpiryDate;

        static MyPassport()
        {
            MyPassport.NumberOfPassport = 0;
        }

        public MyPassport()
        {
            this.Name = null;
            MyPassport.NumberOfPassport += 1;
            this.PasportNumber = MyPassport.NumberOfPassport;
            this.ExpiryDate = new MyDate();
        }

        public MyPassport(string n, MyDate ed)
        {
            this.Name = n;
            MyPassport.NumberOfPassport += 1;
            this.PasportNumber = MyPassport.NumberOfPassport;
            this.ExpiryDate = ed;
        }

        public MyPassport(MyPassport pass)
        {
            this.Name = pass.getn();
            this.PasportNumber = pass.getpn();
            this.ExpiryDate = pass.geted();
        }

        public string getn()
        {
            return this.Name;
        }

        public int getpn()
        {
            return this.PasportNumber;
        }

        public MyDate geted()
        {
            return this.ExpiryDate;
        }

        public void setname(string n)
        {
            this.Name = n;
        }

        public void seteExpiryDate(MyDate newExpiryDate)
        {
            this.ExpiryDate = newExpiryDate;
        }

        public string ToString()
        {
            return "Name : " + this.Name + "\nPasS.num : " + this.PasportNumber + "\nExp.date : " + this.ExpiryDate.ToString();
        }

        public bool isValid(MyDate dateChecked)
        {
            return this.ExpiryDate.before(dateChecked);
        }

    }
}
