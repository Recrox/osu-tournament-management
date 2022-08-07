using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace osu_tournament_management
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// https://docs.google.com/spreadsheets/d/13kteUCgjTGyzIcc-lImpD9ynfQIo1DHYS2X2_JxeOk4/edit#gid=0
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new OsuToolForm());
            
        }
    }
}
