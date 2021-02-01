using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OffertenErsteller
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        /// 
        public static Form1 form;
        public static TabellenManipulation Tm;
        [STAThread]
        static void Main()
        {
            ArbeitsObjektList.FileReading();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Tm = new TabellenManipulation();
            Application.Run(form = new Form1());
        }
    }
}
