using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducaINT
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try { Application.Run(new frm_Login()); }
            catch { MessageBox.Show("Algo deu errado :(\n\nChame o professor!", "Ohh não...", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
