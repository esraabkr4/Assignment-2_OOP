using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_OOP
{
    internal struct Date_Data
    {
		private int day;

		public int Day
		{
			get { return day; }
			set {day=value<=30?value:30; }
		}
		private int month;

		public int Month
		{
			get { return month; }
			set { month = month <= 12 ? value : 12; }
		}
		private int year;

		public int Year
		{
			get { return year; }
			set { year =value<= DateTime.Now.Year?value: DateTime.Now.Year; }
		}
        public Date_Data(int day,int month,int year)
        {
            this.day = day;
			this.month = month;
			this.year = year;
        }
        #region methods
        public override string ToString()
        {
            return $"{day}/{month}/{year}";
        }
        #endregion
    }
}
