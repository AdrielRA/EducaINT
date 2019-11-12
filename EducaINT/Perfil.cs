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
            pic_Aluno.Image = new Bitmap(frm_Escolher_Avatar.avatar);
            lblNome.Text += frm_Login.aluno_logado.Nome;
            if (frm_Login.aluno_logado.Respostas.Count==0)
            {
                prog_Bar_1.Value = 0;   
            }
            else
            {
                prog_Bar_1.Value = frm_Login.aluno_logado.Respostas.Count;
            }
            if (frm_Login.aluno_logado.Respostas.Count==0)
            {
                prog_Bar_2.Value = 0;
            }
            else
            {
                prog_Bar_2.Value = frm_Login.aluno_logado.Respostas.Where(r => r.acertou).Count();
            }            
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            pic_Aluno.Image.Dispose();
            Close();
        }

        private void btn_Jogar_Click(object sender, EventArgs e)
        {
            if (Data_Controller.Perguntas.Count > 0)
            {
                new frm_Tema().ShowDialog();
                if (!frm_Tema.voltou && frm_Tema.perguntas_selecionadas.Count > 0) new frm_Jogo().ShowDialog();
            }
            else
            {
                MessageBox.Show("Peça ao seu professor que\ndisponibilize novas perguntas!");
            }
        }
    }
}
