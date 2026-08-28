using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;


namespace BPersianCalendar
{
    public static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(defaultValue: false);
            
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("fa-ir");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new CultureInfo("fa-ir"));

            Application.Run(new Frm_BPersianCalendar(null));
        }
    }
}