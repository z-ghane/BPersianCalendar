using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;


namespace BPersianCalendar
{
    public class PCalandar : Form
    {
        private PersianCalendar pc = new PersianCalendar();

        private DateTime NowDate = DateTime.Now;

        private static int mounthName;

        private static int YearName;

        private int selectedYear;

        private int selectdMonth;

        private int selectedDay;

        private int rowIndex;

        private int columnIndex;

        private string selectedShamsiDate;

        private DateTime selectedMiladiDate;

        private ShamsiCalandar objshamsiCalander = new ShamsiCalandar();

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

        private Button btnToday;

        private Button btnClose;

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

        public PCalandar()
        {
            InitializeComponent();
            mounthName = pc.GetMonth(NowDate);
            YearName = pc.GetYear(NowDate);
        }

        private void frmCalander_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                dgCalander.Rows.Add();
            }

            Text = Text + " " + MiladiToShamsi(DateTime.Now);
            FillCalander();
            FindCurrentDate();
            getDates();
            dgCalander.Focus();
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
            while (num2 <= 5 && num3 != daysInMonth)
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
        }

        private void btnNextY_Click(object sender, EventArgs e)
        {
            NextYear();
            ResetCalender();
            FillCalander();
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
        }

        private void PrevYear()
        {
            YearName--;
            lblYear.Text = YearName.ToString();
        }

        private void dgCalander_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgCalander.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null && !string.IsNullOrEmpty(dgCalander.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()))
            {
                Text = null;
                selectedDay = int.Parse(dgCalander.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                selectdMonth = mounthName;
                selectedYear = YearName;
                selectedShamsiDate = selectedYear + "/" + ((selectdMonth.ToString().Length == 1) ? ("0" + selectdMonth) : selectdMonth.ToString()) + "/" + ((selectedDay.ToString().Length == 1) ? ("0" + selectedDay) : selectedDay.ToString());
                Text = "تقویم شمسی | تاریخ انتخاب شده :   " + selectedShamsiDate;
                selectedMiladiDate = pc.ToDateTime(selectedYear, selectdMonth, selectedDay, 0, 0, 0, 0);
                lblShamsi.Text = selectedShamsiDate;
                lblMiladi.Text = selectedMiladiDate.ToShortDateString();
            }
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            FindCurrentDate();
            getDates();
            Text = "تقویم شمسی | تاریخ انتخاب شده :   " + MiladiToShamsi(DateTime.Now);
        }

        private void getDates()
        {
            lblShamsi.Text = MiladiToShamsi(DateTime.Now);
            lblMiladi.Text = DateTime.Now.ToShortDateString();
        }

        private void FindCurrentDate()
        {
            int num = 0;
            int year = pc.GetYear(DateTime.Now);
            int month = pc.GetMonth(DateTime.Now);
            num = pc.GetDayOfMonth(DateTime.Now);
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
            CloseMethod();
        }

        public ShamsiCalandar getshamsiCalander()
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
            CloseMethod();
        }

        private void CloseMethod()
        {
            objshamsiCalander.MiladiDate = selectedMiladiDate;
            objshamsiCalander.ShamsiDate = selectedShamsiDate;
            Close();
        }

        private void dgCalander_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return && dgCalander.Rows[dgCalander.SelectedCells[0].RowIndex].Cells[dgCalander.SelectedCells[0].ColumnIndex].Value != null && !string.IsNullOrEmpty(dgCalander.Rows[dgCalander.SelectedCells[0].RowIndex].Cells[dgCalander.SelectedCells[0].ColumnIndex].Value.ToString()))
            {
                Text = null;
                selectedDay = int.Parse(dgCalander.Rows[dgCalander.SelectedCells[0].RowIndex].Cells[dgCalander.SelectedCells[0].ColumnIndex].Value.ToString());
                selectdMonth = mounthName;
                selectedYear = YearName;
                selectedShamsiDate = selectedYear + "/" + ((selectdMonth.ToString().Length == 1) ? ("0" + selectdMonth) : selectdMonth.ToString()) + "/" + ((selectedDay.ToString().Length == 1) ? ("0" + selectedDay) : selectedDay.ToString());
                Text = "تقویم شمسی | تاریخ انتخاب شده :   " + selectedShamsiDate;
                selectedMiladiDate = pc.ToDateTime(selectedYear, selectdMonth, selectedDay, 0, 0, 0, 0);
                lblShamsi.Text = selectedShamsiDate;
                lblMiladi.Text = selectedMiladiDate.ToShortDateString();
                CloseMethod();
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
            this.btnToday = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
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
            this.btnPrevY = new System.Windows.Forms.Button();
            this.btnPrevM = new System.Windows.Forms.Button();
            this.btnNextY = new System.Windows.Forms.Button();
            this.btnNextM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)this.dgCalander).BeginInit();
            this.panel1.SuspendLayout();
            base.SuspendLayout();
            this.dgCalander.AllowUserToDeleteRows = false;
            this.dgCalander.AllowUserToResizeColumns = false;
            this.dgCalander.AllowUserToResizeRows = false;
            this.dgCalander.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCalander.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgCalander.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
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
            this.dgCalander.Name = "dgCalander";
            this.dgCalander.ReadOnly = true;
            this.dgCalander.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgCalander.RowHeadersVisible = false;
            this.dgCalander.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgCalander.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgCalander.RowTemplate.Height = 18;
            this.dgCalander.RowTemplate.ReadOnly = true;
            this.dgCalander.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCalander.Size = new System.Drawing.Size(323, 97);
            this.dgCalander.TabIndex = 0;
            this.dgCalander.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgCalander_CellClick);
            this.dgCalander.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgCalander_CellDoubleClick);
            this.dgCalander.KeyDown += new System.Windows.Forms.KeyEventHandler(dgCalander_KeyDown);
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
            this.lblYear.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            this.lblYear.Location = new System.Drawing.Point(31, 14);
            this.lblYear.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(45, 24);
            this.lblYear.TabIndex = 9;
            this.lblYear.Text = "1393";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMounth.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            this.lblMounth.Location = new System.Drawing.Point(223, 12);
            this.lblMounth.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMounth.Name = "lblMounth";
            this.lblMounth.Size = new System.Drawing.Size(71, 22);
            this.lblMounth.TabIndex = 10;
            this.lblMounth.Text = "مهر";
            this.lblMounth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnToday.BackColor = System.Drawing.Color.Transparent;
            this.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToday.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
            this.btnToday.Location = new System.Drawing.Point(57, 176);
            this.btnToday.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(52, 30);
            this.btnToday.TabIndex = 11;
            this.btnToday.Text = "امروز";
            this.btnToday.UseVisualStyleBackColor = false;
            this.btnToday.Click += new System.EventHandler(btnToday_Click);
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
            this.btnClose.Location = new System.Drawing.Point(2, 176);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(49, 30);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "بستن";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(btnClose_Click);
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
            this.label3.Location = new System.Drawing.Point(186, 5);
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
            this.label6.Location = new System.Drawing.Point(46, 5);
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
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 22);
            this.panel1.TabIndex = 13;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
            this.label8.Location = new System.Drawing.Point(246, 194);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 22);
            this.label8.TabIndex = 10;
            this.label8.Text = "تاریخ میلادی:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMiladi.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            this.lblMiladi.Location = new System.Drawing.Point(154, 194);
            this.lblMiladi.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMiladi.Name = "lblMiladi";
            this.lblMiladi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMiladi.Size = new System.Drawing.Size(88, 22);
            this.lblMiladi.TabIndex = 10;
            this.lblMiladi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
            this.label9.Location = new System.Drawing.Point(232, 167);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 23);
            this.label9.TabIndex = 10;
            this.label9.Text = "تاریخ شمسی:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblShamsi.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            this.lblShamsi.Location = new System.Drawing.Point(155, 169);
            this.lblShamsi.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblShamsi.Name = "lblShamsi";
            this.lblShamsi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblShamsi.Size = new System.Drawing.Size(88, 22);
            this.lblShamsi.TabIndex = 10;
            this.lblShamsi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnPrevY.UseVisualStyleBackColor = true;
            this.btnPrevY.Click += new System.EventHandler(btnPrevY_Click);
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
            this.btnPrevM.UseVisualStyleBackColor = true;
            this.btnPrevM.Click += new System.EventHandler(btnPrevM_Click);
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
            this.btnNextY.UseVisualStyleBackColor = true;
            this.btnNextY.Click += new System.EventHandler(btnNextY_Click);
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
            this.btnNextM.UseVisualStyleBackColor = true;
            this.btnNextM.Click += new System.EventHandler(btnNextM_Click);
            base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            base.ClientSize = new System.Drawing.Size(325, 219);
            base.Controls.Add(this.panel1);
            base.Controls.Add(this.btnClose);
            base.Controls.Add(this.btnToday);
            base.Controls.Add(this.btnPrevY);
            base.Controls.Add(this.btnPrevM);
            base.Controls.Add(this.btnNextY);
            base.Controls.Add(this.lblYear);
            base.Controls.Add(this.btnNextM);
            base.Controls.Add(this.lblShamsi);
            base.Controls.Add(this.label9);
            base.Controls.Add(this.lblMiladi);
            base.Controls.Add(this.label8);
            base.Controls.Add(this.lblMounth);
            base.Controls.Add(this.dgCalander);
            this.Font = new System.Drawing.Font("Tahoma", 8f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
            base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            base.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            base.MaximizeBox = false;
            base.Name = "PCalander";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            base.ShowInTaskbar = false;
            base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقویم شمسی | تاریخ انتخاب شده :  ";
            base.Load += new System.EventHandler(frmCalander_Load);
            ((System.ComponentModel.ISupportInitialize)this.dgCalander).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            base.ResumeLayout(false);
        }
    }

}
