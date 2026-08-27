using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace BPersianCalendar
{
    public class ConvertDate
    {
        public int Year { get; set; }

        public int Month { get; set; }

        public int Day { get; set; }

        public ConvertDate()
        {
        }

        public ConvertDate(DateTime Date)
        {
            PersianCalendar persianCalendar = new PersianCalendar();
            Year = persianCalendar.GetYear(Date);
            Month = persianCalendar.GetMonth(Date);
            Day = persianCalendar.GetDayOfMonth(Date);
        }

        public string MiladiToShamsi(DateTime Mdate)
        {
            PersianCalendar persianCalendar = new PersianCalendar();
            string text = persianCalendar.GetYear(Mdate).ToString();
            string text2 = Convert.ToString(persianCalendar.GetMonth(Mdate));
            string text3 = Convert.ToString(persianCalendar.GetDayOfMonth(Mdate));
            if (text2.Length == 1)
            {
                text2 = "0" + text2;
            }

            if (text3.Length == 1)
            {
                text3 = "0" + text3;
            }

            string text4 = text;
            return text4 + "/" + text2 + "/" + text3;
        }

        public string func_PersianDateFormat(DateTime date)
        {
            PersianCalendar persianCalendar = new PersianCalendar();
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(persianCalendar.GetYear(date).ToString("0000"));
            stringBuilder.Append("/");
            stringBuilder.Append(persianCalendar.GetMonth(date).ToString("00"));
            stringBuilder.Append("/");
            stringBuilder.Append(persianCalendar.GetDayOfMonth(date).ToString("00"));
            return stringBuilder.ToString();
        }

        public void SetDate(DateTime Date)
        {
            PersianCalendar persianCalendar = new PersianCalendar();
            Year = persianCalendar.GetYear(Date);
            Month = persianCalendar.GetMonth(Date);
            Day = persianCalendar.GetDayOfMonth(Date);
        }

        public int getYear()
        {
            return Year;
        }

        public int getMounth()
        {
            return Month;
        }

        public int getDay()
        {
            return Day;
        }
    }
}
