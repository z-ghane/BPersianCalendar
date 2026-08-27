using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BPersianCalendar
{
    public class SMIO_DataGridView : DataGridView
    {
        private IContainer components = null;

        public bool IsDate { get; set; }

        public SMIO_DataGridView()
        {
            InitializeComponent();
            base.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            base.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        protected override void OnCellFormatting(DataGridViewCellFormattingEventArgs e)
        {
            if (base.Columns[e.ColumnIndex].Name == "fDate")
            {
                ShortFormDateFormat(e);
            }
        }

        private static void ShortFormDateFormat(DataGridViewCellFormattingEventArgs formatting)
        {
            if (formatting.Value == null || string.IsNullOrEmpty(formatting.Value.ToString()))
            {
                return;
            }

            try
            {
                StringBuilder stringBuilder = new StringBuilder();
                string text = formatting.Value.ToString();
                if (!text.Contains("/"))
                {
                    stringBuilder.Append(text.Substring(0, 4));
                    stringBuilder.Append("/");
                    stringBuilder.Append(text.Substring(4, 2));
                    stringBuilder.Append("/");
                    stringBuilder.Append(text.Substring(6, 2));
                    formatting.Value = stringBuilder.ToString();
                    formatting.FormattingApplied = true;
                }
            }
            catch (FormatException)
            {
                formatting.FormattingApplied = false;
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
