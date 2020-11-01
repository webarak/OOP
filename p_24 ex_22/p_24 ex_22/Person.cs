using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_24_ex_22
{
    class Person
    {
        private string first_Name;
        private string Last_Name;
        private byte age;
        private string ID;

        public Person()
        {
            this.first_Name = null;
            this.Last_Name = null;
            this.age = 0;
            this.ID = null;
        }

        public Person(string first, string last, byte age, string id)
        {
            this.first_Name = first;
            this.Last_Name = last;
            this.age= age;
            this.ID = id;
        }

        public void SetPerson(string first, string last, byte age, string id)
        {
            this.first_Name = first;
            this.Last_Name = last;
            this.age = age;
            this.ID = id;
        }

        public string Get_Name()
        {
            return this.first_Name + this.Last_Name;
        }

        public byte Get_Age()
        {
            return this.age;
        }

        public string Get_ID()
        {
            return this.ID;
        }

        public string ToString()
        { 
            return "First Name: " + this.first_Name + "\nLast Name: " + this.Last_Name + "\nAge: " + this.age + "\nID: " + this.ID;
        }
    }
}
