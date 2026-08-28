using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace BPersianCalendar.myClasses.shamsi
{
    public class Cls_DateValidation
    {
        // ******************** Variables ********************

        #region Variables

        private DateTime dt;

        #endregion Variables


        // ******************** Methods ********************

        #region Methods

        public bool validate(string dateStr, bool dateCheck)
        {
            if (dateStr == "    /  /")
            {
                return true;
            }

            PersianCalendar persianCalendar = new PersianCalendar();
            int year = persianCalendar.GetYear(DateTime.Now);
            int month = persianCalendar.GetMonth(DateTime.Now);
            int dayOfMonth = persianCalendar.GetDayOfMonth(DateTime.Now);
            bool flag = false;
            if (dateStr.Length > 0)
            {
                int length = dateStr.Length;
                string[] array = dateStr.Split('/');
                int num = array.Length;
                if (num < 3 || num < 2 || num < 1 || num < 0)
                {
                    return true;
                }

                string text = date(array[0]);
                string text2 = date(array[1]);
                string text3 = date(array[2]);
                if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(text2) || string.IsNullOrEmpty(text3))
                {
                    return true;
                }

                if (dateCheck)
                {
                    if (int.Parse(text2) == 12 && int.Parse(text3) > 29)
                    {
                        flag = true;
                    }

                    if (int.Parse(text) < 1370 || int.Parse(text) > 1399 || text.Length <= 1 || int.Parse(text) > year)
                    {
                        flag = true;
                    }

                    if (int.Parse(text2) < 1 || int.Parse(text2) > 12 || text2.Length <= 1)
                    {
                        flag = true;
                    }

                    if (int.Parse(text3) < 1 || int.Parse(text3) > 31 || text3.Length <= 1)
                    {
                        flag = true;
                    }
                }
                else
                {
                    if (int.Parse(text2) == 12 && int.Parse(text3) > 29)
                    {
                        flag = true;
                    }

                    if (int.Parse(text) < 1370 || int.Parse(text) > 1399 || text.Length <= 1)
                    {
                        flag = true;
                    }

                    if (int.Parse(text2) < 1 || int.Parse(text2) > 12 || text2.Length <= 1)
                    {
                        flag = true;
                    }

                    if (int.Parse(text3) < 1 || int.Parse(text3) > 31 || text3.Length <= 1)
                    {
                        flag = true;
                    }
                }
            }

            if (flag)
            {
                return true;
            }

            return false;
        }

        public string date(string sr)
        {
            char[] array = sr.ToArray();
            string text = string.Empty;
            for (int i = 0; i < array.Length; i++)
            {
                text = array[i].ToString() switch
                {
                    "۰" => text + "0",
                    "۱" => text + "1",
                    "۲" => text + "2",
                    "۳" => text + "3",
                    "۴" => text + "4",
                    "۵" => text + "5",
                    "۶" => text + "6",
                    "۷" => text + "7",
                    "۸" => text + "8",
                    "۹" => text + "9",
                    "0" => text + "0",
                    "1" => text + "1",
                    "2" => text + "2",
                    "3" => text + "3",
                    "4" => text + "4",
                    "5" => text + "5",
                    "6" => text + "6",
                    "7" => text + "7",
                    "8" => text + "8",
                    "9" => text + "9",
                    _ => sr,
                };
            }

            return text;
        }

        public string GetDateStr(string str)
        {
            string[] array = str.Split('/');
            string empty = string.Empty;
            string text = datestr(array[0]);
            string text2 = datestr(array[1]);
            string text3 = datestr(array[2]);
            return text + "/" + text2 + "/" + text3;
        }

        public string datestr(string sr)
        {
            char[] array = sr.ToArray();
            string text = string.Empty;
            for (int i = 0; i < array.Length; i++)
            {
                text = array[i].ToString() switch
                {
                    "0" => text + "۰",
                    "1" => text + "۱",
                    "2" => text + "۲",
                    "3" => text + "۳",
                    "4" => text + "۴",
                    "5" => text + "۵",
                    "6" => text + "۶",
                    "7" => text + "۷",
                    "8" => text + "۸",
                    "9" => text + "۹",
                    "۰" => text + "۰",
                    "۱" => text + "۱",
                    "۲" => text + "۲",
                    "۳" => text + "۳",
                    "۴" => text + "۴",
                    "۵" => text + "۵",
                    "۶" => text + "۶",
                    "۷" => text + "۷",
                    "۸" => text + "۸",
                    "۹" => text + "۹",
                    _ => sr,
                };
            }

            return text;
        }


        public DateTime GetDate(string str)
        {
            string[] array = str.Split('/');
            string empty = string.Empty;
            string s = dateR(array[0]);
            string s2 = dateR(array[1]);
            string s3 = dateR(array[2]);
            if (int.Parse(s2) > 12 || int.Parse(s3) > 31)
            {
                MessageBox.Show("قالب تاریخ نادرست است", "خطا");
                return dt;
            }

            PersianCalendar calendar = new PersianCalendar();
            dt = new DateTime(int.Parse(s), int.Parse(s2), int.Parse(s3), calendar);
            return dt;
        }


        public string dateR(string sr)
        {
            char[] array = sr.ToArray();
            string text = string.Empty;
            for (int i = 0; i < array.Length; i++)
            {
                text = array[i].ToString() switch
                {
                    "۰" => text + "0",
                    "۱" => text + "1",
                    "۲" => text + "2",
                    "۳" => text + "3",
                    "۴" => text + "4",
                    "۵" => text + "5",
                    "۶" => text + "6",
                    "۷" => text + "7",
                    "۸" => text + "8",
                    "۹" => text + "9",
                    "0" => text + "0",
                    "1" => text + "1",
                    "2" => text + "2",
                    "3" => text + "3",
                    "4" => text + "4",
                    "5" => text + "5",
                    "6" => text + "6",
                    "7" => text + "7",
                    "8" => text + "8",
                    "9" => text + "9",
                    _ => sr,
                };
            }

            return text;
        }

        #endregion Methods


    }
}
