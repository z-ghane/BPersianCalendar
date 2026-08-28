using BPersianCalendar.myClasses.shamsi;
using System.Windows.Forms;


namespace BPersianCalendar.myClasses.dgv
{
    internal class Cls_dgvYearMonth
    {
        // *********************** Fill_dgv_Month ***********************

        public static void Fill_dgv_Month(DataGridView dgv, Label lbl_Month)
        {
            for (int i = 0, m = 1; i < 4; i++)
            {
                for (int j = 0; j < 3; j++, m++)
                {
                    dgv[j, i].Value = Cls_ShamsiStatic.convertShamsiMonthNumberToName(m);

                    if (dgv[j, i].Value.ToString() == lbl_Month.Text.ToString())
                    {
                        dgv.ClearSelection();
                        dgv[j, i].Selected = true;

                    }
                }
            }
        }


        // *********************** Fill_dgv_Year ***********************

        public static void Fill_dgv_Year(
            DataGridView dgv, string fillWay, int currentYear)
        {
            int firstYearInDgv = 0;
            int tempYear;
            switch (fillWay)
            {
                case "f": // fill for the first time
                          // the current year have a static place
                    firstYearInDgv = currentYear - 6;
                    break;


                case "py": // fill for the btn_PrevYear selection
                    tempYear = int.Parse(dgv[0, 0].Value.ToString());
                    firstYearInDgv = tempYear - 12;
                    break;


                case "ny": // fill for the btn_NextYear selection
                    // 2: column
                    // 3: row
                    // the biggest year in dgv cells
                    tempYear = int.Parse(dgv[2, 3].Value.ToString());
                    firstYearInDgv = tempYear + 1;
                    break;
            }


            for (int i = 0, m = firstYearInDgv; i < 4; i++)
            {
                for (int j = 0; j < 3; j++, m++)
                {
                    dgv[j, i].Value = m;

                    if (fillWay == "f" & dgv[j, i].Value.ToString() == currentYear.ToString())
                    {
                        dgv.ClearSelection();
                        dgv[j, i].Selected = true;
                    }
                }
            }
        }




    }
}
