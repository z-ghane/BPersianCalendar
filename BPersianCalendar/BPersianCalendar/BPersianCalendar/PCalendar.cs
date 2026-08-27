using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;


namespace BPersianCalendar
{
    public class PCalendar : Form
    {
        private PersianCalendar pc = new PersianCalendar();

        private static int mounthName;

        private static int YearName;

        private int selectedYear;

        private int selectdMonth;

        private int selectedDay;

        private string sMonth;

        private int rowIndex;

        private int columnIndex;

        private string selectedShamsiDate;

        private DateTime selectedMiladiDate;

        private DateTime nDate;

        private ShamsiCalendar objshamsiCalander = new ShamsiCalendar();

        private static string key;

        private IContainer components = null;

        private DataGridView dgCalander;

        private DataGridViewTextBoxColumn c0;

        private DataGridViewTextBoxColumn c1;

        private DataGridViewTextBoxColumn c2;

        private DataGridViewTextBoxColumn c3;

        private DataGridViewTextBoxColumn c4;

        private DataGridViewTextBoxColumn c5;

        private DataGridViewTextBoxColumn c6;

        private Button btnPrevY;

        private Button btnPrevM;

        private Button btnNextY;

        private Label lblYear;

        private Button btnNextM;

        private Label lblMounth;

        private Label label1;

        private Label label2;

        private Label label3;

        private Label label4;

        private Label label5;

        private Label label6;

        private Label label7;

        private Panel panel1;

        private Label label8;

        private Label lblMiladi;

        private Label label9;

        private Label lblShamsi;

        private SMIO_DataGridView dgMonth;

        private DataGridViewTextBoxColumn Column1;

        private DataGridViewTextBoxColumn Column2;

        private DataGridViewTextBoxColumn Column3;

        private Button btnNextYears;

        private Button btnPrevYears;

        private Button button1;

        private Button button2;

        private Panel panel2;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

        private SMIO_DataGridView dgYear;

        public PCalendar(DateTime dt)
        {
            InitializeComponent();
            mounthName = pc.GetMonth(dt);
            YearName = pc.GetYear(dt);
            nDate = dt;
        }

        private void frmCalander_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                dgCalander.Rows.Add();
                dgMonth.Rows.Add();
                dgYear.Rows.Add();
            }

