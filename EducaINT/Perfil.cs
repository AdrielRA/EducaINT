using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducaINT
{
    public partial class frm_Perfil : Form
    {
        public frm_Perfil()
        {
            InitializeComponent();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Jogar_Click(object sender, EventArgs e)
        {
            new frm_Tema().ShowDialog();
            if(!frm_Tema.voltou) new frm_Jogo().ShowDialog();
        }
    }
}
