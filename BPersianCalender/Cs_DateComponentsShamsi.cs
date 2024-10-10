using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace BPersianCalender
{

    // This class specify the components of a Date based on Shamsi Calendar 
    // and specify useful methods
    public class Cs_DateComponentsShamsi
    {
        public int yearNo; // سال شمسی
        public int monthNo; // ماه شمسی
        public int dayNo; // روز شمسی
        //public string dayOfWeek; // هفته شمسی



        // *************************** --- Constructors ---  ***************************

        public Cs_DateComponentsShamsi(int yearNo, int monthNo, int dayNo)
        {
            this.yearNo = yearNo;
            this.monthNo = monthNo;
            this.dayNo = dayNo;
        }


        public Cs_DateComponentsShamsi(DateTime dt)
        {
            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
            this.yearNo = pc.GetYear(dt);
            this.monthNo = pc.GetMonth(dt);
            this.dayNo = pc.GetDayOfMonth(dt);
        }


        // *************************** Date : ShortDat   ***************************

        public string ShortDate_Persian()
        {
            string result = ShortDate_Format(this.yearNo, this.monthNo, this.dayNo);
            return result;
        }

        public string ShortDate_Gregorian()
        {
            int[] dc_Gregorian = this.GetDateComponents_Gregorian();
            string result = ShortDate_Format(dc_Gregorian[0], dc_Gregorian[1], dc_Gregorian[2]);
            return result;
        }

        private string ShortDate_Format(int myYear, int myMonth, int myDay)
        {
            string result =
                myYear.ToString() + " / " +
                Cs_DateComponentsShamsi.ConvertToTwoDigitFormat(myMonth.ToString()) + " / " +
                Cs_DateComponentsShamsi.ConvertToTwoDigitFormat(myDay.ToString());
            return result;
        }


        // *************************** Date : LongDate_Persian   ***************************

        public string LongDate_Persian()
        {
            string result =
                GetDayOfWeek() + "، " +
                dayNo.ToString() + " " +
                PersianMonthName() + " " +
                yearNo.ToString();

            return result;
        }


        public string GetDayOfWeek()
        {
            DateTime dt_Miladi = GetDateTime_Gregorian();
            string dayOfWeek = Cs_DateComponentsShamsi.MiladiToShamsiWeekDay(dt_Miladi.DayOfWeek);
            return dayOfWeek;
        }


        private string PersianMonthName()
        {
            string[] temp_ShamsiMonthNames = new string[12] {
                "فروردین", "اردیبهشت", "خرداد",
                "تیر",     "مرداد",    "شهریور",
                "مهر",     "آبان",     "آذر",
                "دی",      "بهمن",     "اسفند"};
            return temp_ShamsiMonthNames[monthNo - 1];
        }


        // *************************** GetDateTime ***************************

        private DateTime GetDateTime_Persian()
        {
            PersianCalendar pc = new PersianCalendar();
            DateTime dt_Shamsi = new DateTime(yearNo, monthNo, dayNo, pc);
            return dt_Shamsi;
        }


        public DateTime GetDateTime_Gregorian()
        {
            int[] temp_seperatedMiladiDate = GetDateComponents_Gregorian();

            GregorianCalendar miladi = new GregorianCalendar();
            DateTime dt_Miladi = miladi.ToDateTime(
                temp_seperatedMiladiDate[0], // Year
                temp_seperatedMiladiDate[1], // Month
                temp_seperatedMiladiDate[2], // Day
                0, 0, 0, 0);

            return dt_Miladi;
        }


        // *************************** GetDateComponents_Gregorian ***************************

        // Gregorian calendar means: تقویم میلادی
        public int[] GetDateComponents_Gregorian()
        {
            int[] seperatedMiladiDate = new int[3];
            DateTime dt = GetDateTime_Persian();

            GregorianCalendar miladi = new GregorianCalendar();
            seperatedMiladiDate[0] = miladi.GetYear(dt);        // 0 : Year
            seperatedMiladiDate[1] = miladi.GetMonth(dt);       // 1 : Month
            seperatedMiladiDate[2] = miladi.GetDayOfMonth(dt);  // 2 : Day

            return seperatedMiladiDate;
        }


        // *************************** static ***************************

        public static string ConvertToTwoDigitFormat(string myDigit)
        {
            if (myDigit.Length == 1)
                myDigit = "0" + myDigit;
            // myDigit = (myDigit.Length == 1 ? "0" + myDigit : myDigit);
            return myDigit;
        }

        public static string MiladiToShamsiWeekDay(DayOfWeek dow)
        {
            string shamsiWeekDay;
            switch (dow)
            {
                case DayOfWeek.Saturday:
                    shamsiWeekDay = "شنبه";
                    break;
                case DayOfWeek.Sunday:
                    shamsiWeekDay = "یک شنبه";
                    break;
                case DayOfWeek.Monday:
                    shamsiWeekDay = "دو شنبه";
                    break;
                case DayOfWeek.Tuesday:
                    shamsiWeekDay = "سه شنبه";
                    break;
                case DayOfWeek.Wednesday:
                    shamsiWeekDay = "چهار شنبه";
                    break;
                case DayOfWeek.Thursday:
                    shamsiWeekDay = "پنج شنبه";
                    break;
                case DayOfWeek.Friday:
                    shamsiWeekDay = "جمعه";
                    break;
                default:
                    shamsiWeekDay = "";
                    break;
            }
            return shamsiWeekDay;
        }

    }
}
