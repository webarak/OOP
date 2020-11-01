using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_25_ex_23
{
    class Worker:Person
    {
        private string GroupJob;
        private string dergi;
        private string Date;
        private string permenently;

        public Worker():base()
        {
            this.GroupJob = null;
            this.dergi = null;
            this.Date = null;
            this.permenently = null;
        }

        public Worker(string first, string last, byte age, string id, string gj, string d, string date, string per):base(first,last, age, id)
        {
            this.Date = date;
            this.dergi = d;
            this.GroupJob = gj;
            this.permenently = per;
        }

        public string to_string()
        {
            return base.ToString() + "\nGroup Job: " + this.GroupJob + "\nDegri: " + this.dergi + "\nDate: " + this.Date + "\nPermenently: " + this.permenently;
        }
    }
}
