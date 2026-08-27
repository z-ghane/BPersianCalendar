using System.Windows.Forms;


namespace BPersianCalendar.myClasses.dgvStyle
{
    internal class Cls_dgvYearMonthStyle
    {
        // *********************** Design_dgv_YearMonth ***********************

        public static void Design_dgv_YearMonth(
            DataGridView dgv,
            int formHeight
        )
        {
            Cls_dgvStyle.SetDgvStyle(dgv);

            //dgv.IsDate = false;
            dgv.Visible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgv.BorderStyle = BorderStyle.None;


            // ---------- rows

            int numberOfRows = 4;
            dgv.RowTemplate.Height = Cls_dgvStyle.CalculateRowHeight(formHeight, numberOfRows);


            // ------ Create columns, rows

            Cls_dgvStyle.AddColumns(dgv, 3);
            Cls_dgvStyle.AddRows(dgv, numberOfRows);
        }

    }
}
