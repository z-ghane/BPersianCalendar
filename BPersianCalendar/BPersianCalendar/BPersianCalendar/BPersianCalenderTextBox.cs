using BPersianCalendar.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace BPersianCalendar
{
    public class BPersianCalenderTextBox : TextBox
    {
        public bool SwitchDateFlag = false;

        public PersianCalendar pc = new PersianCalendar();

        private IContainer components = null;

        public DateTime Miladi { get; set; }

        public string Shamsi { get; set; }

        public bool NowDateSelected { get; set; }

        public string SelectedDate { get; set; }

        public BPersianCalenderTextBox()
        {
            InitializeComponent();
            Button button = new Button();
            button.Size = new Size(
                Resources.img_png__calendar_20px.Width, 
                Resources.img_png__calendar_20px.Height);
            button.Location = new Point(-1, -3);
            button.Cursor = Cursors.Hand;
            button.Image = Resources.img_png__calendar_20px;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseDownBackColor = Color.White;
            button.FlatAppearance.MouseOverBackColor = Color.White;
            button.FlatAppearance.CheckedBackColor = Color.White;
            button.Click += btn_Click;
            base.Controls.Add(button);
            base.ReadOnly = true;
            SendMessage(base.Handle, 211, (IntPtr)2, (IntPtr)(button.Width << 16));
            base.TextAlign = HorizontalAlignment.Left;
            ContextMenuStrip contextMenuStrip = new ContextMenuStrip
            {
                Font = new Font("tahoma", 9f),
                Items = { "خالی کردن", "-", "امروز", "روز بعد", "روز قبل", "-", "اول ماه جاری", "آخر ماه جاری" }
            };
            ContextMenuStrip = contextMenuStrip;
            contextMenuStrip.Items[0].Click += Null_Click;
            contextMenuStrip.Items[2].Click += Today_Click;
            contextMenuStrip.Items[3].Click += NextDay_Click;
            contextMenuStrip.Items[4].Click += PrevDay_Click;
            contextMenuStrip.Items[6].Click += FirstDayOfMonth_Click;
            contextMenuStrip.Items[7].Click += LastDayOfMonth_Click;
            NowDateSelected = false;
            Invoke();
        }

        public void LastDayOfMonth_Click(object sender, EventArgs e)
        {
            Miladi = pc.ToDateTime(pc.GetYear(DateTime.Now), pc.GetMonth(DateTime.Now), pc.GetDaysInMonth(pc.GetYear(DateTime.Now), pc.GetMonth(DateTime.Now)), 0, 0, 0, 0);
            Text = new ConvertDate().MiladiToShamsi(Miladi);
            Shamsi = new ConvertDate().MiladiToShamsi(Miladi);
            SelectedDate = Shamsi.Replace("/", "");
        }

        public void FirstDayOfMonth_Click(object sender, EventArgs e)
        {
            Miladi = pc.ToDateTime(pc.GetYear(DateTime.Now), pc.GetMonth(DateTime.Now), 1, 0, 0, 0, 0);
            Text = new ConvertDate().MiladiToShamsi(Miladi);
            Shamsi = new ConvertDate().MiladiToShamsi(Miladi);
            SelectedDate = Shamsi.Replace("/", "");
        }

        public void Invoke()
        {
            if (NowDateSelected)
            {
                Text = new ConvertDate().MiladiToShamsi(DateTime.Now);
                Miladi = DateTime.Now.Date;
                Shamsi = new ConvertDate().MiladiToShamsi(Miladi);
                SelectedDate = Shamsi.Replace("/", "");
            }
        }

        public void SwitchDate_Click(object sender, EventArgs e)
        {
            if (!SwitchDateFlag)
            {
                SwitchDateFlag = true;
                Text = Miladi.ToShortDateString();
            }
            else
            {
                SwitchDateFlag = false;
                Text = Shamsi;
            }
        }

        public void PrevDay_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Text))
            {
                Miladi = Miladi.AddDays(-1.0);
                Text = new ConvertDate().MiladiToShamsi(Miladi);
                Shamsi = new ConvertDate().MiladiToShamsi(Miladi);
                SelectedDate = Shamsi.Replace("/", "");
            }
        }

        public void NextDay_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Text))
            {
                Miladi = Miladi.AddDays(1.0);
                Text = new ConvertDate().MiladiToShamsi(Miladi);
                Shamsi = new ConvertDate().MiladiToShamsi(Miladi);
                SelectedDate = Shamsi.Replace("/", "");
            }
        }

        public void Today_Click(object sender, EventArgs e)
        {
            Text = new ConvertDate().MiladiToShamsi(DateTime.Now);
            Miladi = DateTime.Now.Date;
            Shamsi = new ConvertDate().MiladiToShamsi(Miladi);
            SelectedDate = Shamsi.Replace("/", "");
        }

        public void Null_Click(object sender, EventArgs e)
        {
            Text = null;
            Miladi = default(DateTime).Date;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                LoadCalender();
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            LoadCalender();
        }

        private void LoadCalender()
        {
            ShamsiCalandar shamsiCalander2 = new ShamsiCalandar();
            shamsiCalander2 = new PCalandar().getshamsiCalander();
            Text = shamsiCalander2.ShamsiDate;
            Miladi = shamsiCalander2.MiladiDate;
            Shamsi = shamsiCalander2.ShamsiDate;
            if (!string.IsNullOrEmpty(Shamsi))
            {
                SelectedDate = Shamsi.Replace("/", "");
            }
        }

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

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
            this.components = new System.ComponentModel.Container();
        }
    }
}
