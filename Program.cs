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
        public static Form1 form; //only 1 form is needed currently (01.02.2021)
        public static TabellenManipulation Tm; //only 1 TabellenManipulation is needed currently (01.02.2021)
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
