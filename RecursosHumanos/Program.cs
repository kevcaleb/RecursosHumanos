using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using System.Globalization;
using System.Threading;
using DevExpress.LookAndFeel;

namespace RecursosHumanos
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            UserLookAndFeel.Default.SetSkinStyle(SkinStyle.Office2019Colorful);

            BonusSkins.Register();

            // Establecer la cultura del hilo actual a "Español, Honduras"
            CultureInfo cultureInfo = new CultureInfo("es-HN");
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            

            Application.Run(new splPantallaCarga());
        }
    }
}
