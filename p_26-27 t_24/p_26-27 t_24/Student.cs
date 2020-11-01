using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_26_27_t_24
{
    class Student:Person
    {
        private string StudentClass;
        private bool StudentTrend;
        private int MathMark;
        private int MathGroup;
        private int EnglishMark;
        private int EnglishGroup;
        private int HisMark;
        private int HisGroup;

        public Student():base()//בנאי מאפס
        {
            this.StudentClass = null;
            this.StudentTrend = false;
            this.MathMark = 0;
            this.MathGroup = 0;
            this.EnglishMark = 0;
            this.EnglishGroup = 0;
            this.HisMark = 0;
            this.HisGroup = 0;
        }
        public Student(string fn, string ln, byte age, string id,  string sc, bool st, int mm, int mg, int em, int eg, int hm, int hg):base(fn,ln,age,id)//בנאי מקבל ערכים
        {
            this.StudentClass = sc;
            this.StudentTrend = st;
            //math
            if (mm >= 0 && mm <= 100)
            {
                this.MathMark = mm;
            }
            else if (mm < 0 && mm >= -100)
            {
                this.MathMark = Math.Abs(mm);
            }
            else
            {
                this.MathMark = 100;
            }


            if (mg >= 3 && mg <= 5)
            {
                this.MathGroup = mg;
            }
            else
            {
                this.MathGroup = 3;
            }

            //english
            if (em >= 0 && em <= 100)
            {
                this.EnglishMark = em;
            }
            else if (em < 0 && em >= -100)
            {
                this.EnglishMark = Math.Abs(em);
            }
            else
            {
                this.EnglishMark = 100;
            }


            if (eg >= 3 && eg <= 5)
            {
                this.EnglishGroup = eg;
            }
            else
            {
                this.EnglishGroup = 3;
            }

            //history
            if (hm >= 0 && hm <= 100)
            {
                this.HisMark = hm;
            }
            else if (hm < 0 && hm >= -100)
            {
                this.HisMark = Math.Abs(hm);
            }
            else
            {
                this.HisMark = 100;
            }


            if (hg >= 3 && hg <= 5)
            {
                this.HisGroup = hg;
            }
            else
            {
                this.HisGroup = 3;
            }
        }
        
        public void SetStudentClass(string sc)//SET STUDENT CLASS
        {
            this.StudentClass = sc;
        }
        public void SetStudentTrend(bool st)// SET STUDENT TREND
        {
            this.StudentTrend = st;
        }

        public void SetMathMark(int mm)//SET STUDENT MATH MARK
        {
            if (mm >= 0 && mm <= 100)
            {
                this.MathMark = mm;
            }
            else if (mm < 0 && mm >= -100)
            {
                this.MathMark = Math.Abs(mm);
            }
            else
            {
                this.MathMark = 100;
            }
        }

        public void SetMathGroup(int mg)//SET STUDENT MATH GROUP
        {
            if (mg >= 3 && mg <= 5)
            {
                this.MathGroup = mg;
            }
            else
            {
                this.MathGroup = 3;
            }
        }

        public void SetEnglishMark(int em)//SET STUDENT ENGLISH MARK
        {
            if (em >= 0 && em <= 100)
            {
                this.EnglishMark = em;
            }
            else if (em < 0 && em >= -100)
            {
                this.EnglishMark = Math.Abs(em);
            }
            else
            {
                this.EnglishMark = 100;
            }

        }

        public void SetEnglishGroup(int eg)//SET STUDENT ENGLISH GROUP
        {
            if (eg >= 3 && eg <= 5)
            {
                this.EnglishGroup = eg;
            }
            else
            {
                this.EnglishGroup = 3;
            }
        }

        public void SetHistoryMark(int hm)//SET STUDENT HISTORY MARK
        {
            if (hm >= 0 && hm <= 100)
            {
                this.HisMark = hm;
            }
            else if (hm < 0 && hm >= -100)
            {
                this.HisMark = Math.Abs(hm);
            }
            else
            {
                this.HisMark = 100;
            }
        }

        public void SetHistoryGroup(int hg)//SET STUDENT HISTORY GROUP
        {
            if (hg >= 3 && hg <= 5)
            {
                this.HisGroup = hg;
            }
            else
            {
                this.HisGroup = 3;
            }
        }

        
        public string GetStudentClass()//GET STUDENT CLASS
        {
            return this.StudentClass;
        }
        public bool GetStudentTrend()//GET STUDENT TREND
        {
            return this.StudentTrend;
        }
        public int GetStudentMathMark()//GET STUDENT MATH MARK
        {
            return this.MathMark;
        }
        public int GetStudentMathGroup()//GET STUDENT MATH GROUP
        {
            return this.MathGroup;
        }
        public int GetStudentEnglishMark()//GET STUDENT ENGLISH MARK
        {
            return this.EnglishMark;
        }
        public int GetStudentEnglishGroup()//GET STUDENT ENGLISH GROUP
        {
            return this.EnglishGroup;
        }
        public int GetStudentHistoryMark()//GET STUDENT HISTORY MARK
        {
            return this.HisMark;
        }
        public int GetStudentHistoryGroup()//GET STUDENT HISTORY GROUP
        {
            return this.HisGroup;
        }



        public double AvgCalc()//מתודה המחזירה את ממוצע הציונים
        {
            double Avg = 0;
            double gradebonus = 0;
            //MATH
            if (this.MathGroup == 5)
            {
                gradebonus = this.MathMark;
                Avg = Avg + this.MathMark + gradebonus * 0.2;
            }
            else if (this.MathGroup == 4)
            {
                gradebonus = this.MathMark;
                Avg = Avg + this.MathMark + gradebonus * 0.1;
            }
            else
            {
                Avg = Avg + this.MathMark;
            }
            //ENGLISH
            if (this.EnglishGroup == 5)
            {
                gradebonus = this.EnglishMark;
                Avg = Avg + this.EnglishMark + gradebonus * 0.2;
            }
            else if (this.EnglishGroup == 4)
            {
                gradebonus = this.EnglishMark;
                Avg = Avg + this.EnglishMark + gradebonus * 0.1;
            }
            else
            {
                Avg = Avg + this.EnglishMark;
            }
            //HISTORY
            if (this.HisGroup == 5)
            {
                gradebonus = this.HisMark;
                Avg = Avg + this.HisMark + gradebonus * 0.2;
            }
            else if (this.HisGroup == 4)
            {
                gradebonus = this.HisMark;
                Avg = Avg + this.HisMark + gradebonus * 0.1;
            }
            else
            {
                Avg = Avg + this.HisMark;
            }

            return Avg / 3;
        }


        public void Show()//מדפיסה את נתוני התלמיד וציוניו
        {
            Console.WriteLine("student class:{0} ", this.StudentClass);
            if (this.StudentTrend)
            {
                Console.WriteLine("student trend: technology");
            }
            else
            {
                Console.WriteLine("student trend: academic");
            }
            Console.WriteLine("student math mark: {0} ", this.MathMark);
            Console.WriteLine("student math group:{0} ", this.MathGroup);
            Console.WriteLine("student English mark:{0} ", this.EnglishMark);
            Console.WriteLine("student English group:{0} ", this.EnglishGroup);
            Console.WriteLine("student History mark:{0} ", this.HisMark);
            Console.WriteLine("student History group:{0} ", this.HisGroup);
            Console.WriteLine("student avarage of grades:{0} ", this.AvgCalc());
        }


        public override string ToString()//To string
        {
            if (this.StudentTrend)
            {
                string str =  " class: " + this.StudentClass + ", trend: technology,  math mark: " + this.MathMark + ", math group: " + this.MathGroup + ", english mark: " + this.EnglishMark + ", english group" + this.EnglishGroup + ", history mark: " + this.HisMark + ", history group: " + this.HisGroup;
                return str;
            }
            else
            {
                string str = " class: " + this.StudentClass + ", trend: academic,  math mark: " + this.MathMark + ", math group: " + this.MathGroup + ", english mark: " + this.EnglishMark + ", english group" + this.EnglishGroup + ", history mark: " + this.HisMark + ", history group: " + this.HisGroup;
                return str;
            }

        }

        public double AvgCalc(double arba, double hamesh)//פעולה המחזירה את ממוצע הציונים לפי אחוזי בונוס שהמשתמש נותן
        {
            double Avg = 0;
            double gradebonus = 0;
            //MATH
            if (this.MathGroup == 5)
            {
                gradebonus = this.MathMark;
                Avg = Avg + this.MathMark + gradebonus * (hamesh/100);
            }
            else if (this.MathGroup == 4)
            {
                gradebonus = this.MathMark;
                Avg = Avg + this.MathMark + gradebonus * (arba/100);
            }
            else
            {
                Avg = Avg + this.MathMark;
            }
            //ENGLISH
            if (this.EnglishGroup == 5)
            {
                gradebonus = this.EnglishMark;
                Avg = Avg + this.EnglishMark + gradebonus * (hamesh/100);
            }
            else if (this.EnglishGroup == 4)
            {
                gradebonus = this.EnglishMark;
                Avg = Avg + this.EnglishMark + gradebonus * (arba/100);
            }
            else
            {
                Avg = Avg + this.EnglishMark;
            }
            //HISTORY
            if (this.HisGroup == 5)
            {
                gradebonus = this.HisMark;
                Avg = Avg + this.HisMark + gradebonus * (hamesh/100);
            }
            else if (this.HisGroup == 4)
            {
                gradebonus = this.HisMark;
                Avg = Avg + this.HisMark + gradebonus * (arba/100);
            }
            else
            {
                Avg = Avg + this.HisMark;
            }

            return Avg / 3;
        
        }


        public double AvgCalc(bool b)
        {
            if(b)
            {
                return AvgCalc();
            }
            else
            {
                double avg = 0;
                avg = this.EnglishMark + this.HisMark + this.MathMark;
                return avg / 3;
            }
        }
    }
}
