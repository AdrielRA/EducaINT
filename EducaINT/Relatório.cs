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
    public partial class frm_Relatório : Form
    {
        public frm_Relatório()
        {
            InitializeComponent();
        }

        private void btn_RelPerguntas_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Gerar relatório de perguntas");
            new frm_Relatório_Perguntas().ShowDialog();
        } 

        private void btn_RelRespostaAlunos_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Gerar relatório de respostas");
            new frm_Relatório_Alunos().ShowDialog();
        }
    }
}
