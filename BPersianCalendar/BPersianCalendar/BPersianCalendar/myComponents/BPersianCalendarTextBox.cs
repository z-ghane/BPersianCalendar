using BPersianCalendar.myClasses.shamsi;
using BPersianCalendar.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace BPersianCalendar.myComponents
{
    public partial class BPersianCalendarTextBox : TextBox
    {

        // ******************** Variables ********************

        #region Variables

        private bool _longDateStyle = true;
        private bool _shamsiCalendar = true;
        private bool _defaultValueToToday = false;
        private Font _bpCalendarFont = null;
        private Button _calendarButton;

        // dcShamsi --> selected date
        private Cls_DateComponentsShamsi _dcShamsi = null;

        #endregion Variables


        // ******************** Properties ********************

        #region Properties

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        
        public Cls_DateComponentsShamsi DcShamsi
        {
            get
            {
                return _dcShamsi;
            }
            set
            {
                if (_dcShamsi != null)
                    _dcShamsi.ValueChanged -= DcShamsi_ValueChanged;


                _dcShamsi = value;


                if (_dcShamsi != null)
                    _dcShamsi.ValueChanged += DcShamsi_ValueChanged;

                FillTxt();
            }
        }


        private void DcShamsi_ValueChanged(object sender, EventArgs e)
        {
            FillTxt();
        }


        // ******************** solve .text = "" ********************

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override string Text
        {
            get => base.Text;
            set => base.Text = value;
        }


        public bool ShouldSerializeText()
        {
            return false;
        }

        #endregion Properties


        // ******************** Properties Panel ********************

        #region Properties Panel

        [Category("BPersianCalendar attribtues")]
        [Description(
            "how textbox show the date\n" +
            "true : long format \n"+
            "       dddd, d MMMM yyyy\n" +
            "       EX: یک شنبه، 14 فروردین 1404\n" +
            "false: short format \n" +
            "       yyyy / mm / dd \n"
            )]
        [DisplayName("BP LongDateStyle")]
        [DefaultValue(true)]
        public bool LongDateStyle
        {
            get
            {
                return _longDateStyle;
            }
            set
            {
                _longDateStyle = value;
                FillTxt();
            }
        }


        [Category("BPersianCalendar attribtues")]
        [Description("")]
        [DisplayName("BP ShamsiCalendar")]
        [DefaultValue(true)]
        public bool ShamsiCalendar
        {
            get
            {
                return _shamsiCalendar;
            }
            set
            {
                _shamsiCalendar = value;
                FillTxt();
            }
        }


        [Category("BPersianCalendar attribtues")]
        [Description("The default date value could be either today's date or null")]
        [DisplayName("BP DefaultValueToToday")]
        [DefaultValue(false)]
        public bool DefaultValueToToday
        {
            get
            {
                return _defaultValueToToday;
            }
            set
            {
                _defaultValueToToday = value;

                if (value)
                {
                    InitializeDcShamsi();
                    DcShamsi.SetVar();
                }
                else
                {
                    DcShamsi = null;
                }
            }
        }


        [Category("BPersianCalendar attribtues")]
        [Description("")]
        [DisplayName("BP CalendarFont")]
        public Font BpCalendarFont
        {
            get
            {
                return _bpCalendarFont;
            }
            set
            {
                _bpCalendarFont = value;
            }
        }

        #endregion Properties Panel


        // ******************** Constructors ********************

        #region Constructors

        public BPersianCalendarTextBox()
        {
            InitializeComponent();


            // ----- controlers

            SetTxtProperties();
            CreateButton();
            CreateContextMenuStrip();
        }


        // ******************** TxtBox ********************

        private void SetTxtProperties()
        {
            base.ReadOnly = true;
            base.TextAlign = HorizontalAlignment.Left;
        }


        // ==============================================================
        // ==============================================================
        //                          Button
        // ==============================================================
        // ==============================================================

        #region button

        private void CreateButton()
        {
            _calendarButton = new Button();

            // --- Properties

            _calendarButton.Size = new Size(
                Resources.img_png__calendar_20px.Width,
                Resources.img_png__calendar_20px.Height
            );

            _calendarButton.Cursor = Cursors.Hand;
            _calendarButton.Image = Resources.img_png__calendar_20px;
            _calendarButton.FlatStyle = FlatStyle.Flat;
            _calendarButton.FlatAppearance.BorderSize = 0;
            _calendarButton.FlatAppearance.MouseDownBackColor = Color.White;
            _calendarButton.FlatAppearance.MouseOverBackColor = Color.White;
            _calendarButton.FlatAppearance.CheckedBackColor = Color.White;

            // --- events
            _calendarButton.Click += btn_Click;

            // ---
            base.Controls.Add(_calendarButton);

            SetButtonPosition();
        }


        private void SetButtonPosition()
        {
            if (_calendarButton == null)
                return;

            if (RightToLeft == RightToLeft.Yes)
            {
                _calendarButton.Location = new Point(
                    ClientSize.Width - _calendarButton.Width + 1,
                    -3
                );
            }
            else
            {
                _calendarButton.Location = new Point(
                    -1,
                    -3
                );
            }
        }


        private void btn_Click(object sender, EventArgs e)
        {
            LoadCalender();
        }


        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(
            IntPtr hWnd, 
            int msg, 
            IntPtr wp, 
            IntPtr lp
            );

        #endregion button


        // ==============================================================
        // ==============================================================
        //                          ContextMenuStrip
        // ==============================================================
        // ==============================================================

        #region ContextMenuStrip

        private void CreateContextMenuStrip()
        {
            ContextMenuStrip contextMenuStrip = new ContextMenuStrip();

            contextMenuStrip.Font = this.Font;

            contextMenuStrip.Items.Add("خالی کردن");    
            contextMenuStrip.Items[0].Click += Null_Click;

            contextMenuStrip.Items.Add("-"); // cms.Items[1] --

            contextMenuStrip.Items.Add("امروز");
            contextMenuStrip.Items[2].Click += Today_Click;

            contextMenuStrip.Items.Add("روز بعد");
            contextMenuStrip.Items[3].Click += NextDay_Click;

            contextMenuStrip.Items.Add("روز قبل");
            contextMenuStrip.Items[4].Click += PrevDay_Click;

            contextMenuStrip.Items.Add("-"); // cms.Items[5] --

            contextMenuStrip.Items.Add("ماه قبل");
            contextMenuStrip.Items[6].Click += PrevMonth_Click;

            contextMenuStrip.Items.Add("ماه بعد");
            contextMenuStrip.Items[7].Click += NextMonth_Click;

            contextMenuStrip.Items.Add("-"); // cms.Items[8] --

            contextMenuStrip.Items.Add("سال قبل");
            contextMenuStrip.Items[9].Click += PrevYear_Click;

            contextMenuStrip.Items.Add("سال بعد");
            contextMenuStrip.Items[10].Click += NextYear_Click;

            contextMenuStrip.Items.Add("-"); // cms.Items[11] --

            contextMenuStrip.Items.Add("اول ماه جاری");
            contextMenuStrip.Items[12].Click += FirstDayOfMonth_Click;

            contextMenuStrip.Items.Add("آخر ماه جاری");
            contextMenuStrip.Items[13].Click += LastDayOfMonth_Click;

            contextMenuStrip.Items.Add("-"); // cms.Items[14] --

            contextMenuStrip.Items.Add("اول سال جاری");
            contextMenuStrip.Items[15].Click += FirstYear_Click;

            contextMenuStrip.Items.Add("آخر سال جاری");
            contextMenuStrip.Items[16].Click += LastYear_Click;

            contextMenuStrip.Items.Add("-"); // cms.Items[17] --

            contextMenuStrip.Items.Add("تقویم میلادی/فارسی");
            contextMenuStrip.Items[18].Click += SwitchCalendar_Click;

            contextMenuStrip.Items.Add("قالب تاریخ خلاصه/کامل");
            contextMenuStrip.Items[19].Click += SwitchDateStyle_Click;

            ContextMenuStrip = contextMenuStrip;
        }


        public void Null_Click(object sender, EventArgs e)
        {
            DcShamsi = null;
        }


        public void Today_Click(object sender, EventArgs e)
        {
            InitializeDcShamsi();
            DcShamsi.SetVar();
        }


        public void NextDay_Click(object sender, EventArgs e)
        {
            if(DcShamsi != null)
                DcShamsi.SetVar_AddDays(1);
        }


        public void PrevDay_Click(object sender, EventArgs e)
        {
            if (DcShamsi != null)
                DcShamsi.SetVar_AddDays(-1);
        }


        private void PrevMonth_Click(object sender, EventArgs e)
        {
            if (DcShamsi != null)
                DcShamsi.setVar_AddMonths(-1);
        }


        private void NextMonth_Click(object sender, EventArgs e)
        {
            if (DcShamsi != null)
                DcShamsi.setVar_AddMonths(1);
        }


        private void PrevYear_Click(object sender, EventArgs e)
        {
            if (DcShamsi != null)
                DcShamsi.setVar_AddYears(-1);
        }


        private void NextYear_Click(object sender, EventArgs e)
        {
            if (DcShamsi != null)
                DcShamsi.setVar_AddYears(1);
        }


        public void FirstDayOfMonth_Click(object sender, EventArgs e)
        {
            if(DcShamsi != null)
                DcShamsi.setVar_FirstDayOfMonth();
        }


        public void LastDayOfMonth_Click(object sender, EventArgs e)
        {
            if (DcShamsi != null)
                DcShamsi.setVar_LastDayOfMonth();
        }


        private void FirstYear_Click(object sender, EventArgs e)
        {
            if (DcShamsi != null)
                DcShamsi.setVar_FirstDayOfYear();
        }


        private void LastYear_Click(object sender, EventArgs e)
        {
            if (DcShamsi != null)
                DcShamsi.setVar_LastDayOfYear();
        }


        private void SwitchCalendar_Click(object sender, EventArgs e)
        {
            ShamsiCalendar = !ShamsiCalendar;
        }


        private void SwitchDateStyle_Click(object sender, EventArgs e)
        {
            LongDateStyle = !LongDateStyle;
        }

        #endregion ContextMenuStrip



        #endregion Constructors


        // ==============================================================
        // ==============================================================
        //                      override events
        // ==============================================================
        // ==============================================================

        #region events

        // If you press "Enter" the calendar will be shown
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                LoadCalender();
            }
        }


        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);

            SetTextMargins();
        }


        protected override void OnRightToLeftChanged(EventArgs e)
        {
            base.OnRightToLeftChanged(e);

            SetButtonPosition();
            SetTextMargins();
        }


        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            SetButtonPosition();
        }


        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);

            if (ContextMenuStrip != null)
                ContextMenuStrip.Font = this.Font;
        }


        // ******************** my functions for using in events ********************

        private void SetTextMargins()
        {
            if (!IsHandleCreated || _calendarButton.Width == 0)
                return;

            const int EM_SETMARGINS = 0x00D3;
            const int EC_LEFTMARGIN = 0x0001;
            const int EC_RIGHTMARGIN = 0x0002;

            int textMargin = 10;
            int buttonMargin = _calendarButton.Width + 5;

            int leftMargin;
            int rightMargin;

            if (RightToLeft == RightToLeft.Yes)
            {
                leftMargin = textMargin;
                rightMargin = buttonMargin;
            }
            else
            {
                leftMargin = buttonMargin;
                rightMargin = textMargin;
            }

            int margins = (rightMargin << 16) | leftMargin;

            SendMessage(
                Handle,
                EM_SETMARGINS,
                (IntPtr)(EC_LEFTMARGIN | EC_RIGHTMARGIN),
                (IntPtr)margins
            );
        }

        #endregion events


        // ==============================================================
        // ==============================================================
        //                      my functions
        // ==============================================================
        // ==============================================================

        #region functions

        private void LoadCalender()
        {
            Frm_BPersianCalendar tempp =
                DcShamsi == null ?
                    new Frm_BPersianCalendar(BpCalendarFont) :
                    new Frm_BPersianCalendar(
                        BpCalendarFont,
                        DcShamsi.YearNo,
                        DcShamsi.MonthNo,
                        DcShamsi.DayNo
                        );

            if (tempp.ShowDialog() == DialogResult.OK)
            {
                DcShamsi = tempp.GetDCShamsiSelectedDate();
            }
        }


        public void InitializeDcShamsi()
        {
            if (DcShamsi == null)
                DcShamsi = new Cls_DateComponentsShamsi();
        }


        private void FillTxt()
        {
            if (DcShamsi == null)
            {
                base.Text = "";
                return;
            }

            string newText;

            if (_shamsiCalendar)
            {
                newText = _longDateStyle
                    ? DcShamsi.getDateAsLongText_Persian()
                    : DcShamsi.getDateAsShortText_Persian();
            }
            else
            {
                newText = _longDateStyle
                    ? DcShamsi.getDateAsLongText_Gregorian()
                    : DcShamsi.getDateAsShortText_Gregorian();
            }

            base.Text = newText;
        }


        // ******************** Invoke ********************

        public void Invoke()
        {
            if (ShamsiCalendar)
                Today_Click(null, null);
        }

        #endregion functions

    }
}
