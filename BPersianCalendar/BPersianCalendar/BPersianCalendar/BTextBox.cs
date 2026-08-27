using BPersianCalendar.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace BPersianCalendar
{
    public class BTextBox : TextBox
    {
        private IContainer components = null;

        public BTextBox()
        {
            SetStyle(ControlStyles.UserPaint, value: true);
            RightToLeft = RightToLeft.Yes;
            Font = new Font("Tahoma", 8f, FontStyle.Regular);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Image calendar = Resources.img_png__calendar_20px;
            e.Graphics.DrawImage(calendar, new Point(0, 0));
        }

        protected override void OnTextChanged(EventArgs e)
        {
            if (Text.Length > 0)
            {
                SetStyle(ControlStyles.UserPaint, value: false);
                Font = new Font("Tahoma", 8f, FontStyle.Regular);
            }
            else
            {
                SetStyle(ControlStyles.UserPaint, value: true);
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                ShamsiCalandar shamsiCalander2 = new ShamsiCalandar();
                PCalandar pCalander = new PCalandar();
                shamsiCalander2 = pCalander.getshamsiCalander();
                Text = shamsiCalander2.ShamsiDate;
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
            this.components = new System.ComponentModel.Container();
        }
    }
}
