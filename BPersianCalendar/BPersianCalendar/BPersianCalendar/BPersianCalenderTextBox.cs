using BPersianCalendar.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace BPersianCalendar
{
    public class BPersianCalenderTextBox : TextBox
    {
        public DateTime Miladi;

        private IContainer components = null;

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
