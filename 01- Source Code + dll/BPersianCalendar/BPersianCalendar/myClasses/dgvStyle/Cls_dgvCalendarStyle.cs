using System.Drawing;
using System.Windows.Forms;


namespace BPersianCalendar.myClasses.dgvStyle
{
    internal class Cls_dgvCalendarStyle
    {
        // *********************** Design_dgv_Calendar ***********************

        public static void Design_dgv_Calendar(DataGridView dgv)
        {
            Cls_dgvStyle.SetDgvStyle(dgv);

            dgv.BackgroundColor = SystemColors.ButtonHighlight;
            dgv.BorderStyle = BorderStyle.Fixed3D;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dgv.StandardTab = true;
            dgv.TabIndex = 0;


            // ---------- cells

            dgv.DefaultCellStyle.BackColor = SystemColors.ButtonHighlight;


            // ---------- rows

            int numberOfRows = 5;
            dgv.RowTemplate.Height = Cls_dgvStyle.CalculateRowHeight(dgv.Height, numberOfRows);


            // ------ Create columns, rows

            Cls_dgvStyle.AddColumns(dgv, 7);
            Cls_dgvStyle.AddRows(dgv, numberOfRows);

            // --- fridays:
            SetDgvCellStyleForFridays(dgv);
        }


        private static void SetDgvCellStyleForFridays(DataGridView dgv)
        {
            dgv.Columns[6].DefaultCellStyle.ForeColor = ColorTranslator.FromHtml("#D10000");
            dgv.Columns[6].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FFE6E6");
        }



    }
}
