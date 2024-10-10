namespace BPersianCalender
{
    partial class frm_PCalander
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Calander = new System.Windows.Forms.DataGridView();
            this.c0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Year = new System.Windows.Forms.Label();
            this.lbl_Month = new System.Windows.Forms.Label();
            this.btn_Today = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbl_Shanbe = new System.Windows.Forms.Label();
            this.lbl_1Shanbe = new System.Windows.Forms.Label();
            this.lbl_2Shanbe = new System.Windows.Forms.Label();
            this.lbl_3Shanbe = new System.Windows.Forms.Label();
            this.lbl_4Shanbe = new System.Windows.Forms.Label();
            this.lbl_5Shanbe = new System.Windows.Forms.Label();
            this.lbl_Jomee = new System.Windows.Forms.Label();
            this.pnl_WeekDays = new System.Windows.Forms.Panel();
            this.lbl_MiladiDateTitle = new System.Windows.Forms.Label();
            this.lbl_ShamsiDateTitle = new System.Windows.Forms.Label();
            this.lbl_Shamsi = new System.Windows.Forms.Label();
            this.btn_PreviousYear = new System.Windows.Forms.Button();
            this.btn_PreviousMonth = new System.Windows.Forms.Button();
            this.btn_NextYear = new System.Windows.Forms.Button();
            this.btn_NextMonth = new System.Windows.Forms.Button();
            this.btn_SelectNextYears = new System.Windows.Forms.Button();
            this.btn_SelectPreviousYears = new System.Windows.Forms.Button();
            this.lbl_Miladi = new System.Windows.Forms.Label();
            this.dgv_SelectMonth = new BPersianCalender.SMIO_DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_SelectYear = new BPersianCalender.SMIO_DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Calander)).BeginInit();
            this.pnl_WeekDays.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SelectMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SelectYear)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Calander
            // 
            this.dgv_Calander.AllowUserToDeleteRows = false;
            this.dgv_Calander.AllowUserToResizeColumns = false;
            this.dgv_Calander.AllowUserToResizeRows = false;
            this.dgv_Calander.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Calander.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Calander.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Calander.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv_Calander.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Calander.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_Calander.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Calander.ColumnHeadersVisible = false;
            this.dgv_Calander.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c0,
            this.c1,
            this.c2,
            this.c3,
            this.c4,
            this.c5,
            this.c6});
            this.dgv_Calander.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Calander.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_Calander.Location = new System.Drawing.Point(0, 66);
            this.dgv_Calander.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dgv_Calander.MultiSelect = false;
            this.dgv_Calander.Name = "dgv_Calander";
            this.dgv_Calander.ReadOnly = true;
            this.dgv_Calander.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgv_Calander.RowHeadersVisible = false;
            this.dgv_Calander.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_Calander.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_Calander.RowTemplate.Height = 18;
            this.dgv_Calander.RowTemplate.ReadOnly = true;
            this.dgv_Calander.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Calander.Size = new System.Drawing.Size(323, 96);
            this.dgv_Calander.StandardTab = true;
            this.dgv_Calander.TabIndex = 0;
            this.dgv_Calander.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Calander_CellClick);
            this.dgv_Calander.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Calander_CellDoubleClick);
            this.dgv_Calander.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Calander_CellEnter);
            this.dgv_Calander.SelectionChanged += new System.EventHandler(this.dgv_Calander_SelectionChanged);
            this.dgv_Calander.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_Calander_KeyDown);
            this.dgv_Calander.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgv_Calander_KeyPress);
            // 
            // c0
            // 
            this.c0.HeaderText = "ش";
            this.c0.Name = "c0";
            this.c0.ReadOnly = true;
            // 
            // c1
            // 
            this.c1.HeaderText = "1ش";
            this.c1.Name = "c1";
            this.c1.ReadOnly = true;
            // 
            // c2
            // 
            this.c2.HeaderText = "2ش";
            this.c2.Name = "c2";
            this.c2.ReadOnly = true;
            // 
            // c3
            // 
            this.c3.HeaderText = "3ش";
            this.c3.Name = "c3";
            this.c3.ReadOnly = true;
            // 
            // c4
            // 
            this.c4.HeaderText = "4ش";
            this.c4.Name = "c4";
            this.c4.ReadOnly = true;
            // 
            // c5
            // 
            this.c5.HeaderText = "5ش";
            this.c5.Name = "c5";
            this.c5.ReadOnly = true;
            // 
            // c6
            // 
            this.c6.HeaderText = "ج";
            this.c6.Name = "c6";
            this.c6.ReadOnly = true;
            // 
            // lbl_Year
            // 
            this.lbl_Year.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Year.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Year.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_Year.Location = new System.Drawing.Point(31, 13);
            this.lbl_Year.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Year.Name = "lbl_Year";
            this.lbl_Year.Size = new System.Drawing.Size(45, 22);
            this.lbl_Year.TabIndex = 9;
            this.lbl_Year.Text = "1393";
            this.lbl_Year.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Year.Click += new System.EventHandler(this.lbl_Year_Click);
            // 
            // lbl_Month
            // 
            this.lbl_Month.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Month.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Month.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_Month.Location = new System.Drawing.Point(223, 13);
            this.lbl_Month.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Month.Name = "lbl_Month";
            this.lbl_Month.Size = new System.Drawing.Size(71, 22);
            this.lbl_Month.TabIndex = 10;
            this.lbl_Month.Text = "مهر";
            this.lbl_Month.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Month.Click += new System.EventHandler(this.lbl_Month_Click);
            // 
            // btn_Today
            // 
            this.btn_Today.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn_Today.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Today.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Today.Location = new System.Drawing.Point(56, 176);
            this.btn_Today.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Today.Name = "btn_Today";
            this.btn_Today.Size = new System.Drawing.Size(52, 30);
            this.btn_Today.TabIndex = 11;
            this.btn_Today.Text = "امروز";
            this.btn_Today.UseVisualStyleBackColor = false;
            this.btn_Today.Click += new System.EventHandler(this.btn_Today_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Close.Location = new System.Drawing.Point(1, 176);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(52, 30);
            this.btn_Close.TabIndex = 11;
            this.btn_Close.Text = "درج";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lbl_Shanbe
            // 
            this.lbl_Shanbe.AutoSize = true;
            this.lbl_Shanbe.Location = new System.Drawing.Point(281, 2);
            this.lbl_Shanbe.Name = "lbl_Shanbe";
            this.lbl_Shanbe.Size = new System.Drawing.Size(34, 13);
            this.lbl_Shanbe.TabIndex = 12;
            this.lbl_Shanbe.Text = "شنبه";
            this.lbl_Shanbe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_1Shanbe
            // 
            this.lbl_1Shanbe.AutoSize = true;
            this.lbl_1Shanbe.Location = new System.Drawing.Point(234, 2);
            this.lbl_1Shanbe.Name = "lbl_1Shanbe";
            this.lbl_1Shanbe.Size = new System.Drawing.Size(41, 13);
            this.lbl_1Shanbe.TabIndex = 12;
            this.lbl_1Shanbe.Text = "1شنبه";
            this.lbl_1Shanbe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_2Shanbe
            // 
            this.lbl_2Shanbe.AutoSize = true;
            this.lbl_2Shanbe.Location = new System.Drawing.Point(186, 2);
            this.lbl_2Shanbe.Name = "lbl_2Shanbe";
            this.lbl_2Shanbe.Size = new System.Drawing.Size(41, 13);
            this.lbl_2Shanbe.TabIndex = 12;
            this.lbl_2Shanbe.Text = "2شنبه";
            this.lbl_2Shanbe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_3Shanbe
            // 
            this.lbl_3Shanbe.AutoSize = true;
            this.lbl_3Shanbe.Location = new System.Drawing.Point(140, 2);
            this.lbl_3Shanbe.Name = "lbl_3Shanbe";
            this.lbl_3Shanbe.Size = new System.Drawing.Size(41, 13);
            this.lbl_3Shanbe.TabIndex = 12;
            this.lbl_3Shanbe.Text = "3شنبه";
            this.lbl_3Shanbe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_4Shanbe
            // 
            this.lbl_4Shanbe.AutoSize = true;
            this.lbl_4Shanbe.Location = new System.Drawing.Point(96, 2);
            this.lbl_4Shanbe.Name = "lbl_4Shanbe";
            this.lbl_4Shanbe.Size = new System.Drawing.Size(41, 13);
            this.lbl_4Shanbe.TabIndex = 12;
            this.lbl_4Shanbe.Text = "4شنبه";
            this.lbl_4Shanbe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_5Shanbe
            // 
            this.lbl_5Shanbe.AutoSize = true;
            this.lbl_5Shanbe.Location = new System.Drawing.Point(48, 2);
            this.lbl_5Shanbe.Name = "lbl_5Shanbe";
            this.lbl_5Shanbe.Size = new System.Drawing.Size(41, 13);
            this.lbl_5Shanbe.TabIndex = 12;
            this.lbl_5Shanbe.Text = "5شنبه";
            this.lbl_5Shanbe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Jomee
            // 
            this.lbl_Jomee.AutoSize = true;
            this.lbl_Jomee.Location = new System.Drawing.Point(4, 2);
            this.lbl_Jomee.Name = "lbl_Jomee";
            this.lbl_Jomee.Size = new System.Drawing.Size(35, 13);
            this.lbl_Jomee.TabIndex = 12;
            this.lbl_Jomee.Text = "جمعه";
            this.lbl_Jomee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_WeekDays
            // 
            this.pnl_WeekDays.BackColor = System.Drawing.Color.Goldenrod;
            this.pnl_WeekDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_WeekDays.Controls.Add(this.lbl_Jomee);
            this.pnl_WeekDays.Controls.Add(this.lbl_5Shanbe);
            this.pnl_WeekDays.Controls.Add(this.lbl_4Shanbe);
            this.pnl_WeekDays.Controls.Add(this.lbl_3Shanbe);
            this.pnl_WeekDays.Controls.Add(this.lbl_2Shanbe);
            this.pnl_WeekDays.Controls.Add(this.lbl_1Shanbe);
            this.pnl_WeekDays.Controls.Add(this.lbl_Shanbe);
            this.pnl_WeekDays.Location = new System.Drawing.Point(0, 44);
            this.pnl_WeekDays.Name = "pnl_WeekDays";
            this.pnl_WeekDays.Size = new System.Drawing.Size(323, 22);
            this.pnl_WeekDays.TabIndex = 13;
            // 
            // lbl_MiladiDateTitle
            // 
            this.lbl_MiladiDateTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_MiladiDateTitle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_MiladiDateTitle.Location = new System.Drawing.Point(232, 194);
            this.lbl_MiladiDateTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MiladiDateTitle.Name = "lbl_MiladiDateTitle";
            this.lbl_MiladiDateTitle.Size = new System.Drawing.Size(90, 22);
            this.lbl_MiladiDateTitle.TabIndex = 10;
            this.lbl_MiladiDateTitle.Text = "تاریخ میلادی:";
            this.lbl_MiladiDateTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_ShamsiDateTitle
            // 
            this.lbl_ShamsiDateTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ShamsiDateTitle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_ShamsiDateTitle.Location = new System.Drawing.Point(232, 167);
            this.lbl_ShamsiDateTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ShamsiDateTitle.Name = "lbl_ShamsiDateTitle";
            this.lbl_ShamsiDateTitle.Size = new System.Drawing.Size(90, 22);
            this.lbl_ShamsiDateTitle.TabIndex = 10;
            this.lbl_ShamsiDateTitle.Text = "تاریخ شمسی:";
            this.lbl_ShamsiDateTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Shamsi
            // 
            this.lbl_Shamsi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Shamsi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_Shamsi.Location = new System.Drawing.Point(156, 167);
            this.lbl_Shamsi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Shamsi.Name = "lbl_Shamsi";
            this.lbl_Shamsi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Shamsi.Size = new System.Drawing.Size(90, 22);
            this.lbl_Shamsi.TabIndex = 10;
            this.lbl_Shamsi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_PreviousYear
            // 
            this.btn_PreviousYear.BackColor = System.Drawing.Color.Transparent;
            this.btn_PreviousYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PreviousYear.FlatAppearance.BorderSize = 0;
            this.btn_PreviousYear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_PreviousYear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_PreviousYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PreviousYear.Image = global::BPersianCalender.Properties.Resources._1413037734_Last1;
            this.btn_PreviousYear.Location = new System.Drawing.Point(0, 11);
            this.btn_PreviousYear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_PreviousYear.Name = "btn_PreviousYear";
            this.btn_PreviousYear.Size = new System.Drawing.Size(30, 27);
            this.btn_PreviousYear.TabIndex = 5;
            this.btn_PreviousYear.UseVisualStyleBackColor = false;
            this.btn_PreviousYear.Click += new System.EventHandler(this.btn_PreviousYear_Click);
            // 
            // btn_PreviousMonth
            // 
            this.btn_PreviousMonth.BackColor = System.Drawing.Color.Transparent;
            this.btn_PreviousMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PreviousMonth.FlatAppearance.BorderSize = 0;
            this.btn_PreviousMonth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_PreviousMonth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_PreviousMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PreviousMonth.Image = global::BPersianCalender.Properties.Resources._1413037734_Last1;
            this.btn_PreviousMonth.Location = new System.Drawing.Point(198, 11);
            this.btn_PreviousMonth.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_PreviousMonth.Name = "btn_PreviousMonth";
            this.btn_PreviousMonth.Size = new System.Drawing.Size(30, 27);
            this.btn_PreviousMonth.TabIndex = 6;
            this.btn_PreviousMonth.UseVisualStyleBackColor = false;
            this.btn_PreviousMonth.Click += new System.EventHandler(this.btn_PreviousMonth_Click);
            // 
            // btn_NextYear
            // 
            this.btn_NextYear.BackColor = System.Drawing.Color.Transparent;
            this.btn_NextYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_NextYear.FlatAppearance.BorderSize = 0;
            this.btn_NextYear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_NextYear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_NextYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NextYear.Image = global::BPersianCalender.Properties.Resources._1413037734_Last;
            this.btn_NextYear.Location = new System.Drawing.Point(77, 11);
            this.btn_NextYear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_NextYear.Name = "btn_NextYear";
            this.btn_NextYear.Size = new System.Drawing.Size(30, 27);
            this.btn_NextYear.TabIndex = 7;
            this.btn_NextYear.UseVisualStyleBackColor = false;
            this.btn_NextYear.Click += new System.EventHandler(this.btn_NextYear_Click);
            // 
            // btn_NextMonth
            // 
            this.btn_NextMonth.BackColor = System.Drawing.Color.Transparent;
            this.btn_NextMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_NextMonth.FlatAppearance.BorderSize = 0;
            this.btn_NextMonth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_NextMonth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_NextMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NextMonth.Image = global::BPersianCalender.Properties.Resources._1413037734_Last;
            this.btn_NextMonth.Location = new System.Drawing.Point(288, 11);
            this.btn_NextMonth.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_NextMonth.Name = "btn_NextMonth";
            this.btn_NextMonth.Size = new System.Drawing.Size(30, 27);
            this.btn_NextMonth.TabIndex = 8;
            this.btn_NextMonth.UseVisualStyleBackColor = false;
            this.btn_NextMonth.Click += new System.EventHandler(this.btn_NextMonth_Click);
            // 
            // btn_SelectNextYears
            // 
            this.btn_SelectNextYears.BackColor = System.Drawing.Color.White;
            this.btn_SelectNextYears.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SelectNextYears.FlatAppearance.BorderSize = 0;
            this.btn_SelectNextYears.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_SelectNextYears.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_SelectNextYears.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SelectNextYears.Image = global::BPersianCalender.Properties.Resources._1413037734_Last;
            this.btn_SelectNextYears.Location = new System.Drawing.Point(292, 3);
            this.btn_SelectNextYears.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_SelectNextYears.Name = "btn_SelectNextYears";
            this.btn_SelectNextYears.Size = new System.Drawing.Size(30, 27);
            this.btn_SelectNextYears.TabIndex = 8;
            this.btn_SelectNextYears.UseVisualStyleBackColor = false;
            this.btn_SelectNextYears.Visible = false;
            this.btn_SelectNextYears.Click += new System.EventHandler(this.btn_SelectNextYears_Click);
            // 
            // btn_SelectPreviousYears
            // 
            this.btn_SelectPreviousYears.BackColor = System.Drawing.Color.White;
            this.btn_SelectPreviousYears.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SelectPreviousYears.FlatAppearance.BorderSize = 0;
            this.btn_SelectPreviousYears.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_SelectPreviousYears.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_SelectPreviousYears.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SelectPreviousYears.Image = global::BPersianCalender.Properties.Resources._1413037734_Last1;
            this.btn_SelectPreviousYears.Location = new System.Drawing.Point(3, 2);
            this.btn_SelectPreviousYears.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_SelectPreviousYears.Name = "btn_SelectPreviousYears";
            this.btn_SelectPreviousYears.Size = new System.Drawing.Size(30, 27);
            this.btn_SelectPreviousYears.TabIndex = 16;
            this.btn_SelectPreviousYears.UseVisualStyleBackColor = false;
            this.btn_SelectPreviousYears.Visible = false;
            this.btn_SelectPreviousYears.Click += new System.EventHandler(this.btn_SelectPreviousYears_Click);
            // 
            // lbl_Miladi
            // 
            this.lbl_Miladi.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Miladi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_Miladi.Location = new System.Drawing.Point(156, 194);
            this.lbl_Miladi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Miladi.Name = "lbl_Miladi";
            this.lbl_Miladi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Miladi.Size = new System.Drawing.Size(90, 22);
            this.lbl_Miladi.TabIndex = 10;
            this.lbl_Miladi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgv_SelectMonth
            // 
            this.dgv_SelectMonth.AllowUserToAddRows = false;
            this.dgv_SelectMonth.AllowUserToDeleteRows = false;
            this.dgv_SelectMonth.AllowUserToOrderColumns = true;
            this.dgv_SelectMonth.AllowUserToResizeColumns = false;
            this.dgv_SelectMonth.AllowUserToResizeRows = false;
            this.dgv_SelectMonth.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_SelectMonth.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_SelectMonth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SelectMonth.ColumnHeadersVisible = false;
            this.dgv_SelectMonth.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_SelectMonth.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_SelectMonth.IsDate = false;
            this.dgv_SelectMonth.Location = new System.Drawing.Point(0, 0);
            this.dgv_SelectMonth.Name = "dgv_SelectMonth";
            this.dgv_SelectMonth.RowHeadersVisible = false;
            this.dgv_SelectMonth.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_SelectMonth.RowTemplate.Height = 54;
            this.dgv_SelectMonth.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_SelectMonth.Size = new System.Drawing.Size(36, 11);
            this.dgv_SelectMonth.TabIndex = 14;
            this.dgv_SelectMonth.Visible = false;
            this.dgv_SelectMonth.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SelectMonth_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // dgv_SelectYear
            // 
            this.dgv_SelectYear.AllowUserToAddRows = false;
            this.dgv_SelectYear.AllowUserToDeleteRows = false;
            this.dgv_SelectYear.AllowUserToOrderColumns = true;
            this.dgv_SelectYear.AllowUserToResizeColumns = false;
            this.dgv_SelectYear.AllowUserToResizeRows = false;
            this.dgv_SelectYear.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_SelectYear.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_SelectYear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SelectYear.ColumnHeadersVisible = false;
            this.dgv_SelectYear.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_SelectYear.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_SelectYear.IsDate = false;
            this.dgv_SelectYear.Location = new System.Drawing.Point(42, 0);
            this.dgv_SelectYear.Name = "dgv_SelectYear";
            this.dgv_SelectYear.RowHeadersVisible = false;
            this.dgv_SelectYear.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_SelectYear.RowTemplate.Height = 54;
            this.dgv_SelectYear.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_SelectYear.Size = new System.Drawing.Size(48, 10);
            this.dgv_SelectYear.TabIndex = 15;
            this.dgv_SelectYear.Visible = false;
            this.dgv_SelectYear.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SelectYear_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Column1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Column2";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Column3";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // frm_PCalander
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(325, 219);
            this.Controls.Add(this.btn_SelectPreviousYears);
            this.Controls.Add(this.dgv_SelectMonth);
            this.Controls.Add(this.dgv_SelectYear);
            this.Controls.Add(this.btn_SelectNextYears);
            this.Controls.Add(this.pnl_WeekDays);
            this.Controls.Add(this.btn_PreviousYear);
            this.Controls.Add(this.btn_PreviousMonth);
            this.Controls.Add(this.btn_NextYear);
            this.Controls.Add(this.lbl_Year);
            this.Controls.Add(this.btn_NextMonth);
            this.Controls.Add(this.lbl_Month);
            this.Controls.Add(this.dgv_Calander);
            this.Controls.Add(this.lbl_MiladiDateTitle);
            this.Controls.Add(this.lbl_ShamsiDateTitle);
            this.Controls.Add(this.btn_Today);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.lbl_Shamsi);
            this.Controls.Add(this.lbl_Miladi);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "frm_PCalander";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقویم شمسی | تاریخ انتخاب شده :  ";
            this.Load += new System.EventHandler(this.frm_PCalander_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Calander)).EndInit();
            this.pnl_WeekDays.ResumeLayout(false);
            this.pnl_WeekDays.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SelectMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SelectYear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Calander;
        private System.Windows.Forms.DataGridViewTextBoxColumn c0;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2;
        private System.Windows.Forms.DataGridViewTextBoxColumn c3;
        private System.Windows.Forms.DataGridViewTextBoxColumn c4;
        private System.Windows.Forms.DataGridViewTextBoxColumn c5;
        private System.Windows.Forms.DataGridViewTextBoxColumn c6;
        private System.Windows.Forms.Button btn_PreviousYear;
        private System.Windows.Forms.Button btn_PreviousMonth;
        private System.Windows.Forms.Button btn_NextYear;
        private System.Windows.Forms.Label lbl_Year;
        private System.Windows.Forms.Button btn_NextMonth;
        private System.Windows.Forms.Label lbl_Month;
        private System.Windows.Forms.Button btn_Today;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lbl_Shanbe;
        private System.Windows.Forms.Label lbl_1Shanbe;
        private System.Windows.Forms.Label lbl_2Shanbe;
        private System.Windows.Forms.Label lbl_3Shanbe;
        private System.Windows.Forms.Label lbl_4Shanbe;
        private System.Windows.Forms.Label lbl_5Shanbe;
        private System.Windows.Forms.Label lbl_Jomee;
        private System.Windows.Forms.Panel pnl_WeekDays;
        private System.Windows.Forms.Label lbl_MiladiDateTitle;
        private System.Windows.Forms.Label lbl_ShamsiDateTitle;
        private System.Windows.Forms.Label lbl_Shamsi;
        private SMIO_DataGridView dgv_SelectMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private SMIO_DataGridView dgv_SelectYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btn_SelectNextYears;
        private System.Windows.Forms.Button btn_SelectPreviousYears;
        private System.Windows.Forms.Label lbl_Miladi;
    }
}