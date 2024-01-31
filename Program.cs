using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F004_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Date a = new Date();
            a.PrintDate();

            Date b = new Date(2023, 1, 30);
            b.PrintDate();
           
            Date c = new Date(2030, 3, 25);
            c.PrintDate();
           
            Console.WriteLine("2030은 윤년이다 : {0}", Date.IsLeap(2030));
            //not static ver.
            //Console.WriteLine("2030은 윤년이다 : {0}", c.IsLeap(2030));
            Console.WriteLine(Math.Sin(Math.PI / 2));
        }
    }
    class Date
    {
        private int month, day;

        //public int Year { get; set; }
        public int year;

        public int Year
        {
            get { return year; }
            set
            {
                if (year >= 2000) year = value;
                else Console.WriteLine("year는 2000이상이어야 함");
            }
        }
        public int GetYear() { return this.year; }
        public void SetYear(int year) { this.year = year; }

        public int GetMonth() { return this.month; }
        public void SetMonth(int month) { this.month = month; }

        public int GetDay() { return this.day; }
        public void SetDay(int day) { this.day = day; }

        public void PrintDate()
        {
            Console.WriteLine("{0}년 {1}월 {2}일",
            this.year, this.month, this.day);
        }

        public Date(int y, int m, int d)
        {
            this.year = y;
            this.month = m;
            this.day = d;
        }

        public Date()
        {
            this.year = 1;
            this.month = 1;
            this.day = 1;
        }

        public static bool IsLeap(int year)
        {
            if (year % 100 == 0 && (year % 100 == 0 || year % 400 == 0))
                return true;
            else return false;
            // return year % 100 == 0 && (year % 100 == 0 || year % 400 == 0)
        }
    }
}