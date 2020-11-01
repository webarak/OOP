using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p._22_23
{
    class Entry
    {
        private string firstName;
        private string lastName;
        private string phoneNumber;

        public Entry(string firstName, string lastName, string phoneNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
        }

        public Entry(Entry otherEntry)
        {
            this.firstName = otherEntry.getFirstName();
            this.lastName = otherEntry.getLastName();
            this.phoneNumber = otherEntry.getPhoneNumber();
        }

        public Entry()
        {
            this.firstName = null;
            this.lastName = null;
            this.phoneNumber = null;

        }

        public string getFirstName()
        {
            return this.firstName;
        }

        public string getLastName()
        {
            return this.lastName;
        }

        public string getPhoneNumber()
        {
            return this.phoneNumber;
        }

        public void setFirstName(string first)
        {
            this.firstName = first;
        }

        public void setLastName(string last)
        {
            this.lastName = last;
        }
        public void setPhoneNumber(string phone)
        {
            this.phoneNumber = phone;
        }
        public bool equals(Entry otherEntry)
        {
            if (otherEntry.getFirstName() == this.firstName && otherEntry.getLastName() == this.lastName)
                return true;
            else
                return false;
        }

        public string ToString()
        {
            return "First Name: "+ this.firstName+"\nLast Name: " + this.lastName+"\nTelephone Number: " + this.phoneNumber+"\n";
        }


    }
}
