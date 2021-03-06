﻿using System;
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
            label1.Text = "UNIFENAS - " + DateTime.Today.Year.ToString();
            Clear_Controls();
        }

        private void Clear_Controls()
        {
            txt_NomeUsuario.Text = txt_NomeUsuario.HintText;
            txt_Senha.Text = txt_Senha.HintText;
            txt_NomeUsuario.Focus();
            txt_NomeUsuario.Select();
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
            Clear_Controls();
        }

        private bool Aluno_Registrado(Aluno aluno_logando)
        {
            Aluno aluno_registrado = Data_Controller.Alunos.FirstOrDefault(aluno => aluno.Nome == aluno_logando.Nome && aluno.Senha == aluno_logando.Senha);
            if (aluno_registrado != null) aluno_logado = aluno_registrado;
            return aluno_registrado != null;
        }

        private void btn_Professor_Click(object sender, EventArgs e)
        {
            new frm_Autenticar_Professor().ShowDialog();
            if (frm_Autenticar_Professor.liberar) new frm_Professor().ShowDialog();
            else MessageBox.Show("Acesso negado!");
        }

        private void btn_Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Conteudistas:
Jéssica Hendiara Almeida Nunes
Letícia Aparecida Silva
Mayara de Souza Novais
Rafaela Maria da Silva

Desenvolvedores:
Adriel Ricardo Azevedo
Eder Costa Maciel
Juscimara Cristina Borges
Lucas Robert de Abreu
Suzane Freire Albino

Organizadores:
Flávia Aparecida Oliveira Santos
Maria Cristina da Silva
Patrícia Carolina de Souza Pereira

GitHub: https://github.com/AdrielRA/EducaINT", "Créditos:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
