using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p._22_23
{
    class PhoneBook
    {
        Entry[] enteries;
        int count;

        public PhoneBook(int size)
        {
            enteries = new Entry[size];
            count = 0;
        }

        public bool addEntry(Entry entry)
        {
            for (int i = 0; i <= this.enteries.Length - 1; i++)
            {
                
                if (this.enteries[i] == null)
                {
                    this.enteries[i] = new Entry(entry.getFirstName(), entry.getLastName(), entry.getPhoneNumber());
                    return true;
                }
                else if (entry.getFirstName().Equals(this.enteries[i].getFirstName()) && entry.getLastName().Equals(this.enteries[i].getLastName()))
                {
                    this.enteries[i].setPhoneNumber(entry.getPhoneNumber());
                    return true;
                }
                count++;
            }
            return false;
        }

        public bool deleteEntry(Entry entry)
        {
            Entry entry2 = null;
            for (int i = 0; i <= this.enteries.Length - 1; i++)
            {
                if (entry.getFirstName().Equals(this.enteries[i].getFirstName()) && entry.getLastName().Equals(this.enteries[i].getLastName()))
                {
                    for (int j = i + 1; j <= this.enteries.Length-1; j++)
                    {
                        entry2 = this.enteries[j];
                        this.enteries[i] = entry2;
                        enteries[j] = null;
                    }
                    return true;
                }
            }
            return false;
        }

        public string searchPhone(string firstName, string lastName)
        {
            for (int i = 0; i <= this.enteries.Length - 1; i++)
            {
                if (firstName.Equals(this.enteries[i].getFirstName()) && lastName.Equals(this.enteries[i].getLastName()))
                {
                    return this.enteries[i].getPhoneNumber();
                }
            }
            return null;
        }

        public string ToString()
        {
            string str = "";
            for (int i = 0; i<this.enteries.Length; i++)
            {
                if (enteries[i] != null)
                    str = str + enteries[i].ToString();
            }
            return str;
        }

        public Entry [] getEntries()
        {
            return this.enteries;
        }

        public int getCount()
        {
            return this.count;
        }
    }
}
