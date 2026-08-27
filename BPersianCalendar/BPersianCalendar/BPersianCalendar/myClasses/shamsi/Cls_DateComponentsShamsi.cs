using System;
using System.Globalization;


namespace BPersianCalendar.myClasses.shamsi
{

    /// <summary>
    /// This class specify the components of a Date
    /// based on ** Shamsi ** Calendar 
    /// and has useful methods
    /// </summary>
    public class Cls_DateComponentsShamsi
    {
        // ******************** Variables ********************

        #region Variables

        public event EventHandler ValueChanged;

        /// <summary>
        /// shamsi yearNo
        /// </summary>
        public int YearNo { get; set; }


        /// <summary>
        /// shamsi monthNo
        /// </summary>
        public int MonthNo { get; set; }


        /// <summary>
        /// shamsi dayNo
        /// </summary>
        public int DayNo { get; set; }

        #endregion Variables


        // ******************** Consturctors ********************

        #region Consturctors

        /// <summary>
        /// set date to current system date (DateTime.Now)
        /// </summary>
        public Cls_DateComponentsShamsi()
        {
            SetVar();
        }

        ///// <param name = "myDateTime">
        ///// supposed to be geregorian
        ///// </param>
        //public cls_DateComponentsShamsi(DateTime myDateTime)
        //{
        //    setVar(dt);
        //}

        #endregion Consturctors


        // ==============================================================
        // ==============================================================
        //                      setVar Initialization
        // ==============================================================
        // ==============================================================

        #region SetVar Initialization

        /// <summary>
        /// The parameters are supposed to be shamsi 
        /// </summary>
        public void SetVar(
            int shamsiYearNo,
            int shamsiMonthNo,
            int shamsiDayNo
            )
        {
            if (shamsiYearNo > 0 & shamsiDayNo > 0 & shamsiMonthNo > 0)
            {
                this.YearNo = shamsiYearNo;
                this.MonthNo = shamsiMonthNo;
                this.DayNo = shamsiDayNo;

                ValueChanged?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                SetVar();
            }
        }


        /// <param name = "myDateTime">
        /// supposed to be geregorian
        /// </param>
        public void SetVar(DateTime myDateTime)
        {
            PersianCalendar pc = new PersianCalendar();

            this.YearNo = pc.GetYear(myDateTime);
            this.MonthNo = pc.GetMonth(myDateTime);
            this.DayNo = pc.GetDayOfMonth(myDateTime);

            ValueChanged?.Invoke(this, EventArgs.Empty);
        }


        /// <summary>
        /// Set date to current system date (DateTime.Now)
        /// </summary>
        public void SetVar()
        {
            SetVar(DateTime.Now);
        }

        #endregion setVar Initialization


        // ==============================================================
        // ==============================================================
        //                          setVar
        // ==============================================================
        // ==============================================================

        #region setVar

        // *************************** add ***************************

        /// <param name = "addDays">
        /// could be +positive or -negative
        /// </param>
        public void SetVar_AddDays(int addDays)
        {
            DateTime temp = getDateTime_Gregorian().AddDays(addDays);
            SetVar(temp);
        }


        /// <param name = "addMonths">
        /// could be +positive or -negative
        /// </param>
        public void setVar_AddMonths(int addMonths)
        {
            DateTime temp = getDateTime_Gregorian().AddMonths(addMonths);
            SetVar(temp);
        }


        /// <param name = "addYears">
        /// could be +positive or -negative
        /// </param>
        public void setVar_AddYears(int addYears)
        {
            DateTime temp = getDateTime_Gregorian().AddYears(addYears);
            SetVar(temp);
        }


        // *************************** first-last ***************************

        /// <summary>
        /// First Day Of the selected Month
        /// </summary>
        public void setVar_FirstDayOfMonth()
        {
            this.DayNo = 1;

            ValueChanged?.Invoke(this, EventArgs.Empty);
        }


        /// <summary>
        /// Last Day Of the selected Month
        /// </summary>
        public void setVar_LastDayOfMonth()
        {
            PersianCalendar pc = new PersianCalendar();

            this.DayNo = pc.GetDaysInMonth(
                this.YearNo,
                this.MonthNo);

            ValueChanged?.Invoke(this, EventArgs.Empty);
        }


        /// <summary>
        /// First Day Of the selected Year
        /// </summary>
        public void setVar_FirstDayOfYear()
        {
            this.MonthNo = 1;
            this.DayNo = 1;

            ValueChanged?.Invoke(this, EventArgs.Empty);
        }


