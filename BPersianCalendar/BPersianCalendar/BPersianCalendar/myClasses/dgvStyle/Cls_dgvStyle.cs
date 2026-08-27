using System.Windows.Forms;


namespace BPersianCalendar.myClasses.dgvStyle
{
    internal class Cls_dgvStyle
    {
        public static void SetDgvStyle(DataGridView dgv)
        {
            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            dgv.Margin = new Padding(0);


            // -------------- columns

            dgv.AllowUserToOrderColumns = false;
            dgv.AllowUserToResizeColumns = false;

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.ColumnHeadersVisible = false;


            // ---------- rows

            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;

            dgv.RowHeadersVisible = false;
            dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;

            dgv.RowTemplate.ReadOnly = true;
            dgv.RowTemplate.Resizable = DataGridViewTriState.False;


            // ---------- cells

            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }


        public static int CalculateRowHeight(int containerHeight, int numberOfRows)
        {
            int temp = containerHeight / numberOfRows;

            int calcHeight =
                temp * numberOfRows < containerHeight ?
                temp :
                (containerHeight / numberOfRows) - 1;
            //(containerHeight / numberOfRows) - 1;

            return calcHeight;
        }


        public static void AddColumns(DataGridView dgv, int numberOfColumns)
        {
            for (int i = 0; i < numberOfColumns; i++)
            {
                DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();

                col.Name = "c" + i.ToString();
                col.HeaderText = "c" + i.ToString();

                dgv.Columns.Add(col);
            }
        }


        public static void AddRows(DataGridView dgv, int numberOfRows)
        {
            dgv.Rows.Add(numberOfRows);

            dgv.Rows[dgv.Rows.Count - 1].Height--;
        }

    }
}
