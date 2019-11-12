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
    public partial class frm_Professor : Form
    {
       

        public frm_Professor()
        {
            InitializeComponent();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            new frm_Cadastro_Pergunta().ShowDialog();
        }

        private void btn_Relatorio_Click(object sender, EventArgs e)
        {
            new frm_Relatório().ShowDialog();
        }
    }
}
