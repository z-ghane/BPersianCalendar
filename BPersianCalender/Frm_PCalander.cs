using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Reflection.Emit;
using static System.Windows.Forms.AxHost;

namespace BPersianCalender
{


    public partial class frm_PCalander : Form
    {


        PersianCalendar pc = new PersianCalendar(); // دسترسی به کتابخونه تاریخ شمسی 
        private DateTime NowDate = DateTime.Now; // نگهدارنده تاریخ میلادی جاری

        static int monthName; // نام ماه
        static int YearName; // نام سال

        int selectedYear, //روز-ماه-سال انتخاب شده
            selectdMonth, 
            selectedDay;

        string sMonth;

        int rowIndex, columnIndex; // ایندکس ستون و ایندکس سطر

        string selectedShamsiDate; // تاریخ شمسی انتخاب شده
        DateTime selectedMiladiDate; // تاریخ میلادی انتخاب شده

        Cs_ShamsiCalander objShamsiCalander = new Cs_ShamsiCalander(); // کلاس نگهدارنده تاریخ

        static string key;


        // +++++++++++++++++++ Font Variables

        // --- method declaration

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]

        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);


        // --- myFontBold

        private PrivateFontCollection fonts2 = new PrivateFontCollection();
        Font myFontBold;
        Font myFontBold2;
        Font myFontBold3;

        // +++++++++++++++++++ End Font Variables




        // *************************** --- Constructors ---  ***************************

        public frm_PCalander()
        {
            InitializeComponent();

            monthName = pc.GetMonth(NowDate);
            YearName = pc.GetYear(NowDate);


            // --- Set Font
            fonts2 = myFonts("BNazanin");
            myFontBold = new Font(fonts2.Families[0], 9.5F, FontStyle.Bold);
            myFontBold2 = new Font(fonts2.Families[0], 10.5F, FontStyle.Bold);
            myFontBold3 = new Font(fonts2.Families[0], 11F, FontStyle.Bold);
        }


        private PrivateFontCollection myFonts(string resourceFontName)
        {
            // ----- variables

            PrivateFontCollection fonts = new PrivateFontCollection();
            byte[] fontData = (byte[])Properties.Resources.ResourceManager.GetObject(resourceFontName);
            uint dummy = 0;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            

            // ----- other

            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            fonts.AddMemoryFont(fontPtr, fontData.Length);
            AddFontMemResourceEx(fontPtr, (uint)fontData.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            return fonts;
        }



        // *********************** frm_PCalander_Load ***********************

        private void frm_PCalander_Load(object sender, EventArgs e)
        {
            this.RightToLeft = RightToLeft.Yes;

            setFont();

            // ------ Create Rows

            for (int i = 0; i < 4; i++)
            {
                dgv_Calander.Rows.Add();
                dgv_SelectMonth.Rows.Add();
                dgv_SelectYear.Rows.Add();
            }
            string temp = new Cs_DateComponentsShamsi(DateTime.Now).ShortDate_Persian();
            this.Text += " " + temp;

            Fill_dgv_Calendar();
            FindCurrentDate();


            // ---- get today date

            getDates();
        }


        public void setFont()
        {
            // +++++++ Set Font

            ////this.Font = myFontBold;

            lbl_Month.Font = myFontBold2;
            dgv_SelectMonth.Font = myFontBold2;

            lbl_Year.Font = myFontBold2;
            dgv_SelectYear.Font = myFontBold2;

            foreach (var item in pnl_WeekDays.Controls)
            {
                if (item is System.Windows.Forms.Label)
                {
                    ((System.Windows.Forms.Label)item).Font = myFontBold2;
                }
            }

            dgv_Calander.Font = myFontBold3;

            lbl_ShamsiDateTitle.Font = myFontBold;
            lbl_MiladiDateTitle.Font = myFontBold;

            lbl_Shamsi.Font = myFontBold2;
            lbl_Miladi.Font = myFontBold2;

            btn_Close.Font = myFontBold;
            btn_Today.Font = myFontBold;
        }


        // *********************** dgv_Calendar ***********************

        // ----------------------- Fill_dgv_Calendar -----------------------

        private void Fill_dgv_Calendar()
        {
            columnIndex = dgv_Calander.CurrentCell.ColumnIndex;
            rowIndex = dgv_Calander.CurrentCell.RowIndex;
            int DayOfWeekNameInMonth = 0;
            int daysInMonth = pc.GetDaysInMonth(YearName, monthName); // پیدا کردن تعدا روزهای ماه انتخاب شده

            for (int i = 1, d = 1, j = 0; i <= 5; i++, j++)
            {
                if (d == daysInMonth)
                {
                    break;
                }
                for (int x = 1; x <= 7; x++, d++)
                {
                    DateTime dtt = pc.ToDateTime(YearName, monthName, d, 1, 1, 1, 1, 1);
                    /////////////این قسمت جهت پیدا کردن اولین روز ماه استفاده میشه که مشخص میکنه اولین روز ماه از چه روزی شروع میشه

                    #region MyRegion
                    switch (pc.GetDayOfWeek(dtt))
                    {
                        case DayOfWeek.Saturday:
                            DayOfWeekNameInMonth = 0;
                            break;
                        case DayOfWeek.Sunday:
                            DayOfWeekNameInMonth = 1;
                            break;
                        case DayOfWeek.Monday:
                            DayOfWeekNameInMonth = 2;
                            break;
                        case DayOfWeek.Tuesday:
                            DayOfWeekNameInMonth = 3;
                            break;
                        case DayOfWeek.Wednesday:
                            DayOfWeekNameInMonth = 4;
                            break;
                        case DayOfWeek.Thursday:
                            DayOfWeekNameInMonth = 5;
                            break;
                        case DayOfWeek.Friday:
                            DayOfWeekNameInMonth = 6;
                            break;
                    }
                    #endregion

                    dgv_Calander.Rows[j].Cells["c" + DayOfWeekNameInMonth.ToString()].Value = pc.GetDayOfMonth(dtt);
                    if (DayOfWeekNameInMonth == 6)
                    {
                        dgv_Calander.Rows[j].Cells["c" + DayOfWeekNameInMonth.ToString()].Style.ForeColor = Color.Red;
                    }
                    if (DayOfWeekNameInMonth == 6)
                    {
                        d++;
                        break;

                    }
                    if (d == daysInMonth)
                    {
                        break;
                    }
                }
            }

            // /////////////////////////////////////////////////////////////////////
            //////////////////// از اینجا به بعد زمانی استفاده میشود که ماه 31 روزه یا 30 روزه باشد و شروع ماه از جمعه باشد(آخر خانه سط اول)
            /////////////////// که میاد به خونه های اول سطر یک اعداد رو اضافه میکنه
            int lastRowData = 0;
            if (dgv_Calander.Rows[4].Cells["c6"].Value != null)
            {
                if (!string.IsNullOrEmpty(dgv_Calander.Rows[4].Cells["c6"].Value.ToString()))
                {
                    lastRowData = int.Parse(dgv_Calander.Rows[4].Cells["c6"].Value.ToString());
                }

            }
            if (lastRowData != 31 && lastRowData != 0)
            {
                if (daysInMonth >= 29 && lastRowData >= 29)
                {
                    int RemainDay = daysInMonth - lastRowData;
                    for (int i = 0; i < RemainDay; i++)
                    {
                        dgv_Calander.Rows[0].Cells["c" + i.ToString()].Value = ++lastRowData;
                    }
                }

            }
            FindCurrentCell(); //بعد از پر کردن لیست روز جاری با این متد پیدا میشه
        }


        // ----------------------- FindCurrentCell() -----------------------

        private void FindCurrentCell()
        {
            if (dgv_Calander.CurrentCell.Value != null)
            {
                try
                {
                    if (!string.IsNullOrEmpty(dgv_Calander.CurrentCell.Value.ToString()))
                    {
                        this.Text = null;

                        selectedYear = YearName;
                        selectdMonth = monthName;
                        selectedDay = int.Parse(dgv_Calander.CurrentCell.Value.ToString());


                        Cs_DateComponentsShamsi objDCShamsi = new Cs_DateComponentsShamsi(selectedYear, selectdMonth, selectedDay);

                        // ----- Miladi
                        selectedMiladiDate = objDCShamsi.GetDateTime_Gregorian();
                        lbl_Miladi.Text = objDCShamsi.ShortDate_Gregorian();

                        // --- Shamsi
                        selectedShamsiDate = objDCShamsi.ShortDate_Persian();
                        lbl_Shamsi.Text = selectedShamsiDate;
                        this.Text = "تقویم شمسی | تاریخ انتخاب شده :   " + selectedShamsiDate;

                    }
                    else
                    {
                        selectedDay = 0;
                        selectdMonth = 0;
                        selectedYear = 0;

                        lbl_Shamsi.Text = null;
                        lbl_Miladi.Text = null;
                        selectedShamsiDate = null;
                        selectedMiladiDate = new DateTime();

                        this.Text = "تقویم شمسی | تاریخ انتخاب شده :   " + selectedShamsiDate;
                    }
                }
                catch (Exception)
                {
                    return;
                }

            }

        }


        // ----------------------- dgv_Calander -----------------------

        private void dgv_Calander_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(selectedShamsiDate))
                {
                    objShamsiCalander.MiladiDate = selectedMiladiDate;
                    objShamsiCalander.ShamsiDate = selectedShamsiDate;
                }
                else
                {
                    objShamsiCalander.MiladiDate = DateTime.Now;
                    objShamsiCalander.ShamsiDate = new Cs_DateComponentsShamsi(DateTime.Now).ShortDate_Persian();
                }
                this.Close();

            }
        }


        private void dgv_Calander_KeyPress(object sender, KeyPressEventArgs e)
        {
            key += e.KeyChar.ToString();
            if (key.Length > 2)
            {
                key = null;
            }
            for (int i = 0; i <= 4; i++)
            {
                for (int x = 0; x < 7; x++)
                {
                    if (dgv_Calander.Rows[i].Cells["c" + x.ToString()].Value.ToString() == key)
                    {
                        dgv_Calander.ClearSelection();
                        dgv_Calander.Rows[i].Cells["c" + x.ToString()].Selected = true;
                    }
                }
            }
        }


        private void dgv_Calander_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //fillItems(e);
            FindCurrentCell();
        }


        private void dgv_Calander_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            objShamsiCalander.MiladiDate = selectedMiladiDate;
            objShamsiCalander.ShamsiDate = selectedShamsiDate;
            this.Close();
        }


        private void dgv_Calander_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            FindCurrentCell();
        }


        private void dgv_Calander_SelectionChanged(object sender, EventArgs e)
        {
            //FindCurrentCell();
        }


        // ***********************   Month   ***********************

        // ----------------------- btn_NextMonth -----------------------

        private void btn_NextMonth_Click(object sender, EventArgs e)
        {
            if (monthName >= 12)
            {
                monthName = 0;
                NextYear();
            }
            monthName++;
            lbl_Month.Text = GetMonth(monthName);
            ResetCalender();
            Fill_dgv_Calendar();
            FindCurrentCell();
        }


        // ----------------------- btn_PreviousMonth -----------------------

        private void btn_PreviousMonth_Click(object sender, EventArgs e)
        {
            if (monthName <= 1)
            {
                monthName = 13;
                PrevYear();
            }
            monthName--;
            lbl_Month.Text = GetMonth(monthName);
            ResetCalender();
            Fill_dgv_Calendar();
            FindCurrentCell();
        }



        // ***********************   Select Month   ***********************

        // ----------------------- lbl_Month -----------------------

        private void lbl_Month_Click(object sender, EventArgs e)
        {
            dgv_SelectMonth.Dock = DockStyle.Fill;
            dgv_SelectMonth.Visible = true;
            FillMonth();
            dgv_SelectMonth.Focus();
            dgv_SelectMonth.Select();
        }


        // ----------------------- dgv_SelectMonth -----------------------

        private void FillMonth()
        {
            for (int i = 0, m = 1; i < 4; i++)
            {
                for (int j = 0; j < 3; j++, m++)
                {
                    dgv_SelectMonth[j, i].Value = GetMonth(m);
                    if (dgv_SelectMonth[j, i].Value.ToString() == lbl_Month.Text.ToString())
                    {
                        dgv_SelectMonth.ClearSelection();
                        dgv_SelectMonth[j, i].Selected = true;

                    }
                }
            }
        }

        
        private void dgv_SelectMonth_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string selectedCell = e.ColumnIndex.ToString() + e.RowIndex.ToString();
            switch (selectedCell)
            {
                case "00":
                    monthName = 1; 
                    lbl_Month.Text = GetMonth(1);
                    break;
                case "10":
                    monthName = 2; 
                    lbl_Month.Text = GetMonth(2);
                    break;
                case "20":
                    monthName = 3; 
                    lbl_Month.Text = GetMonth(3);
                    break;
                case "01":
                    monthName = 4; 
                    lbl_Month.Text = GetMonth(4);
                    break;
                case "11":
                    monthName = 5; 
                    lbl_Month.Text = GetMonth(5);
                    break;
                case "21":
                    monthName = 6; 
                    lbl_Month.Text = GetMonth(6);
                    break;
                case "02":
                    monthName = 7; 
                    lbl_Month.Text = GetMonth(7);
                    break;
                case "12":
                    monthName = 8; 
                    lbl_Month.Text = GetMonth(8);
                    break;
                case "22":
                    monthName = 9; 
                    lbl_Month.Text = GetMonth(9);
                    break;
                case "03":
                    monthName = 10; 
                    lbl_Month.Text = GetMonth(10);
                    break;
                case "13":
                    monthName = 11; 
                    lbl_Month.Text = GetMonth(11);
                    break;
                case "23":
                    monthName = 12; 
                    lbl_Month.Text = GetMonth(12);
                    break;
            }
            dgv_SelectMonth.Visible = false;
            ResetCalender();
            Fill_dgv_Calendar();
        }


        // ----------------------- GetMonth -----------------------

        #region GetMounth
        private string GetMonth(int Mounth)
        {
            string MounthName = string.Empty;
            switch (Mounth)
            {
                case 1:
                    MounthName = "فروردین";
                    break;
                case 2:
                    MounthName = "اردیبهشت";
                    break;
                case 3:
                    MounthName = "خرداد";
                    break;
                case 4:
                    MounthName = "تیر";
                    break;
                case 5:
                    MounthName = "مرداد";
                    break;
                case 6:
                    MounthName = "شهریور";
                    break;
                case 7:
                    MounthName = "مهر";
                    break;
                case 8:
                    MounthName = "آبان";
                    break;
                case 9:
                    MounthName = "آذر";
                    break;
                case 10:
                    MounthName = "دی";
                    break;
                case 11:
                    MounthName = "بهمن";
                    break;
                case 12:
                    MounthName = "اسفند";
                    break;
            }
            return MounthName;
        }

        #endregion



        // ***********************   Select Year   ***********************

        // ----------------------- lbl_Year -----------------------

        private void lbl_Year_Click(object sender, EventArgs e)
        {
            dgv_SelectYear.Dock = DockStyle.Fill;
            dgv_SelectYear.Visible = true;
            Fill_dgv_Year();
            dgv_SelectYear.Focus();
            dgv_SelectYear.Select();
            btn_SelectPreviousYears.Visible = true;
            btn_SelectNextYears.Visible = true;
            btn_SelectNextYears.BringToFront();
            btn_SelectPreviousYears.BringToFront();
        }


        // ----------------------- dgv_SelectYear -----------------------

        private void dgv_SelectYear_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            YearName = int.Parse(dgv_SelectYear[e.ColumnIndex, e.RowIndex].Value.ToString());
            lbl_Year.Text = YearName.ToString();
            ResetCalender();
            Fill_dgv_Calendar();

            btn_SelectPreviousYears.Visible = false;
            btn_SelectNextYears.Visible = false;

            dgv_SelectYear.Visible = false;
        }


        private void Fill_dgv_Year()
        {
            int currentYear = pc.GetYear(DateTime.Now);
            int PrevYears = currentYear - 6;
            for (int i = 0, m = PrevYears; i < 4; i++)
            {
                for (int j = 0; j < 3; j++, m++)
                {
                    dgv_SelectYear[j, i].Value = m;
                    if (dgv_SelectYear[j, i].Value.ToString() == YearName.ToString())
                    {
                        dgv_SelectYear.ClearSelection();
                        dgv_SelectYear[j, i].Selected = true;
                    }
                }
            }
        }


        // ----------------------- btn_SelectPreviousYears -----------------------

        private void btn_SelectPreviousYears_Click(object sender, EventArgs e)
        {
            int currentYear = int.Parse(dgv_SelectYear[0, 0].Value.ToString());
            int PrevYears = currentYear - 12;
            for (int i = 0, m = PrevYears; i < 4; i++)
            {
                for (int j = 0; j < 3; j++, m++)
                {
                    dgv_SelectYear[j, i].Value = m;
                }
            }
        }


        // ----------------------- btn_SelectNextYears -----------------------

        private void btn_SelectNextYears_Click(object sender, EventArgs e)
        {
            int currentYear = int.Parse(dgv_SelectYear[2, 3].Value.ToString());
            int PrevYears = currentYear + 1;
            for (int i = 0, m = PrevYears; i < 4; i++)
            {
                for (int j = 0; j < 3; j++, m++)
                {
                    dgv_SelectYear[j, i].Value = m;
                }
            }
        }


        // ***********************   Year   ***********************

        // ----------------------- btn_NextYear -----------------------

        private void btn_NextYear_Click(object sender, EventArgs e)
        {
            NextYear();
            ResetCalender();
            Fill_dgv_Calendar();
            FindCurrentCell();
        }


        // ----------------------- btn_PreviousYear -----------------------

        private void btn_PreviousYear_Click(object sender, EventArgs e)
        {
            PrevYear();
            ResetCalender();
            Fill_dgv_Calendar();
            FindCurrentCell();
        }

        // ----------------------- NextYear() -----------------------

        private void NextYear()
        {
            YearName++;
            lbl_Year.Text = YearName.ToString();
        }


        // ----------------------- PrevYear() -----------------------

        private void PrevYear()
        {
            YearName--;
            lbl_Year.Text = YearName.ToString();
        }


        // ***********************   btn_Today   ***********************

        private void btn_Today_Click(object sender, EventArgs e)
        {
            FindCurrentDate();
            getDates();
            string temp = new Cs_DateComponentsShamsi(DateTime.Now).ShortDate_Persian();
            this.Text = "تقویم شمسی | تاریخ انتخاب شده :   " + temp;
        }


        // ----------------------- getDates 

        private void getDates()
        {
            Cs_DateComponentsShamsi objDCShamsi = new Cs_DateComponentsShamsi(DateTime.Now);
            
            // --- Show Shamsi
            lbl_Shamsi.Text = objDCShamsi.ShortDate_Persian();

            // --- Show Miladi
            lbl_Miladi.Text = objDCShamsi.ShortDate_Gregorian();
        }


        // ***********************   btn_Close   ***********************

        private void btn_Close_Click(object sender, EventArgs e)
        {
            objShamsiCalander.MiladiDate = selectedMiladiDate;
            objShamsiCalander.ShamsiDate = selectedShamsiDate;
            this.Close();
        }


        // ***********************   Other Functions   ***********************

       

        // ----------------------- ResetCalender 

        private void ResetCalender()
        {
            for (int i = 0; i <= 4; i++)
            {
                for (int x = 0; x < 7; x++)
                {
                    dgv_Calander.Rows[i].Cells["c" + x.ToString()].Value = "";
                }
            }
        }


        // ----------------------- FindCurrentDate 

        private void FindCurrentDate()
        {
            int tYear, tMonth, tDay = 0;
            tYear = pc.GetYear(DateTime.Now);
            tMonth = pc.GetMonth(DateTime.Now);
            tDay = pc.GetDayOfMonth(DateTime.Now);
            monthName = tMonth;
            YearName = tYear;
            lbl_Year.Text = tYear.ToString();
            lbl_Month.Text = GetMonth(tMonth);
            ResetCalender();
            Fill_dgv_Calendar();
            for (int i = 0; i <= 4; i++)
            {
                for (int x = 0; x < 7; x++)
                {
                    if (dgv_Calander.Rows[i].Cells["c" + x.ToString()].Value.ToString() == tDay.ToString())
                    {
                        dgv_Calander.ClearSelection();
                        dgv_Calander.Rows[i].Cells["c" + x.ToString()].Selected = true;
                    }
                }
            }
        }


        //private void fillItems(DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0)
        //    {
        //        if (dgCalander.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
        //        {
        //            if (!string.IsNullOrEmpty(dgCalander.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()))
        //            {
        //                this.Text = null;
        //                selectedDay = int.Parse(dgCalander.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
        //                selectdMonth = monthName;
        //                selectedYear = YearName;
        //                selectedShamsiDate = selectedYear.ToString() + "/" +
        //                    (selectdMonth.ToString().Length == 1 ? "0" + selectdMonth.ToString() : selectdMonth.ToString()) + "/" +
        //                    (selectedDay.ToString().Length == 1 ? "0" + selectedDay.ToString() : selectedDay.ToString());
        //                this.Text = "تقویم شمسی | تاریخ انتخاب شده :   " + selectedShamsiDate;
        //                selectedMiladiDate = pc.ToDateTime(selectedYear, selectdMonth, selectedDay, 0, 0, 0, 0);
        //                lblShamsi.Text = selectedShamsiDate;
        //                lblMiladi.Text = selectedMiladiDate.ToShortDateString();
        //            }
        //            else
        //            {

        //            }

        //        }
        //    }
        //}


        // *********************** GetShamsiCalander : Show Dialog ***********************

        public Cs_ShamsiCalander GetShamsiCalander()
        {
            this.ShowDialog();
            return objShamsiCalander;
        }


    }

    

}
