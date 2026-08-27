using BPersianCalendar.myComponents;

namespace BPersianCalendar
{
    partial class Frm_BPersianCalendar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_BPersianCalendar));
            this.tlp_ShowDate = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_ShamsiDateTitle = new System.Windows.Forms.Label();
            this.lbl_MiladiDateTitle = new System.Windows.Forms.Label();
            this.lbl_Shamsi = new System.Windows.Forms.Label();
            this.lbl_Miladi = new System.Windows.Forms.Label();
            this.lbl_Shanbe = new System.Windows.Forms.Label();
            this.lbl_1Shanbe = new System.Windows.Forms.Label();
            this.lbl_2Shanbe = new System.Windows.Forms.Label();
            this.lbl_3Shanbe = new System.Windows.Forms.Label();
            this.lbl_4Shanbe = new System.Windows.Forms.Label();
            this.tlp_ConfirmButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Today = new System.Windows.Forms.Button();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.dgv_Calendar = new System.Windows.Forms.DataGridView();
            this.btn_SelectNextYears = new System.Windows.Forms.Button();
            this.lbl_5Shanbe = new System.Windows.Forms.Label();
            this.lbl_Jomee = new System.Windows.Forms.Label();
            this.tlp_WeekDays = new System.Windows.Forms.TableLayoutPanel();
            this.btn_PreviousYear = new System.Windows.Forms.Button();
            this.btn_NextMonth = new System.Windows.Forms.Button();
            this.lbl_Month = new System.Windows.Forms.Label();
            this.btn_PreviousMonth = new System.Windows.Forms.Button();
            this.btn_NextYear = new System.Windows.Forms.Button();
            this.lbl_Year = new System.Windows.Forms.Label();
            this.tlp_YearMonth = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_Confirm = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_Whole = new System.Windows.Forms.TableLayoutPanel();
            this.btn_SelectPreviousYears = new System.Windows.Forms.Button();
            this.dgv_SelectMonth = new System.Windows.Forms.DataGridView();
            this.dgv_SelectYear = new System.Windows.Forms.DataGridView();
            this.tlp_ShowDate.SuspendLayout();
            this.tlp_ConfirmButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Calendar)).BeginInit();
            this.tlp_WeekDays.SuspendLayout();
            this.tlp_YearMonth.SuspendLayout();
            this.tlp_Confirm.SuspendLayout();
            this.tlp_Whole.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SelectMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SelectYear)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_ShowDate
            // 
            this.tlp_ShowDate.ColumnCount = 3;
            this.tlp_ShowDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tlp_ShowDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tlp_ShowDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_ShowDate.Controls.Add(this.lbl_ShamsiDateTitle, 0, 0);
            this.tlp_ShowDate.Controls.Add(this.lbl_MiladiDateTitle, 0, 1);
            this.tlp_ShowDate.Controls.Add(this.lbl_Shamsi, 2, 0);
            this.tlp_ShowDate.Controls.Add(this.lbl_Miladi, 2, 1);
            this.tlp_ShowDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_ShowDate.Location = new System.Drawing.Point(124, 0);
            this.tlp_ShowDate.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_ShowDate.Name = "tlp_ShowDate";
            this.tlp_ShowDate.RowCount = 2;
            this.tlp_ShowDate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_ShowDate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_ShowDate.Size = new System.Drawing.Size(210, 50);
            this.tlp_ShowDate.TabIndex = 1;
            // 
            // lbl_ShamsiDateTitle
            // 
            this.lbl_ShamsiDateTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ShamsiDateTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_ShamsiDateTitle.Location = new System.Drawing.Point(114, 0);
            this.lbl_ShamsiDateTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_ShamsiDateTitle.Name = "lbl_ShamsiDateTitle";
            this.lbl_ShamsiDateTitle.Size = new System.Drawing.Size(96, 25);
            this.lbl_ShamsiDateTitle.TabIndex = 10;
            this.lbl_ShamsiDateTitle.Text = "تاریخ شمسی:";
            this.lbl_ShamsiDateTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_MiladiDateTitle
            // 
            this.lbl_MiladiDateTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MiladiDateTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_MiladiDateTitle.Location = new System.Drawing.Point(114, 25);
            this.lbl_MiladiDateTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_MiladiDateTitle.Name = "lbl_MiladiDateTitle";
            this.lbl_MiladiDateTitle.Size = new System.Drawing.Size(96, 25);
            this.lbl_MiladiDateTitle.TabIndex = 10;
            this.lbl_MiladiDateTitle.Text = "تاریخ میلادی:";
            this.lbl_MiladiDateTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Shamsi
            // 
            this.lbl_Shamsi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Shamsi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Shamsi.Location = new System.Drawing.Point(0, 0);
            this.lbl_Shamsi.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Shamsi.Name = "lbl_Shamsi";
            this.lbl_Shamsi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Shamsi.Size = new System.Drawing.Size(111, 25);
            this.lbl_Shamsi.TabIndex = 10;
            this.lbl_Shamsi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Miladi
            // 
            this.lbl_Miladi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Miladi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Miladi.Location = new System.Drawing.Point(0, 25);
            this.lbl_Miladi.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Miladi.Name = "lbl_Miladi";
            this.lbl_Miladi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Miladi.Size = new System.Drawing.Size(111, 25);
            this.lbl_Miladi.TabIndex = 10;
            this.lbl_Miladi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Shanbe
            // 
            this.lbl_Shanbe.AutoSize = true;
            this.lbl_Shanbe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Shanbe.Location = new System.Drawing.Point(287, 0);
            this.lbl_Shanbe.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Shanbe.Name = "lbl_Shanbe";
            this.lbl_Shanbe.Size = new System.Drawing.Size(47, 20);
            this.lbl_Shanbe.TabIndex = 12;
            this.lbl_Shanbe.Text = "شنبه";
            this.lbl_Shanbe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_1Shanbe
            // 
            this.lbl_1Shanbe.AutoSize = true;
            this.lbl_1Shanbe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_1Shanbe.Location = new System.Drawing.Point(240, 0);
            this.lbl_1Shanbe.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_1Shanbe.Name = "lbl_1Shanbe";
            this.lbl_1Shanbe.Size = new System.Drawing.Size(47, 20);
            this.lbl_1Shanbe.TabIndex = 12;
            this.lbl_1Shanbe.Text = "1شنبه";
            this.lbl_1Shanbe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_2Shanbe
            // 
            this.lbl_2Shanbe.AutoSize = true;
            this.lbl_2Shanbe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_2Shanbe.Location = new System.Drawing.Point(193, 0);
            this.lbl_2Shanbe.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_2Shanbe.Name = "lbl_2Shanbe";
            this.lbl_2Shanbe.Size = new System.Drawing.Size(47, 20);
            this.lbl_2Shanbe.TabIndex = 12;
            this.lbl_2Shanbe.Text = "2شنبه";
            this.lbl_2Shanbe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_3Shanbe
            // 
            this.lbl_3Shanbe.AutoSize = true;
            this.lbl_3Shanbe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_3Shanbe.Location = new System.Drawing.Point(146, 0);
            this.lbl_3Shanbe.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_3Shanbe.Name = "lbl_3Shanbe";
            this.lbl_3Shanbe.Size = new System.Drawing.Size(47, 20);
            this.lbl_3Shanbe.TabIndex = 12;
            this.lbl_3Shanbe.Text = "3شنبه";
            this.lbl_3Shanbe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_4Shanbe
            // 
            this.lbl_4Shanbe.AutoSize = true;
            this.lbl_4Shanbe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_4Shanbe.Location = new System.Drawing.Point(99, 0);
            this.lbl_4Shanbe.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_4Shanbe.Name = "lbl_4Shanbe";
            this.lbl_4Shanbe.Size = new System.Drawing.Size(47, 20);
            this.lbl_4Shanbe.TabIndex = 12;
            this.lbl_4Shanbe.Text = "4شنبه";
            this.lbl_4Shanbe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlp_ConfirmButtons
            // 
            this.tlp_ConfirmButtons.ColumnCount = 2;
            this.tlp_ConfirmButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlp_ConfirmButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlp_ConfirmButtons.Controls.Add(this.btn_Today, 0, 1);
            this.tlp_ConfirmButtons.Controls.Add(this.btn_Confirm, 1, 1);
            this.tlp_ConfirmButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_ConfirmButtons.Location = new System.Drawing.Point(5, 0);
            this.tlp_ConfirmButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_ConfirmButtons.Name = "tlp_ConfirmButtons";
            this.tlp_ConfirmButtons.RowCount = 3;
            this.tlp_ConfirmButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlp_ConfirmButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_ConfirmButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlp_ConfirmButtons.Size = new System.Drawing.Size(110, 50);
            this.tlp_ConfirmButtons.TabIndex = 0;
            // 
            // btn_Today
            // 
            this.btn_Today.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Today.Location = new System.Drawing.Point(58, 8);
            this.btn_Today.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Today.Name = "btn_Today";
            this.btn_Today.Size = new System.Drawing.Size(52, 34);
            this.btn_Today.TabIndex = 7;
            this.btn_Today.Text = "امروز";
            this.btn_Today.UseVisualStyleBackColor = true;
            this.btn_Today.Click += new System.EventHandler(this.btn_Today_Click);
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Confirm.Location = new System.Drawing.Point(0, 8);
            this.btn_Confirm.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(58, 34);
            this.btn_Confirm.TabIndex = 8;
            this.btn_Confirm.Text = "تایید";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // dgv_Calendar
            // 
            this.dgv_Calendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Calendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Calendar.Location = new System.Drawing.Point(0, 54);
            this.dgv_Calendar.Margin = new System.Windows.Forms.Padding(0);
            this.dgv_Calendar.Name = "dgv_Calendar";
            this.dgv_Calendar.Size = new System.Drawing.Size(334, 131);
            this.dgv_Calendar.TabIndex = 3;
            this.dgv_Calendar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Calendar_CellClick);
            this.dgv_Calendar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Calendar_CellDoubleClick);
            this.dgv_Calendar.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Calendar_CellEnter);
            this.dgv_Calendar.SelectionChanged += new System.EventHandler(this.dgv_Calendar_SelectionChanged);
            this.dgv_Calendar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_Calendar_KeyDown);
            this.dgv_Calendar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgv_Calendar_KeyPress);
            // 
            // btn_SelectNextYears
            // 
            this.btn_SelectNextYears.BackColor = System.Drawing.Color.White;
            this.btn_SelectNextYears.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SelectNextYears.FlatAppearance.BorderSize = 0;
            this.btn_SelectNextYears.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_SelectNextYears.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_SelectNextYears.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SelectNextYears.Image = ((System.Drawing.Image)(resources.GetObject("btn_SelectNextYears.Image")));
            this.btn_SelectNextYears.Location = new System.Drawing.Point(303, 1);
            this.btn_SelectNextYears.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_SelectNextYears.Name = "btn_SelectNextYears";
            this.btn_SelectNextYears.Size = new System.Drawing.Size(30, 27);
            this.btn_SelectNextYears.TabIndex = 22;
            this.btn_SelectNextYears.UseVisualStyleBackColor = false;
            this.btn_SelectNextYears.Visible = false;
            this.btn_SelectNextYears.Click += new System.EventHandler(this.btn_SelectNextYears_Click);
            // 
            // lbl_5Shanbe
            // 
            this.lbl_5Shanbe.AutoSize = true;
            this.lbl_5Shanbe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_5Shanbe.Location = new System.Drawing.Point(52, 0);
            this.lbl_5Shanbe.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_5Shanbe.Name = "lbl_5Shanbe";
            this.lbl_5Shanbe.Size = new System.Drawing.Size(47, 20);
            this.lbl_5Shanbe.TabIndex = 12;
            this.lbl_5Shanbe.Text = "5شنبه";
            this.lbl_5Shanbe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Jomee
            // 
            this.lbl_Jomee.AutoSize = true;
            this.lbl_Jomee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Jomee.Location = new System.Drawing.Point(0, 0);
            this.lbl_Jomee.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Jomee.Name = "lbl_Jomee";
            this.lbl_Jomee.Size = new System.Drawing.Size(52, 20);
            this.lbl_Jomee.TabIndex = 12;
            this.lbl_Jomee.Text = "جمعه";
            this.lbl_Jomee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlp_WeekDays
            // 
            this.tlp_WeekDays.BackColor = System.Drawing.Color.Orange;
            this.tlp_WeekDays.ColumnCount = 7;
            this.tlp_WeekDays.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlp_WeekDays.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlp_WeekDays.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlp_WeekDays.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlp_WeekDays.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlp_WeekDays.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlp_WeekDays.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlp_WeekDays.Controls.Add(this.lbl_Shanbe, 0, 0);
            this.tlp_WeekDays.Controls.Add(this.lbl_1Shanbe, 1, 0);
            this.tlp_WeekDays.Controls.Add(this.lbl_2Shanbe, 2, 0);
            this.tlp_WeekDays.Controls.Add(this.lbl_3Shanbe, 3, 0);
            this.tlp_WeekDays.Controls.Add(this.lbl_4Shanbe, 4, 0);
            this.tlp_WeekDays.Controls.Add(this.lbl_5Shanbe, 5, 0);
            this.tlp_WeekDays.Controls.Add(this.lbl_Jomee, 6, 0);
            this.tlp_WeekDays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_WeekDays.Location = new System.Drawing.Point(0, 34);
            this.tlp_WeekDays.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_WeekDays.Name = "tlp_WeekDays";
            this.tlp_WeekDays.RowCount = 1;
            this.tlp_WeekDays.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_WeekDays.Size = new System.Drawing.Size(334, 20);
            this.tlp_WeekDays.TabIndex = 1;
            // 
            // btn_PreviousYear
            // 
            this.btn_PreviousYear.BackColor = System.Drawing.Color.Transparent;
            this.btn_PreviousYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PreviousYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_PreviousYear.FlatAppearance.BorderSize = 0;
            this.btn_PreviousYear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_PreviousYear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_PreviousYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PreviousYear.Image = ((System.Drawing.Image)(resources.GetObject("btn_PreviousYear.Image")));
            this.btn_PreviousYear.Location = new System.Drawing.Point(0, 0);
            this.btn_PreviousYear.Margin = new System.Windows.Forms.Padding(0);
            this.btn_PreviousYear.Name = "btn_PreviousYear";
            this.btn_PreviousYear.Size = new System.Drawing.Size(30, 27);
            this.btn_PreviousYear.TabIndex = 1;
            this.btn_PreviousYear.UseVisualStyleBackColor = false;
            this.btn_PreviousYear.Click += new System.EventHandler(this.btn_PreviousYear_Click);
            // 
            // btn_NextMonth
            // 
            this.btn_NextMonth.BackColor = System.Drawing.Color.Transparent;
            this.btn_NextMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_NextMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_NextMonth.FlatAppearance.BorderSize = 0;
            this.btn_NextMonth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_NextMonth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_NextMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NextMonth.Image = ((System.Drawing.Image)(resources.GetObject("btn_NextMonth.Image")));
            this.btn_NextMonth.Location = new System.Drawing.Point(302, 0);
            this.btn_NextMonth.Margin = new System.Windows.Forms.Padding(0);
            this.btn_NextMonth.Name = "btn_NextMonth";
            this.btn_NextMonth.Size = new System.Drawing.Size(30, 27);
            this.btn_NextMonth.TabIndex = 4;
            this.btn_NextMonth.UseVisualStyleBackColor = false;
            this.btn_NextMonth.Click += new System.EventHandler(this.btn_NextMonth_Click);
            // 
            // lbl_Month
            // 
            this.lbl_Month.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Month.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Month.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Month.Location = new System.Drawing.Point(218, 0);
            this.lbl_Month.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Month.Name = "lbl_Month";
            this.lbl_Month.Size = new System.Drawing.Size(84, 27);
            this.lbl_Month.TabIndex = 10;
            this.lbl_Month.Text = "مهر";
            this.lbl_Month.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Month.Click += new System.EventHandler(this.lbl_Month_Click);
            // 
            // btn_PreviousMonth
            // 
            this.btn_PreviousMonth.BackColor = System.Drawing.Color.Transparent;
            this.btn_PreviousMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PreviousMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_PreviousMonth.FlatAppearance.BorderSize = 0;
            this.btn_PreviousMonth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_PreviousMonth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_PreviousMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PreviousMonth.Image = ((System.Drawing.Image)(resources.GetObject("btn_PreviousMonth.Image")));
            this.btn_PreviousMonth.Location = new System.Drawing.Point(188, 0);
            this.btn_PreviousMonth.Margin = new System.Windows.Forms.Padding(0);
            this.btn_PreviousMonth.Name = "btn_PreviousMonth";
            this.btn_PreviousMonth.Size = new System.Drawing.Size(30, 27);
            this.btn_PreviousMonth.TabIndex = 3;
            this.btn_PreviousMonth.UseVisualStyleBackColor = false;
            this.btn_PreviousMonth.Click += new System.EventHandler(this.btn_PreviousMonth_Click);
            // 
            // btn_NextYear
            // 
            this.btn_NextYear.BackColor = System.Drawing.Color.Transparent;
            this.btn_NextYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_NextYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_NextYear.FlatAppearance.BorderSize = 0;
            this.btn_NextYear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_NextYear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_NextYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NextYear.Image = global::BPersianCalendar.Properties.Resources.img_png__toRight_16px;
            this.btn_NextYear.Location = new System.Drawing.Point(80, 0);
            this.btn_NextYear.Margin = new System.Windows.Forms.Padding(0);
            this.btn_NextYear.Name = "btn_NextYear";
            this.btn_NextYear.Size = new System.Drawing.Size(30, 27);
            this.btn_NextYear.TabIndex = 2;
            this.btn_NextYear.UseVisualStyleBackColor = false;
            this.btn_NextYear.Click += new System.EventHandler(this.btn_NextYear_Click);
            // 
            // lbl_Year
            // 
            this.lbl_Year.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Year.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Year.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Year.Location = new System.Drawing.Point(30, 0);
            this.lbl_Year.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_Year.Name = "lbl_Year";
            this.lbl_Year.Size = new System.Drawing.Size(50, 27);
            this.lbl_Year.TabIndex = 9;
            this.lbl_Year.Text = "1393";
            this.lbl_Year.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Year.Click += new System.EventHandler(this.lbl_Year_Click);
            // 
            // tlp_YearMonth
            // 
            this.tlp_YearMonth.ColumnCount = 7;
            this.tlp_YearMonth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_YearMonth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tlp_YearMonth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_YearMonth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_YearMonth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_YearMonth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlp_YearMonth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_YearMonth.Controls.Add(this.btn_NextYear, 4, 0);
            this.tlp_YearMonth.Controls.Add(this.btn_PreviousYear, 6, 0);
            this.tlp_YearMonth.Controls.Add(this.btn_NextMonth, 0, 0);
            this.tlp_YearMonth.Controls.Add(this.lbl_Month, 1, 0);
            this.tlp_YearMonth.Controls.Add(this.btn_PreviousMonth, 2, 0);
            this.tlp_YearMonth.Controls.Add(this.lbl_Year, 5, 0);
            this.tlp_YearMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_YearMonth.Location = new System.Drawing.Point(1, 1);
            this.tlp_YearMonth.Margin = new System.Windows.Forms.Padding(1);
            this.tlp_YearMonth.Name = "tlp_YearMonth";
            this.tlp_YearMonth.RowCount = 1;
            this.tlp_YearMonth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_YearMonth.Size = new System.Drawing.Size(332, 27);
            this.tlp_YearMonth.TabIndex = 0;
            // 
            // tlp_Confirm
            // 
            this.tlp_Confirm.ColumnCount = 4;
            this.tlp_Confirm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.tlp_Confirm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Confirm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tlp_Confirm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlp_Confirm.Controls.Add(this.tlp_ShowDate, 0, 0);
            this.tlp_Confirm.Controls.Add(this.tlp_ConfirmButtons, 2, 0);
            this.tlp_Confirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Confirm.Location = new System.Drawing.Point(0, 195);
            this.tlp_Confirm.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Confirm.Name = "tlp_Confirm";
            this.tlp_Confirm.RowCount = 1;
            this.tlp_Confirm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Confirm.Size = new System.Drawing.Size(334, 50);
            this.tlp_Confirm.TabIndex = 2;
            // 
            // tlp_Whole
            // 
            this.tlp_Whole.ColumnCount = 1;
            this.tlp_Whole.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Whole.Controls.Add(this.tlp_YearMonth, 0, 0);
            this.tlp_Whole.Controls.Add(this.tlp_WeekDays, 0, 2);
            this.tlp_Whole.Controls.Add(this.tlp_Confirm, 0, 5);
            this.tlp_Whole.Controls.Add(this.dgv_Calendar, 0, 3);
            this.tlp_Whole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Whole.Location = new System.Drawing.Point(0, 0);
            this.tlp_Whole.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Whole.Name = "tlp_Whole";
            this.tlp_Whole.RowCount = 7;
            this.tlp_Whole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tlp_Whole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tlp_Whole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Whole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tlp_Whole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_Whole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlp_Whole.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Whole.Size = new System.Drawing.Size(334, 251);
            this.tlp_Whole.TabIndex = 21;
            // 
            // btn_SelectPreviousYears
            // 
            this.btn_SelectPreviousYears.BackColor = System.Drawing.Color.White;
            this.btn_SelectPreviousYears.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SelectPreviousYears.FlatAppearance.BorderSize = 0;
            this.btn_SelectPreviousYears.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_SelectPreviousYears.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_SelectPreviousYears.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SelectPreviousYears.Image = ((System.Drawing.Image)(resources.GetObject("btn_SelectPreviousYears.Image")));
            this.btn_SelectPreviousYears.Location = new System.Drawing.Point(1, 1);
            this.btn_SelectPreviousYears.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_SelectPreviousYears.Name = "btn_SelectPreviousYears";
            this.btn_SelectPreviousYears.Size = new System.Drawing.Size(30, 27);
            this.btn_SelectPreviousYears.TabIndex = 23;
            this.btn_SelectPreviousYears.UseVisualStyleBackColor = false;
            this.btn_SelectPreviousYears.Visible = false;
            this.btn_SelectPreviousYears.Click += new System.EventHandler(this.btn_SelectPreviousYears_Click);
            // 
            // dgv_SelectMonth
            // 
            this.dgv_SelectMonth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SelectMonth.Location = new System.Drawing.Point(234, 0);
            this.dgv_SelectMonth.Margin = new System.Windows.Forms.Padding(0);
            this.dgv_SelectMonth.Name = "dgv_SelectMonth";
            this.dgv_SelectMonth.Size = new System.Drawing.Size(100, 8);
            this.dgv_SelectMonth.TabIndex = 24;
            this.dgv_SelectMonth.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SelectMonth_CellClick);
            // 
            // dgv_SelectYear
            // 
            this.dgv_SelectYear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SelectYear.Location = new System.Drawing.Point(0, 0);
            this.dgv_SelectYear.Margin = new System.Windows.Forms.Padding(0);
            this.dgv_SelectYear.Name = "dgv_SelectYear";
            this.dgv_SelectYear.Size = new System.Drawing.Size(100, 8);
            this.dgv_SelectYear.TabIndex = 25;
            this.dgv_SelectYear.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SelectYear_CellClick);
            // 
            // Frm_BPersianCalendar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(334, 251);
            this.Controls.Add(this.btn_SelectNextYears);
            this.Controls.Add(this.btn_SelectPreviousYears);
            this.Controls.Add(this.dgv_SelectYear);
            this.Controls.Add(this.dgv_SelectMonth);
            this.Controls.Add(this.tlp_Whole);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_BPersianCalendar";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقویم شمسی | تاریخ انتخاب شده :  ";
            this.Load += new System.EventHandler(this.Frm_BPersianCalendar_Load);
            this.tlp_ShowDate.ResumeLayout(false);
            this.tlp_ConfirmButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Calendar)).EndInit();
            this.tlp_WeekDays.ResumeLayout(false);
            this.tlp_WeekDays.PerformLayout();
            this.tlp_YearMonth.ResumeLayout(false);
            this.tlp_Confirm.ResumeLayout(false);
            this.tlp_Whole.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SelectMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SelectYear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_ShowDate;
        private System.Windows.Forms.Label lbl_ShamsiDateTitle;
        private System.Windows.Forms.Label lbl_MiladiDateTitle;
        private System.Windows.Forms.Label lbl_Shamsi;
        private System.Windows.Forms.Label lbl_Miladi;
        private System.Windows.Forms.Label lbl_Shanbe;
        private System.Windows.Forms.Label lbl_1Shanbe;
        private System.Windows.Forms.Label lbl_2Shanbe;
        private System.Windows.Forms.Label lbl_3Shanbe;
        private System.Windows.Forms.Label lbl_4Shanbe;
        private System.Windows.Forms.TableLayoutPanel tlp_ConfirmButtons;
        private System.Windows.Forms.DataGridView dgv_Calendar;
        private System.Windows.Forms.Button btn_SelectNextYears;
        private System.Windows.Forms.Label lbl_5Shanbe;
        private System.Windows.Forms.Label lbl_Jomee;
        private System.Windows.Forms.TableLayoutPanel tlp_WeekDays;
        private System.Windows.Forms.Button btn_PreviousYear;
        private System.Windows.Forms.Button btn_NextMonth;
        private System.Windows.Forms.Label lbl_Month;
        private System.Windows.Forms.Button btn_PreviousMonth;
        private System.Windows.Forms.Button btn_NextYear;
        private System.Windows.Forms.Label lbl_Year;
        private System.Windows.Forms.TableLayoutPanel tlp_YearMonth;
        private System.Windows.Forms.TableLayoutPanel tlp_Confirm;
        private System.Windows.Forms.TableLayoutPanel tlp_Whole;
        private System.Windows.Forms.Button btn_SelectPreviousYears;
        private System.Windows.Forms.Button btn_Today;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.DataGridView dgv_SelectMonth;
        private System.Windows.Forms.DataGridView dgv_SelectYear;
    }
}