        /// <summary>
        /// Last Day Of the selected Year
        /// </summary>
        public void setVar_LastDayOfYear()
        {
            this.MonthNo = 12;

            PersianCalendar pc = new PersianCalendar();

            this.DayNo = pc.GetDaysInMonth(
                this.YearNo,
                this.MonthNo);

            ValueChanged?.Invoke(this, EventArgs.Empty);
        }

        #endregion setVar



        // *************************** GetDateComponents_Gregorian ***************************

        /// <summary>
        /// Gregorian calendar means: تقویم میلادی
        /// </summary>
        private int[] getDateComponents_Gregorian()
        {
            int[] seperatedMiladiDate = new int[3];
            DateTime dt = getDateTime_Persian();

            GregorianCalendar miladi = new GregorianCalendar();
            seperatedMiladiDate[0] = miladi.GetYear(dt);        // 0 : Year
            seperatedMiladiDate[1] = miladi.GetMonth(dt);       // 1 : Month
            seperatedMiladiDate[2] = miladi.GetDayOfMonth(dt);  // 2 : Day

            return seperatedMiladiDate;
        }


        // ==============================================================
        // ==============================================================
        //                          ShortDate
        // ==============================================================
        // ==============================================================

        // ********************* ShortDate - Persian   *********************

        /// <summary>
        /// result: yyyy / mm / dd
        /// </summary>
        public string getDateAsShortText_Persian()
        {
            string result = Cls_ShamsiStatic.getShortDateFormat(
                this.YearNo, this.MonthNo, this.DayNo);

            return result;
        }


        // ********************* ShortDate - Gregorian   *********************

        /// <summary>
        /// result: yyyy / mm / dd
        /// </summary>
        public string getDateAsShortText_Gregorian()
        {
            // اگر تقویم ویندوز فارسی باشه
            // هرچند از شیء میلادی استفاده کنیم
            // اما خودکار به تاریخ شمسی تبدیل می‌شه
            //string result = GetDateTime_Gregorian().ToShortDateString();

            int[] dc_Gregorian = this.getDateComponents_Gregorian();

            string result = Cls_ShamsiStatic.getShortDateFormat(
                dc_Gregorian[0], dc_Gregorian[1], dc_Gregorian[2]);

            return result;
        }


        // ==============================================================
        // ==============================================================
        //                          LongDate
        // ==============================================================
        // ==============================================================

        // ********************* LongDate - Persian   *********************

        /// <summary>
        /// result: "dddd, d MMMM yyyy" 
        /// EX. یک شنبه، 14 فروردین 1404
        /// </summary>
        public string getDateAsLongText_Persian()
        {
            string result =
                getShamsiDayOfWeekName() + "، " +
                DayNo.ToString() + " " +
                Cls_ShamsiStatic.convertShamsiMonthNumberToName(MonthNo) + " " +
                YearNo.ToString();

            return result;
        }


        private string getShamsiDayOfWeekName()
        {
            DateTime dt_Miladi = getDateTime_Gregorian();
            string dayOfWeek = Cls_ShamsiStatic.convertMiladiToShamsiWeekDayName(
                dt_Miladi.DayOfWeek);
            return dayOfWeek;
        }


        // ********************* LongDate - Gregorian   *********************

        public string getDateAsLongText_Gregorian()
        {
            // اگر تقویم ویندوز فارسی باشه
            // هرچند از شیء میلادی استفاده کنیم
            // اما خودکار به تاریخ شمسی تبدیل می‌شه
            //string result = GetDateTime_Gregorian().ToShortDateString();

            DateTime dt_Miladi = getDateTime_Gregorian();

            int[] dc_Gregorian = this.getDateComponents_Gregorian();

            string result =
                (dt_Miladi.DayOfWeek).ToString() + "، " +
                dc_Gregorian[2].ToString() + " " +
                (Cls_ShamsiStatic.Month)dc_Gregorian[1] + " " +
                dc_Gregorian[0];
            
            return result;
        }


        // ==============================================================
        // ==============================================================
        //                          DateTime
        // ==============================================================
        // ==============================================================

        // ********************* DateTime - Persian   *********************

        public DateTime getDateTime_Persian()
        {
            PersianCalendar pc = new PersianCalendar();

            DateTime dt_Shamsi = new DateTime(
                YearNo, MonthNo, DayNo, pc);

            return dt_Shamsi;
        }


        // ********************* DateTime - Gregorian   *********************

        public DateTime getDateTime_Gregorian()
        {
            PersianCalendar pc = new PersianCalendar();

            DateTime dt_Miladi = pc.ToDateTime(
                this.YearNo,
                this.MonthNo,
                this.DayNo,
                0, 0, 0, 0);

            return dt_Miladi;
        }






    }
}
