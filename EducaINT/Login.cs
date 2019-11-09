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
    public partial class frm_Login : Form
    {
        public static Aluno aluno_logado = null;
       
        public frm_Login()
        {
            InitializeComponent();
            Data_Controller.Start_Controller();
            lbl_Titulo.Parent = pic_Banner;
        }

        private void btn_Fechar_Click(object sender, EventArgs e) { Application.Exit(); }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            aluno_logado = new Aluno();
            aluno_logado.Nome = txt_NomeUsuario.Text;
            aluno_logado.Senha = txt_Senha.Text;

            if (!Aluno_Registrado(aluno_logado)) { Data_Controller.Add_Aluno(aluno_logado); }
            new frm_Escolher_Avatar().ShowDialog();
            new frm_Perfil().ShowDialog();
        }

        private bool Aluno_Registrado(Aluno aluno_logado)
        {
            Aluno alunos = Data_Controller.Alunos.FirstOrDefault(aluno => aluno.Nome == aluno_logado.Nome && aluno.Senha ==aluno_logado.Senha);
            if (alunos == null)
                return true;
            else
                return false;
        }

        private void btn_Professor_Click(object sender, EventArgs e)
        {
            new frm_Autenticar_Professor().ShowDialog();
            if(frm_Autenticar_Professor.liberar) new frm_Professor().ShowDialog();
        }
    }
}