            Text = Text + " " + MiladiToShamsi(DateTime.Now);
            FillCalander();
            FindCurrentDate(nDate);
            getDates();
        }

        private void FillYear()
        {
            int year = pc.GetYear(DateTime.Now);
            int num = year - 6;
            int i = 0;
            int num2 = num;
            for (; i < 4; i++)
            {
                int num3 = 0;
                while (num3 < 3)
                {
                    dgYear[num3, i].Value = num2;
                    if (dgYear[num3, i].Value.ToString() == YearName.ToString())
                    {
                        dgYear.ClearSelection();
                        dgYear[num3, i].Selected = true;
                    }

                    num3++;
                    num2++;
                }
            }
        }

        private void FillMonth()
        {
            int i = 0;
            int num = 1;
            for (; i < 4; i++)
            {
                int num2 = 0;
                while (num2 < 3)
                {
                    dgMonth[num2, i].Value = getMounth(num);
                    if (dgMonth[num2, i].Value.ToString() == lblMounth.Text.ToString())
                    {
                        dgMonth.ClearSelection();
                        dgMonth[num2, i].Selected = true;
                    }

                    num2++;
                    num++;
                }
            }
        }

        public string MiladiToShamsi(DateTime Mdate)
        {
            string text = pc.GetYear(Mdate).ToString();
            string text2 = Convert.ToString(pc.GetMonth(Mdate));
            string text3 = Convert.ToString(pc.GetDayOfMonth(Mdate));
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

        private void FillCalander()
        {
            columnIndex = dgCalander.CurrentCell.ColumnIndex;
            rowIndex = dgCalander.CurrentCell.RowIndex;
            int num = 0;
            int daysInMonth = pc.GetDaysInMonth(YearName, mounthName);
            int num2 = 1;
            int num3 = 1;
            int num4 = 0;
            while (num2 <= 5 && num3 <= daysInMonth)
            {
                int num5 = 1;
                while (num5 <= 7)
                {
                    DateTime time = pc.ToDateTime(YearName, mounthName, num3, 1, 1, 1, 1, 1);
                    switch (pc.GetDayOfWeek(time))
                    {
                        case DayOfWeek.Saturday:
                            num = 0;
                            break;
                        case DayOfWeek.Sunday:
                            num = 1;
                            break;
                        case DayOfWeek.Monday:
                            num = 2;
                            break;
                        case DayOfWeek.Tuesday:
                            num = 3;
                            break;
                        case DayOfWeek.Wednesday:
                            num = 4;
                            break;
                        case DayOfWeek.Thursday:
                            num = 5;
                            break;
                        case DayOfWeek.Friday:
                            num = 6;
                            break;
                    }

                    dgCalander.Rows[num4].Cells["c" + num].Value = pc.GetDayOfMonth(time);
                    if (num == 6)
                    {
                        dgCalander.Rows[num4].Cells["c" + num].Style.ForeColor = Color.Red;
                    }

                    if (num == 6)
                    {
                        num3++;
                        break;
                    }

                    if (num3 == daysInMonth)
                    {
                        break;
                    }

                    num5++;
                    num3++;
                }

                num2++;
                num4++;
            }

            int num6 = 0;
            if (dgCalander.Rows[4].Cells["c6"].Value != null && !string.IsNullOrEmpty(dgCalander.Rows[4].Cells["c6"].Value.ToString()))
            {
                num6 = int.Parse(dgCalander.Rows[4].Cells["c6"].Value.ToString());
            }

            if (num6 != 31 && num6 != 0 && daysInMonth >= 29 && num6 >= 29)
            {
                int num7 = daysInMonth - num6;
                for (num2 = 0; num2 < num7; num2++)
                {
                    dgCalander.Rows[0].Cells["c" + num2].Value = ++num6;
                }
            }

            FindCurrentCell();
        }

        private void btnNextM_Click(object sender, EventArgs e)
        {
            if (mounthName >= 12)
            {
                mounthName = 0;
                NextYear();
            }

            mounthName++;
            lblMounth.Text = getMounth(mounthName);
            ResetCalender();
            FillCalander();
            FindCurrentCell();
        }

        private void btnPrevM_Click(object sender, EventArgs e)
        {
            if (mounthName <= 1)
            {
                mounthName = 13;
                PrevYear();
            }

            mounthName--;
            lblMounth.Text = getMounth(mounthName);
            ResetCalender();
            FillCalander();
            FindCurrentCell();
        }

        private void btnNextY_Click(object sender, EventArgs e)
        {
            NextYear();
            ResetCalender();
            FillCalander();
            FindCurrentCell();
        }

        private void ResetCalender()
        {
            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    dgCalander.Rows[i].Cells["c" + j].Value = "";
                }
            }
        }

        private void NextYear()
        {
            YearName++;
            lblYear.Text = YearName.ToString();
        }

        private void btnPrevY_Click(object sender, EventArgs e)
        {
            PrevYear();
            ResetCalender();
            FillCalander();
            FindCurrentCell();
        }

        private void PrevYear()
        {
            YearName--;
            lblYear.Text = YearName.ToString();
        }

        private void dgCalander_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FindCurrentCell();
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            FindCurrentDate(DateTime.Now);
            getDates();
            Text = "تقویم شمسی | تاریخ انتخاب شده :   " + MiladiToShamsi(DateTime.Now);
        }

        private void getDates()
        {
            lblShamsi.Text = MiladiToShamsi(DateTime.Now);
            lblMiladi.Text = DateTime.Now.ToShortDateString();
        }

        private void FindCurrentDate(DateTime dt)
        {
            int num = 0;
            int year = pc.GetYear(dt);
            int month = pc.GetMonth(dt);
            num = pc.GetDayOfMonth(dt);
            mounthName = month;
            YearName = year;
            lblYear.Text = year.ToString();
            lblMounth.Text = getMounth(month);
            ResetCalender();
            FillCalander();
            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (dgCalander.Rows[i].Cells["c" + j].Value.ToString() == num.ToString())
                    {
                        dgCalander.ClearSelection();
                        dgCalander.Rows[i].Cells["c" + j].Selected = true;
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            objshamsiCalander.MiladiDate = selectedMiladiDate;
            objshamsiCalander.ShamsiDate = selectedShamsiDate;
            Close();
        }

        public ShamsiCalendar getshamsiCalander()
        {
            ShowDialog();
            return objshamsiCalander;
        }

        private string getMounth(int Mounth)
        {
            string result = string.Empty;
            switch (Mounth)
            {
                case 1:
                    result = "فروردین";
                    break;
                case 2:
                    result = "اردیبهشت";
                    break;
                case 3:
                    result = "خرداد";
                    break;
                case 4:
                    result = "تیر";
                    break;
                case 5:
                    result = "مرداد";
                    break;
                case 6:
                    result = "شهریور";
                    break;
                case 7:
                    result = "مهر";
                    break;
                case 8:
                    result = "آبان";
                    break;
                case 9:
                    result = "آذر";
                    break;
                case 10:
                    result = "دی";
                    break;
                case 11:
                    result = "بهمن";
                    break;
                case 12:
                    result = "اسفند";
                    break;
            }

            return result;
        }

        private void dgCalander_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            objshamsiCalander.MiladiDate = selectedMiladiDate;
            objshamsiCalander.ShamsiDate = selectedShamsiDate;
            Close();
        }

        private void dgCalander_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (!string.IsNullOrEmpty(selectedShamsiDate))
                {
                    objshamsiCalander.MiladiDate = selectedMiladiDate;
                    objshamsiCalander.ShamsiDate = selectedShamsiDate;
                }
                else
                {
                    objshamsiCalander.MiladiDate = DateTime.Now;
                    objshamsiCalander.ShamsiDate = MiladiToShamsi(DateTime.Now);
                }

                Close();
            }
        }

        private void dgCalander_SelectionChanged(object sender, EventArgs e)
        {
        }

        private void FindCurrentCell()
        {
            if (dgCalander.CurrentCell.Value == null)
            {
                return;
            }

            try
            {
                if (!string.IsNullOrEmpty(dgCalander.CurrentCell.Value.ToString()))
                {
                    Text = null;
                    selectedDay = int.Parse(dgCalander.CurrentCell.Value.ToString());
                    selectdMonth = mounthName;
                    selectedYear = YearName;
                    selectedShamsiDate = selectedYear + "/" + ((selectdMonth.ToString().Length == 1) ? ("0" + selectdMonth) : selectdMonth.ToString()) + "/" + ((selectedDay.ToString().Length == 1) ? ("0" + selectedDay) : selectedDay.ToString());
                    Text = "تقویم شمسی | تاریخ انتخاب شده :   " + selectedShamsiDate;
                    selectedMiladiDate = pc.ToDateTime(selectedYear, selectdMonth, selectedDay, 0, 0, 0, 0);
                    lblShamsi.Text = selectedShamsiDate;
                    lblMiladi.Text = selectedMiladiDate.ToShortDateString();
                }
                else
                {
                    selectedDay = 0;
                    selectdMonth = 0;
                    selectedYear = 0;
                    lblShamsi.Text = null;
                    lblMiladi.Text = null;
                    selectedShamsiDate = null;
                    selectedMiladiDate = default(DateTime);
                    Text = "تقویم شمسی | تاریخ انتخاب شده :   " + selectedShamsiDate;
                }
            }
            catch (Exception)
            {
            }
        }

        private void dgCalander_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            FindCurrentCell();
        }

        private void dgCalander_KeyPress(object sender, KeyPressEventArgs e)
        {
            key += e.KeyChar;
            if (key.Length > 2)
            {
                key = null;
            }

            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (dgCalander.Rows[i].Cells["c" + j].Value.ToString() == key)
                    {
                        dgCalander.ClearSelection();
                        dgCalander.Rows[i].Cells["c" + j].Selected = true;
                    }
                }
            }
        }

        private void lblMounth_Click(object sender, EventArgs e)
        {
            dgMonth.Dock = DockStyle.Fill;
            dgMonth.Visible = true;
            FillMonth();
            dgMonth.Focus();
            dgMonth.Select();
        }

        private void dgMonth_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex.ToString() + e.RowIndex)
            {
                case "00":
                    mounthName = 1;
                    lblMounth.Text = getMounth(1);
                    break;
                case "10":
                    mounthName = 2;
                    lblMounth.Text = getMounth(2);
                    break;
                case "20":
                    mounthName = 3;
                    lblMounth.Text = getMounth(3);
                    break;
                case "01":
                    mounthName = 4;
                    lblMounth.Text = getMounth(4);
                    break;
                case "11":
                    mounthName = 5;
                    lblMounth.Text = getMounth(5);
                    break;
                case "21":
                    mounthName = 6;
                    lblMounth.Text = getMounth(6);
                    break;
                case "02":
                    mounthName = 7;
                    lblMounth.Text = getMounth(7);
                    break;
                case "12":
                    mounthName = 8;
                    lblMounth.Text = getMounth(8);
                    break;
                case "22":
                    mounthName = 9;
                    lblMounth.Text = getMounth(9);
                    break;
                case "03":
                    mounthName = 10;
                    lblMounth.Text = getMounth(10);
                    break;
                case "13":
                    mounthName = 11;
                    lblMounth.Text = getMounth(11);
                    break;
                case "23":
                    mounthName = 12;
                    lblMounth.Text = getMounth(12);
                    break;
            }

            dgMonth.Visible = false;
            ResetCalender();
            FillCalander();
        }

        private void lblYear_Click(object sender, EventArgs e)
        {
            dgYear.Dock = DockStyle.Fill;
            dgYear.Visible = true;
            FillYear();
            dgYear.Focus();
            dgYear.Select();
            btnPrevYears.Visible = true;
            btnNextYears.Visible = true;
            btnNextYears.BringToFront();
            btnPrevYears.BringToFront();
        }

        private void dgYear_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            YearName = int.Parse(dgYear[e.ColumnIndex, e.RowIndex].Value.ToString());
            lblYear.Text = YearName.ToString();
            ResetCalender();
            FillCalander();
            btnPrevYears.Visible = false;
            btnNextYears.Visible = false;
            dgYear.Visible = false;
        }

        private void btnNextYears_Click(object sender, EventArgs e)
        {
            int num = int.Parse(dgYear[2, 3].Value.ToString());
            int num2 = num + 1;
            int i = 0;
            int num3 = num2;
            for (; i < 4; i++)
            {
                int num4 = 0;
                while (num4 < 3)
                {
                    dgYear[num4, i].Value = num3;
                    num4++;
                    num3++;
                }
            }
        }

        private void btnPrevYears_Click(object sender, EventArgs e)
        {
            int num = int.Parse(dgYear[0, 0].Value.ToString());
            int num2 = num - 12;
            int i = 0;
            int num3 = num2;
            for (; i < 4; i++)
            {
                int num4 = 0;
                while (num4 < 3)
                {
                    dgYear[num4, i].Value = num3;
                    num4++;
                    num3++;
                }
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgCalander = new System.Windows.Forms.DataGridView();
            this.c0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMounth = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMiladi = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblShamsi = new System.Windows.Forms.Label();
            this.btnPrevYears = new System.Windows.Forms.Button();
            this.btnNextYears = new System.Windows.Forms.Button();
            this.btnPrevY = new System.Windows.Forms.Button();
            this.btnPrevM = new System.Windows.Forms.Button();
            this.btnNextY = new System.Windows.Forms.Button();
            this.btnNextM = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgYear = new BPersianCalendar.SMIO_DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgMonth = new BPersianCalendar.SMIO_DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)this.dgCalander).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)this.dgYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.dgMonth).BeginInit();
            base.SuspendLayout();
            this.dgCalander.AllowUserToDeleteRows = false;
            this.dgCalander.AllowUserToResizeColumns = false;
            this.dgCalander.AllowUserToResizeRows = false;
            this.dgCalander.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCalander.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgCalander.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgCalander.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgCalander.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle.BackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle.Font = new System.Drawing.Font("Tahoma", 8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            dataGridViewCellStyle.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCalander.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
            this.dgCalander.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgCalander.ColumnHeadersVisible = false;
            this.dgCalander.Columns.AddRange(this.c0, this.c1, this.c2, this.c3, this.c4, this.c5, this.c6);
            this.dgCalander.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCalander.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgCalander.Location = new System.Drawing.Point(0, 66);
            this.dgCalander.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dgCalander.MultiSelect = false;
            this.dgCalander.Name = "dgCalander";
            this.dgCalander.ReadOnly = true;
            this.dgCalander.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgCalander.RowHeadersVisible = false;
            this.dgCalander.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgCalander.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgCalander.RowTemplate.Height = 18;
            this.dgCalander.RowTemplate.ReadOnly = true;
            this.dgCalander.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCalander.Size = new System.Drawing.Size(323, 96);
            this.dgCalander.StandardTab = true;
            this.dgCalander.TabIndex = 0;
            this.dgCalander.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgCalander_CellClick);
            this.dgCalander.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgCalander_CellDoubleClick);
            this.dgCalander.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(dgCalander_CellEnter);
            this.dgCalander.SelectionChanged += new System.EventHandler(dgCalander_SelectionChanged);
            this.dgCalander.KeyDown += new System.Windows.Forms.KeyEventHandler(dgCalander_KeyDown);
            this.dgCalander.KeyPress += new System.Windows.Forms.KeyPressEventHandler(dgCalander_KeyPress);
            this.c0.HeaderText = "ش";
            this.c0.Name = "c0";
            this.c0.ReadOnly = true;
            this.c1.HeaderText = "1ش";
            this.c1.Name = "c1";
            this.c1.ReadOnly = true;
            this.c2.HeaderText = "2ش";
            this.c2.Name = "c2";
            this.c2.ReadOnly = true;
            this.c3.HeaderText = "3ش";
            this.c3.Name = "c3";
            this.c3.ReadOnly = true;
            this.c4.HeaderText = "4ش";
            this.c4.Name = "c4";
            this.c4.ReadOnly = true;
            this.c5.HeaderText = "5ش";
            this.c5.Name = "c5";
            this.c5.ReadOnly = true;
            this.c6.HeaderText = "ج";
            this.c6.Name = "c6";
            this.c6.ReadOnly = true;
            this.lblYear.BackColor = System.Drawing.Color.Transparent;
            this.lblYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblYear.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            this.lblYear.Location = new System.Drawing.Point(31, 14);
            this.lblYear.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(45, 24);
            this.lblYear.TabIndex = 9;
            this.lblYear.Text = "1393";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblYear.Click += new System.EventHandler(lblYear_Click);
            this.lblMounth.BackColor = System.Drawing.Color.Transparent;
            this.lblMounth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMounth.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            this.lblMounth.Location = new System.Drawing.Point(223, 12);
            this.lblMounth.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMounth.Name = "lblMounth";
            this.lblMounth.Size = new System.Drawing.Size(71, 22);
            this.lblMounth.TabIndex = 10;
            this.lblMounth.Text = "مهر";
            this.lblMounth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMounth.Click += new System.EventHandler(lblMounth_Click);
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "شنبه";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "1شنبه";
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "2شنبه";
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "3شنبه";
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "4شنبه";
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "5شنبه";
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "جمعه";
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 22);
            this.panel1.TabIndex = 13;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            this.label8.Location = new System.Drawing.Point(219, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 22);
            this.label8.TabIndex = 10;
            this.label8.Text = "تاریخ میلادی:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMiladi.BackColor = System.Drawing.Color.Transparent;
            this.lblMiladi.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            this.lblMiladi.Location = new System.Drawing.Point(111, 28);
            this.lblMiladi.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMiladi.Name = "lblMiladi";
            this.lblMiladi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblMiladi.Size = new System.Drawing.Size(106, 22);
            this.lblMiladi.TabIndex = 10;
            this.lblMiladi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            this.label9.Location = new System.Drawing.Point(194, 1);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 22);
            this.label9.TabIndex = 10;
            this.label9.Text = "تاریخ شمسی:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblShamsi.BackColor = System.Drawing.Color.Transparent;
            this.lblShamsi.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            this.lblShamsi.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblShamsi.Location = new System.Drawing.Point(108, 1);
            this.lblShamsi.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblShamsi.Name = "lblShamsi";
            this.lblShamsi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblShamsi.Size = new System.Drawing.Size(109, 22);
            this.lblShamsi.TabIndex = 10;
            this.lblShamsi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrevYears.BackColor = System.Drawing.Color.White;
            this.btnPrevYears.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevYears.FlatAppearance.BorderSize = 0;
            this.btnPrevYears.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnPrevYears.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnPrevYears.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevYears.Image = BPersianCalendar.Properties.Resources.img_png__toLeft_16px;
            this.btnPrevYears.Location = new System.Drawing.Point(3, 2);
            this.btnPrevYears.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnPrevYears.Name = "btnPrevYears";
            this.btnPrevYears.Size = new System.Drawing.Size(30, 27);
            this.btnPrevYears.TabIndex = 16;
            this.btnPrevYears.UseVisualStyleBackColor = false;
            this.btnPrevYears.Visible = false;
            this.btnPrevYears.Click += new System.EventHandler(btnPrevYears_Click);
            this.btnNextYears.BackColor = System.Drawing.Color.White;
            this.btnNextYears.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextYears.FlatAppearance.BorderSize = 0;
            this.btnNextYears.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnNextYears.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnNextYears.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextYears.Image = BPersianCalendar.Properties.Resources.img_png__toRight_16px;
            this.btnNextYears.Location = new System.Drawing.Point(292, 3);
            this.btnNextYears.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnNextYears.Name = "btnNextYears";
            this.btnNextYears.Size = new System.Drawing.Size(30, 27);
            this.btnNextYears.TabIndex = 8;
            this.btnNextYears.UseVisualStyleBackColor = false;
            this.btnNextYears.Visible = false;
            this.btnNextYears.Click += new System.EventHandler(btnNextYears_Click);
            this.btnPrevY.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevY.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevY.FlatAppearance.BorderSize = 0;
            this.btnPrevY.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPrevY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPrevY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevY.Image = BPersianCalendar.Properties.Resources.img_png__toLeft_16px;
            this.btnPrevY.Location = new System.Drawing.Point(0, 11);
            this.btnPrevY.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnPrevY.Name = "btnPrevY";
            this.btnPrevY.Size = new System.Drawing.Size(30, 27);
            this.btnPrevY.TabIndex = 5;
            this.btnPrevY.UseVisualStyleBackColor = false;
            this.btnPrevY.Click += new System.EventHandler(btnPrevY_Click);
            this.btnPrevM.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrevM.FlatAppearance.BorderSize = 0;
            this.btnPrevM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPrevM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPrevM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevM.Image = BPersianCalendar.Properties.Resources.img_png__toLeft_16px;
            this.btnPrevM.Location = new System.Drawing.Point(198, 11);
            this.btnPrevM.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnPrevM.Name = "btnPrevM";
            this.btnPrevM.Size = new System.Drawing.Size(30, 27);
            this.btnPrevM.TabIndex = 6;
            this.btnPrevM.UseVisualStyleBackColor = false;
            this.btnPrevM.Click += new System.EventHandler(btnPrevM_Click);
            this.btnNextY.BackColor = System.Drawing.Color.Transparent;
            this.btnNextY.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextY.FlatAppearance.BorderSize = 0;
            this.btnNextY.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNextY.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNextY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextY.Image = BPersianCalendar.Properties.Resources.img_png__toRight_16px;
            this.btnNextY.Location = new System.Drawing.Point(77, 11);
            this.btnNextY.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnNextY.Name = "btnNextY";
            this.btnNextY.Size = new System.Drawing.Size(30, 27);
            this.btnNextY.TabIndex = 7;
            this.btnNextY.UseVisualStyleBackColor = false;
            this.btnNextY.Click += new System.EventHandler(btnNextY_Click);
            this.btnNextM.BackColor = System.Drawing.Color.Transparent;
            this.btnNextM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextM.FlatAppearance.BorderSize = 0;
            this.btnNextM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNextM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNextM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextM.Image = BPersianCalendar.Properties.Resources.img_png__toRight_16px;
            this.btnNextM.Location = new System.Drawing.Point(288, 11);
            this.btnNextM.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnNextM.Name = "btnNextM";
            this.btnNextM.Size = new System.Drawing.Size(30, 27);
            this.btnNextM.TabIndex = 8;
            this.btnNextM.UseVisualStyleBackColor = false;
            this.btnNextM.Click += new System.EventHandler(btnNextM_Click);
            this.button1.Location = new System.Drawing.Point(3, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "امروز";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(btnToday_Click);
            this.button2.Location = new System.Drawing.Point(3, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "تایید";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(btnClose_Click);
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.lblShamsi);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.lblMiladi);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(3, 166);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 49);
            this.panel2.TabIndex = 20;
            this.dgYear.AllowUserToAddRows = false;
            this.dgYear.AllowUserToDeleteRows = false;
            this.dgYear.AllowUserToOrderColumns = true;
            this.dgYear.AllowUserToResizeColumns = false;
            this.dgYear.AllowUserToResizeRows = false;
            this.dgYear.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgYear.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgYear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgYear.ColumnHeadersVisible = false;
            this.dgYear.Columns.AddRange(this.dataGridViewTextBoxColumn1, this.dataGridViewTextBoxColumn2, this.dataGridViewTextBoxColumn3);
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgYear.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgYear.IsDate = false;
            this.dgYear.Location = new System.Drawing.Point(42, 0);
            this.dgYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgYear.Name = "dgYear";
            this.dgYear.RowHeadersVisible = false;
            this.dgYear.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgYear.RowTemplate.Height = 54;
            this.dgYear.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgYear.Size = new System.Drawing.Size(48, 10);
            this.dgYear.TabIndex = 15;
            this.dgYear.Visible = false;
            this.dgYear.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgYear_CellClick);
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn2.HeaderText = "Column2";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn3.HeaderText = "Column3";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dgMonth.AllowUserToAddRows = false;
            this.dgMonth.AllowUserToDeleteRows = false;
            this.dgMonth.AllowUserToOrderColumns = true;
            this.dgMonth.AllowUserToResizeColumns = false;
            this.dgMonth.AllowUserToResizeRows = false;
            this.dgMonth.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMonth.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgMonth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMonth.ColumnHeadersVisible = false;
            this.dgMonth.Columns.AddRange(this.Column1, this.Column2, this.Column3);
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgMonth.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgMonth.IsDate = false;
            this.dgMonth.Location = new System.Drawing.Point(0, 0);
            this.dgMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgMonth.Name = "dgMonth";
            this.dgMonth.RowHeadersVisible = false;
            this.dgMonth.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgMonth.RowTemplate.Height = 54;
            this.dgMonth.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgMonth.Size = new System.Drawing.Size(36, 11);
            this.dgMonth.TabIndex = 14;
            this.dgMonth.Visible = false;
            this.dgMonth.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgMonth_CellClick);
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            base.ClientSize = new System.Drawing.Size(325, 219);
            base.Controls.Add(this.btnPrevYears);
            base.Controls.Add(this.btnNextYears);
            base.Controls.Add(this.dgYear);
            base.Controls.Add(this.dgMonth);
            base.Controls.Add(this.panel1);
            base.Controls.Add(this.btnPrevY);
            base.Controls.Add(this.btnPrevM);
            base.Controls.Add(this.btnNextY);
            base.Controls.Add(this.lblYear);
            base.Controls.Add(this.btnNextM);
            base.Controls.Add(this.lblMounth);
            base.Controls.Add(this.dgCalander);
            base.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Tahoma", 8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            base.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            base.MaximizeBox = false;
            base.Name = "PCalander";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            base.ShowInTaskbar = false;
            base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقویم شمسی | تاریخ انتخاب شده :  ";
            base.TopMost = true;
            base.Load += new System.EventHandler(frmCalander_Load);
            ((System.ComponentModel.ISupportInitialize)this.dgCalander).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)this.dgYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.dgMonth).EndInit();
            base.ResumeLayout(false);
        }
    }

}
