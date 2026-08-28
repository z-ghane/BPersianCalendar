using BPersianCalendar.myClasses.dgv;
using BPersianCalendar.myClasses.dgvStyle;
using BPersianCalendar.myClasses.shamsi;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace BPersianCalendar
{
    public partial class Frm_BPersianCalendar : Form
    {
        // ******************** Variables ********************

        #region Variables

        // in addition to dcShamsi
        // we need this two monthNo and yearNo 
        // because it is supposed that 
        // if the selected dgvcell is empty 
        // then dcShmasi could be set to null
        // but meanwhile the month and year should be kept

        // shamsi month number --> An integer from 1 through 12
        private int _monthNo;
        private int _yearNo;  // shamsi year number

        private Cls_DateComponentsShamsi _dcShamsi_selectedDate = null;

        private int selectedRowIndex,
                    selectedColumnIndex;

        private string key;


        #endregion Variables


        // ******************** Properties ********************

        #region Properties

        private int MonthNo
        {
            get
            {
                return _monthNo;
            }
            set
            {
                if (value <= 0)
                {
                    _monthNo = 12;
                    YearNo--;
                }
                else
                {
                    if (value >= 13)
                    {
                        _monthNo = 1;
                        YearNo++;
                    }
                    else
                        _monthNo = value;
                }

                lbl_Month.Text = Cls_ShamsiStatic.
                    convertShamsiMonthNumberToName(_monthNo);
            }
        }


        private int YearNo
        {
            get
            {
                return _yearNo;
            }
            set
            {
                _yearNo = value;
                lbl_Year.Text = _yearNo.ToString();
            }
        }


        #region DcShamsi_selectedDate

        private Cls_DateComponentsShamsi DcShamsi_selectedDate
        {
            get
            {
                return _dcShamsi_selectedDate;
            }
            set
            {
                if (_dcShamsi_selectedDate != null)
                    _dcShamsi_selectedDate.ValueChanged -= DcShamsi_ValueChanged;

                _dcShamsi_selectedDate = value;

                if (_dcShamsi_selectedDate != null)
                    _dcShamsi_selectedDate.ValueChanged += DcShamsi_ValueChanged;

                fill_lbl_Dates();
            }
        }


        private void DcShamsi_ValueChanged(object sender, EventArgs e)
        {
            fill_lbl_Dates();
        }


        private void fill_lbl_Dates()
        {
            this.Text = "تقویم شمسی | تاریخ انتخاب شده :   ";
            lbl_Shamsi.Text = null;
            lbl_Miladi.Text = null;

            if (DcShamsi_selectedDate != null)
            {
                this.Text += " " + DcShamsi_selectedDate.getDateAsShortText_Persian();

                // --- Show Shamsi
                lbl_Shamsi.Text = DcShamsi_selectedDate.getDateAsShortText_Persian();

                // --- Show Miladi
                lbl_Miladi.Text = DcShamsi_selectedDate.getDateAsShortText_Gregorian();
            }
        }

        #endregion DcShamsi_selectedDate


        #endregion Properties


        // ******************** Constructors ********************

        #region Constructors

        public Frm_BPersianCalendar(Font fn)
        {
            InitializeComponent();

            InitializeDcShamsi();
            DcShamsi_selectedDate.SetVar();

            setFont(fn);
        }


        public Frm_BPersianCalendar(
            Font fn,
            int yearno,
            int monthno,
            int dayno)
        {
            InitializeComponent();

            InitializeDcShamsi();
            DcShamsi_selectedDate.SetVar(yearno, monthno, dayno);

            setFont(fn);
        }


        private void setFont(Font fn)
        {
            if (fn != null)
            {
                this.Font = fn;

                Font defaultSimpleFont = new Font(this.Font.FontFamily, 9f, FontStyle.Bold);
                
                tlp_WeekDays.Font = defaultSimpleFont;
            }
            else
            {
                Font defaultSimpleFont = new Font("Tahoma", 8.5f, FontStyle.Bold);
                this.Font = defaultSimpleFont;
            }
        }

        #endregion Constructors


        // ******************** Frm_BPersianCalendar ********************

        #region Frm_BPersianCalendar

        private void Frm_BPersianCalendar_Load(object sender, EventArgs e)
        {
            // ------ Design dgvs

            Cls_dgvCalendarStyle.Design_dgv_Calendar(dgv_Calendar);

            Cls_dgvYearMonthStyle.Design_dgv_YearMonth(
                dgv_SelectMonth, this.ClientSize.Height);

            Cls_dgvYearMonthStyle.Design_dgv_YearMonth(
                dgv_SelectYear, this.ClientSize.Height);

            // ------ 

            YearNo = DcShamsi_selectedDate.YearNo;
            MonthNo = DcShamsi_selectedDate.MonthNo;

            fillProcess_dgv_calendar(DcShamsi_selectedDate.DayNo);
            dgv_Calendar.Focus();
        }


        // *********************** dgv_Calendar ***********************

        // ----------------------- fillProcess_dgv_calendar 

        // yearNO, monthNo, and dcShamsi
        // should be set before calling this
        // just used when we want to update dgv
        private void fillProcess_dgv_calendar(int selectedDay)
        {
            Cls_dgvCalendar.Fill_dgv_Calendar(dgv_Calendar, YearNo, MonthNo);

            Cls_dgvCalendar.SelectCell_dgv_Calendar(
                dgv_Calendar,
                selectedDay,
                selectedRowIndex,
                selectedColumnIndex
                );
        }


        // *********************** setShamsiToCurrentCell ***********************

        private void setDateToCurrentCell()
        {
            selectedColumnIndex = dgv_Calendar.CurrentCell.ColumnIndex;
            selectedRowIndex = dgv_Calendar.CurrentCell.RowIndex;

            if (dgv_Calendar.CurrentCell.Value != null)
            {
                try
                {
                    string valueCurrent = dgv_Calendar.CurrentCell.Value.ToString();

                    if (string.IsNullOrEmpty(valueCurrent))
                    {
                        DcShamsi_selectedDate = null;
                    }
                    else
                    {
                        InitializeDcShamsi();

                        DcShamsi_selectedDate.SetVar(
                            YearNo, MonthNo,
                            int.Parse(valueCurrent)
                            );
                    }
                }
                catch (Exception)
                {
                    return;
                }
            }
        }

        #endregion frmCalander_Load


        // ******************** lblYear ********************

        #region lblYear

        private void lbl_Year_Click(object sender, EventArgs e)
        {
            //tlp_Whole.Dock = DockStyle.None;
            dgv_SelectYear.Dock = DockStyle.Fill;
            dgv_SelectYear.Visible = true;


            dgv_SelectYear.Focus();
            dgv_SelectYear.Select();
            btn_SelectPreviousYears.Visible = true;
            btn_SelectNextYears.Visible = true;
            btn_SelectNextYears.BringToFront();
            btn_SelectPreviousYears.BringToFront();

            Cls_dgvYearMonth.Fill_dgv_Year(dgv_SelectYear, "f", YearNo);
        }


        private void btn_SelectNextYears_Click(object sender, EventArgs e)
        {
            Cls_dgvYearMonth.Fill_dgv_Year(dgv_SelectYear, "ny", YearNo);
        }


        private void btn_SelectPreviousYears_Click(object sender, EventArgs e)
        {
            Cls_dgvYearMonth.Fill_dgv_Year(dgv_SelectYear, "py", YearNo);
        }


        private void dgv_SelectYear_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            YearNo = int.Parse(dgv_SelectYear[e.ColumnIndex, e.RowIndex].Value.ToString());

            //tlp_Whole.Dock = DockStyle.Bottom;
            dgv_SelectYear.Visible = false;
            btn_SelectPreviousYears.Visible = false;
            btn_SelectNextYears.Visible = false;

            fillProcess_dgv_calendar(0);
        }

        #endregion lblYear


        // ******************** btnNextY ********************

        #region btn Year

        private void btn_NextYear_Click(object sender, EventArgs e)
        {
            YearNo++;
            fillProcess_dgv_calendar(0);
        }


        private void btn_PreviousYear_Click(object sender, EventArgs e)
        {
            YearNo--;
            fillProcess_dgv_calendar(0);
        }


        #endregion btnNextY


        // ******************** lblMounth ********************

        #region lblMounth

        private void lbl_Month_Click(object sender, EventArgs e)
        {
            //tlp_Whole.Dock = DockStyle.None;
            dgv_SelectMonth.Dock = DockStyle.Fill;
            dgv_SelectMonth.Visible = true;


            dgv_SelectMonth.Focus();
            dgv_SelectMonth.Select();

            Cls_dgvYearMonth.Fill_dgv_Month(dgv_SelectMonth, lbl_Month);
        }


        private void dgv_SelectMonth_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MonthNo = e.RowIndex * 3 + e.ColumnIndex + 1;

            //tlp_Whole.Dock = DockStyle.Bottom;
            dgv_SelectMonth.Visible = false;

            fillProcess_dgv_calendar(0);
        }

        #endregion lblMounth


        // ******************** btnNextM ********************

        #region btn Month

        private void btn_NextMonth_Click(object sender, EventArgs e)
        {
            MonthNo++;
            fillProcess_dgv_calendar(0);
        }


        private void btn_PreviousMonth_Click(object sender, EventArgs e)
        {
            MonthNo--;
            fillProcess_dgv_calendar(0);
        }

        #endregion btnNextM


        // ******************** dgCalander ********************

        #region dgCalander

        private void dgv_Calendar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //FindCurrentCell();
        }


        private void dgv_Calendar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //FindCurrentCell();
        }


        private void dgv_Calendar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }


        private void dgv_Calendar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.Handled = true;

                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void dgv_Calendar_KeyPress(object sender, KeyPressEventArgs e)
        {
            key += e.KeyChar.ToString();
            if (key.Length > 2)
            {
                key = e.KeyChar.ToString();
            }

            Cls_dgvCalendar.SelectCell_dgv_Calendar(
                dgv_Calendar,
                int.Parse(key),
                selectedRowIndex,
                selectedColumnIndex
                );
        }


        private void dgv_Calendar_SelectionChanged(object sender, EventArgs e)
        {
            setDateToCurrentCell();
        }

        #endregion dgCalander


        // ******************** btns ********************

        #region btns

        private void btn_Today_Click(object sender, EventArgs e)
        {
            InitializeDcShamsi();
            DcShamsi_selectedDate.SetVar();
            MonthNo = DcShamsi_selectedDate.MonthNo; // An integer from 1 through 12
            YearNo = DcShamsi_selectedDate.YearNo;
            fillProcess_dgv_calendar(DcShamsi_selectedDate.DayNo);
        }


        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        #endregion btns


        // ==============================================================
        // ==============================================================
        //                          Public Methods
        // ==============================================================
        // ==============================================================

        /// <summary>
        /// Before using DcShamsi we have to be sure it's not null.
        /// If selected date is null, then initialize it first.
        /// </summary>
        public void InitializeDcShamsi()
        {
            if (DcShamsi_selectedDate == null)
                DcShamsi_selectedDate = new Cls_DateComponentsShamsi();
        }


        /// <summary>
        /// Returns the selected date
        /// </summary>
        public Cls_DateComponentsShamsi GetDCShamsiSelectedDate()
        {
            return _dcShamsi_selectedDate;
        }







    }
}
