using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EducaINT
{
    public partial class frm_Tema : Form
    {
        public static bool voltou = false;
        public static List<Pergunta> perguntas_selecionadas = null;
        private List<string> temas = null;
        private string tema_escolhido = "";
        private int index_tema;

        public frm_Tema()
        {
            InitializeComponent();
            temas = Data_Controller.Perguntas.GroupBy(p => p.Tema).Select(t => t.Key).ToList();
            index_tema = 0;
            Load_Tema();
        }

        private void Load_Tema()
        {
            if (temas.Count > index_tema)
            {
                lbl_MateriaEscolhida.Text = temas[index_tema];
                lbl_MateriaEscolhida.Visible = pnl_TemaSelect.Visible = true;
                if (index_tema - 1 >= 0)
                {
                    lbl_MateriaTop.Text = temas[index_tema - 1];
                    lbl_MateriaTop.Visible = pnl_TemaTop.Visible = true;
                }
                else { lbl_MateriaTop.Visible = pnl_TemaTop.Visible = false;  }
                if (index_tema + 1 < temas.Count)
                {
                    lbl_MateriaInf.Text = temas[index_tema + 1];
                    lbl_MateriaInf.Visible = pnl_TemaInf.Visible = true;

                }
                else { lbl_MateriaInf.Visible = pnl_TemaInf.Visible = false; }

                tema_escolhido = temas[index_tema];
            }
            else
            {
                lbl_MateriaEscolhida.Visible = pnl_TemaSelect.Visible = false;
                lbl_MateriaTop.Visible = pnl_TemaTop.Visible = false;
                lbl_MateriaInf.Visible = pnl_TemaInf.Visible = false;
                btn_Avançar.Visible = false;
                MessageBox.Show("Não encontramos perguntas para você!\nChame seu professor!");
            }
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            voltou = true;
            Close();
        }

        private void btn_Avançar_Click(object sender, EventArgs e)
        {
            voltou = false;

            perguntas_selecionadas = Data_Controller.Perguntas.Where(p => !frm_Login.aluno_logado.Respostas
            .Select(r => r.id_pergunta).Contains(p.Id) || frm_Login.aluno_logado.Respostas
            .Where(r => !r.acertou).Select(r => r.id_pergunta).Contains(p.Id)).ToList();

            perguntas_selecionadas = perguntas_selecionadas.Where(p => p.Tema == tema_escolhido).ToList();

            if(perguntas_selecionadas.Count == 0)
            {
                MessageBox.Show("Não temos mais perguntas de\n" + tema_escolhido + " para você no momento!");
            }

            Close();
        }

        private void frm_Tema_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                if(index_tema > 0)
                {
                    index_tema--;
                    Load_Tema();
                }
            }
            else if (e.KeyCode == Keys.Down)
            {
                if(index_tema < temas.Count - 1)
                {
                    index_tema++;
                    Load_Tema();
                }
            }
        }

        private void lbl_Info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Use as setas do teclado:\n\n- Para cima\n- Para baixo\n\npara selecionar o tema!");
        }
    }
}
