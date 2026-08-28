using System;


namespace BPersianCalendar.myClasses.shamsi
{
    internal class Cls_ShamsiStatic
    {

        public enum Month
        {
            January = 1,
            February = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12
        }


        // ********************************************************
        // convert shamsi month number to --> shamsi month name
        //convertShamsiMonthNumberToName
        public static string convertShamsiMonthNumberToName(
            int shamsiMonthNumber)
        {
            string[] shamsiMonthNames = new string[12] {
                "فروردین", "اردیبهشت", "خرداد",
                "تیر",     "مرداد",    "شهریور",
                "مهر",     "آبان",     "آذر",
                "دی",      "بهمن",     "اسفند"};

            return shamsiMonthNames[shamsiMonthNumber - 1];
        }


        // ********************************************************
        // convert miladi weekday name to --> shamsi weekday name
        public static string convertMiladiToShamsiWeekDayName(DayOfWeek dow)
        {
            string[] shamsiWeekDayNames = new string[7] {
                "یک شنبه",   // DayOfWeek.Sunday   : 0 --> یک شنبه
                "دو شنبه",   // DayOfWeek.Monday   : 1 --> دو شنبه
                "سه شنبه",   // DayOfWeek.Tuesday  : 2 --> سه شنبه
                "چهار شنبه", // DayOfWeek.Wednesday: 3 --> چهار شنبه
                "پنج شنبه",  // DayOfWeek.Thursday : 4 --> پنج شنبه
                "جمعه",      // DayOfWeek.Friday   : 5 --> جمعه
                "شنبه"       // DayOfWeek.Saturday : 6 --> شنبه
            };

            return shamsiWeekDayNames[(int)dow];
        }


        // ********************************************************
        // convert miladi weekday number to --> shamsi weekday number
        public static int convertMiladiToShamsiWeekDayNumber(DayOfWeek dow)
        {
            // DayOfWeek.Sunday   : 0 --> 1
            // DayOfWeek.Monday   : 1 --> 2
            // DayOfWeek.Tuesday  : 2 --> 3
            // DayOfWeek.Wednesday: 3 --> 4
            // DayOfWeek.Thursday : 4 --> 5
            // DayOfWeek.Friday   : 5 --> 6
            // DayOfWeek.Saturday : 6 --> 0
            // obviousely, we need 1 shift for each
            // 6 + 1 (shift) = 7
            // and then get the mod 7 of them

            //int temp = ((int)dow + 1) % 7;

            return ((int)dow + 1) % 7;
        }


        // ********************************************************
        //public static string convertToTwoDigitFormat(string myDigit)
        //{
        //    //myDigit.PadLeft(2,'0');
        //    //if (myDigit.Length == 1)
        //    //    myDigit = "0" + myDigit;
        //    // myDigit = (myDigit.Length == 1 ? "0" + myDigit : myDigit);
        //    return myDigit.PadLeft(2, '0');
        //}


        // ********************************************************
        // yyyy / mm / dd
        public static string getShortDateFormat(int myYear, int myMonth, int myDay)
        {
            // اگر چپ به راست چین شد باز هم تاریخ رو به ترتیب زیر نشون بده
            // yyyy / mm / dd
            char temp = '\u200F'; // کاراکتر پنهان

            string result = temp.ToString() +

                myDay.ToString().PadLeft(2, '0') +
                " / " + temp.ToString() +

                myMonth.ToString().PadLeft(2, '0') +
                " / " + temp.ToString() +

                myYear.ToString();

            return result;
        }




    }
}
