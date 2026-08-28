using BPersianCalendar.myClasses.shamsi;
using System;
using System.Globalization;
using System.Windows.Forms;


namespace BPersianCalendar.myClasses.dgv
{
    internal class Cls_dgvCalendar
    {
        // *********************** ResetCalender ***********************

        private static void Reset_dgv_Calendar(DataGridView dgv)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Value = "";
                }
            }

            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    DataGridViewCell dgvCell = dgv.Rows[i].Cells["c" + j.ToString()];
                    dgvCell.Value = "";
                }
            }
        }


        // *********************** Fill_dgv_Calendar ***********************

        public static void Fill_dgv_Calendar(
            DataGridView dgv,
            int yearNo,
            int monthNo
            )
        {
            Reset_dgv_Calendar(dgv);

            PersianCalendar pc = new PersianCalendar(); // دسترسی به کتابخونه تاریخ شمسی 


            // پیدا کردن تعداد روزهای ماه انتخاب شده
            int daysInMonth = pc.GetDaysInMonth(yearNo, monthNo);
            DateTime dtt;
            DayOfWeek dow;

            // j : colNo equals to --> DayOfWeekNoInMonth
            int j = 0;

            // i : rowNo
            for (
                int i = 0, d = 1;
                (i < 5) || 
                (i == 4 & d < daysInMonth); // 1405.12.29 was exception so we should check this
                i++
            )
            {
                // d : count days in a month
                for (
                    int x = 1;
                    x <= 7;
                    x++, d++
                )
                {
                    dtt = pc.ToDateTime(yearNo, monthNo, d, 1, 1, 1, 1, 1);
                    dow = pc.GetDayOfWeek(dtt);

                    j =
                        Cls_ShamsiStatic.convertMiladiToShamsiWeekDayNumber(dow);


                    DataGridViewCell currentCell =
                        dgv.
                        Rows[i].
                        Cells["c" + j.ToString()];

                    currentCell.Value = pc.GetDayOfMonth(dtt);

                    if (j == 6)
                    {
                        d++;
                        break;
                    }
                    if (d == daysInMonth)
                    {
                        break;
                    }
                }

            }

            LastDays(dgv, daysInMonth);
        }


        // it is used when the number of monthdays is 30 or 31
        // and the start of the month is on Friday (the last column in the first row
        // then it adds numbers to the first row cells.
        private static void LastDays(DataGridView dgv, int daysInMonth)
        {
            int lastRowData = 0;

            if (dgv.Rows[4].Cells["c6"].Value != null)
            {
                if (!string.IsNullOrEmpty(dgv.Rows[4].Cells["c6"].Value.ToString()))
                {
                    lastRowData = int.Parse(dgv.Rows[4].Cells["c6"].Value.ToString());
                }
            }


            if (lastRowData != 31 && lastRowData != 0)
            {
                if (daysInMonth >= 29 && lastRowData >= 29)
                {
                    int RemainDay = daysInMonth - lastRowData;
                    for (int i = 0; i < RemainDay; i++)
                    {
                        dgv.Rows[0].Cells["c" + i.ToString()].Value = ++lastRowData;
                    }
                }
            }
        }


        // *********************** SelectCell_dgv_Calendar ***********************

        // shamsiDayNo parameter is an important parameter that
        // determine the flow of the method
        // if it is 0 then the cell that is selected before is not changed
        // otherwise the selected cell is changed
        public static void SelectCell_dgv_Calendar(
            DataGridView dgv,
            int shamsiDayNo,
            int selectedRowIndex,
            int selectedColumnIndex
            )
        {
            // the selected cell is changed otherwise it isn't
            if (shamsiDayNo != 0)
            {
                DataGridViewCell myCell;

                // i: over rows
                for (int i = 0; i <= 4; i++)
                {
                    // j: over columns
                    for (int j = 0; j < 7; j++)
                    {
                        myCell =
                            dgv.
                            Rows[i].
                            Cells["c" + j.ToString()];


                        if (myCell.Value.ToString() == shamsiDayNo.ToString())
                        {
                            dgv.ClearSelection();
                            dgv.CurrentCell = myCell;
                            myCell.Selected = true;
                            return;
                        }
                    }
                }
            }
            else
            {
                dgv.ClearSelection();
                dgv.
                    Rows[selectedRowIndex].
                    Cells[selectedColumnIndex].Selected = true;
            }
        }




    }
}
