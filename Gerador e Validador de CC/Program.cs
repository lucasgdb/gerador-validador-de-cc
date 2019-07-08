using Gerador_de_CC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace Gerador_de_CC_com_Bin
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

            if (Gerador_e_Validador_de_CC.Properties.Settings.Default.Run == "Gerador")
            {
                Application.Run(new FrmGerador());
            }
            else if(Gerador_e_Validador_de_CC.Properties.Settings.Default.Run == "Validador")
            {
                Application.Run(new frmValidador());
            }
            else
            {
                Application.Run(new FrmGerador());
            }
        }
    }
}
