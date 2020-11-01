using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date
{
    class MyDate
    {
        private int day;
        private int month;
        private int year;

        public MyDate(int d, int m, int y)//בנאי
        {
            
            if(y>=1000 && y<=9999)
            {
                this.year = y;
            }
            else
            {
                Console.WriteLine("wrong year");
            }
            if (m>=1 && m<=12)
            {
                this.month = m;
            }
            else
            {
                Console.WriteLine("wrong month");
            }
            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (d >= 1 && d <= 31)
                    {
                        this.day = d;
                    }
                    else
                    {
                        Console.WriteLine("wrong day");
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (d >= 1 && d <= 30)
                    {
                        this.day = d;
                    }
                    else
                    {
                        Console.WriteLine("wrong day");
                    }
                    break;
                case 2:
                    if ((this.year % 4 == 0 && this.year % 100 != 0) || this.year % 400 == 0)
                    {
                        if (d>=1 && d<=29)
                        {
                            this.day = d;
                        }
                        else
                        {
                            Console.WriteLine("wrong day");
                        }
                    }
                    else
                    {
                        if (d>=1 && d<=28)
                        {
                            this.day = d;
                        }
                        else
                        {
                            Console.WriteLine("wrong day");
                        }
                    }
                    break;
            }
        }
        public MyDate()//בנאי
        {
            this.year = 0;
            this.day = 0;
            this.month = 0;
        }

        public void set_year(int y)
        {
            if (y >= 1000 && y <= 9999)
            {
                this.year = y;
            }
            else
            {
                Console.WriteLine("wrong year");
            }
        }

        public void set_month(int m)
        {
            if (m >= 1 && m <= 12)
            {
                this.month = m;
            }
            else
            {
                Console.WriteLine("wrong month");
            }
        }

        public void set_day(int d)
        {

            switch (this.month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (d >= 1 && d <= 31)
                    {
                        this.day = d;
                    }
                    else
                    {
                        Console.WriteLine("wrong day");
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (d >= 1 && d <= 30)
                    {
                        this.day = d;
                    }
                    else
                    {
                        Console.WriteLine("wrong day");
                    }
                    break;
                case 2:
                    if ((this.year % 4 == 0 && this.year % 100 != 0) || this.year % 400 == 0)
                    {
                        if (d >= 1 && d <= 29)
                        {
                            this.day = d;
                        }
                        else
                        {
                            Console.WriteLine("wrong day");
                        }
                    }
                    else
                    {
                        if (d >= 1 && d <= 28)
                        {
                            this.day = d;
                        }
                        else
                        {
                            Console.WriteLine("wrong day");
                        }
                    }
                    break;
            }
        }

        public int get_year()
        {
            return this.year;
        }

        public int get_month()
        {
            return this.month;
        }

        public int get_day()
        {
            return this.day;
        }

        public bool before(MyDate d)
        {
            bool before = false;
            if (d.get_day()>1)
            {
                if ((d.get_day() == this.day + 1) && (d.get_month()==this.month)&& (d.get_year()==this.year))
                {
                    before = true;
                }
            }
            else if (d.get_day()==1)
            {
                if ((this.day==31) &&(d.get_month()-1 == this.month)&&(d.get_year()==this.year))
                {
                    before = true;
                }
                else if((this.day==31) &&( this.month==12)&& (this.year + 1 == d.get_year()))
                {
                    before = true;
                }
            }
            return before;
        }

        public string date()
        {
            
            string str = this.day + "/" + (this.month) + "/" + (this.year);
            return str;
        }
    }
}
