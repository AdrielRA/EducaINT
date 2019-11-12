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
    public partial class frm_Jogo : Form
    {
        private Pergunta pergunta_em_jogo;
        private int limite_pulo = 3;
        private Random rand = new Random();
        private Aluno A;
        private TimeSpan Tempo = TimeSpan.FromSeconds(0);

        public frm_Jogo()
        {
            InitializeComponent();
            timer1.Enabled = true;
            pergunta_em_jogo = frm_Tema.perguntas_selecionadas[new Random().Next(0, frm_Tema.perguntas_selecionadas.Count)];
            Load_Pergunta(pergunta_em_jogo);
        }

        private void Load_Pergunta(Pergunta pergunta)
        {
            if (frm_Tema.perguntas_selecionadas.Contains(pergunta))
            {
                frm_Tema.perguntas_selecionadas.Remove(pergunta);
            }
            lbl_Pulos.Text = "Pulos: " + limite_pulo.ToString("00");
            Tempo = TimeSpan.FromSeconds(0);
            lbl_Tempo.Text = Tempo.ToString();
            lbl_Pergunta.Text = pergunta_em_jogo.Questao;
            if(pergunta.Alternativas.Count > 0)
            {
                lbl_Alternativa_1.Text = pergunta.Alternativas[0];
                lbl_Alternativa_1.Visible = rb_Op_1.Visible = true;
                if (pergunta.Alternativas.Count > 1)
                {
                    lbl_Alternativa_2.Text = pergunta.Alternativas[1];
                    lbl_Alternativa_2.Visible = rb_Op_2.Visible = true;
                    if (pergunta.Alternativas.Count > 2)
                    {
                        lbl_Alternativa_3.Text = pergunta.Alternativas[2];
                        lbl_Alternativa_3.Visible = rb_Op_3.Visible = true;
                        if (pergunta.Alternativas.Count > 3)
                        {
                            lbl_Alternativa_4.Text = pergunta.Alternativas[3];
                            lbl_Alternativa_4.Visible = rb_Op_4.Visible = true;
                            if (pergunta.Alternativas.Count > 4)
                            {
                                lbl_Alternativa_5.Text = pergunta.Alternativas[4];
                                lbl_Alternativa_5.Visible = rb_Op_5.Visible = true;
                            }
                            else
                            {
                                lbl_Alternativa_5.Visible = rb_Op_5.Visible = false;
                            }
                        }
                        else
                        {
                            lbl_Alternativa_4.Visible = rb_Op_4.Visible = false;
                            lbl_Alternativa_5.Visible = rb_Op_5.Visible = false;
                        }
                    }
                    else
                    {
                        lbl_Alternativa_3.Visible = rb_Op_3.Visible = false;
                        lbl_Alternativa_4.Visible = rb_Op_4.Visible = false;
                        lbl_Alternativa_5.Visible = rb_Op_5.Visible = false;
                    }
                }
                else
                {
                    lbl_Alternativa_2.Visible = rb_Op_2.Visible = false;
                    lbl_Alternativa_3.Visible = rb_Op_3.Visible = false;
                    lbl_Alternativa_4.Visible = rb_Op_4.Visible = false;
                    lbl_Alternativa_5.Visible = rb_Op_5.Visible = false;                    
                }
            }
            else
            {
                lbl_Alternativa_1.Visible = rb_Op_1.Visible = false;
                lbl_Alternativa_2.Visible = rb_Op_2.Visible = false;
                lbl_Alternativa_3.Visible = rb_Op_3.Visible = false;
                lbl_Alternativa_4.Visible = rb_Op_4.Visible = false;
                lbl_Alternativa_5.Visible = rb_Op_5.Visible = false;
            }
        }

        private void btn_Pause_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Vai mesmo sair?", "Ainda não acabou...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) { Close(); }
        }

        private void cb_Escolhe_Alternativa(object sender, EventArgs e)
        {
            LollipopRadioButton rb = sender as LollipopRadioButton;
            if (rb.Checked)
            {
                var result = MessageBox.Show("Você tem certeza ?", "Responda!", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    bool acertou_resposta = rb.Tag != null && rb.Tag.ToString() == (pergunta_em_jogo.Resposta_Certa).ToString();
                    
                    frm_Login.aluno_logado.Respostas = frm_Login.aluno_logado.Respostas.Where(r => r.id_pergunta != pergunta_em_jogo.Id).ToList();
                    Aluno.Resposta resposta = new Aluno.Resposta() { id_pergunta = pergunta_em_jogo.Id, acertou = acertou_resposta };
                    
                    if (acertou_resposta)
                    {
                        timer1.Enabled = false;
                        MessageBox.Show("Parabéns, você acertou !!");

                        resposta.pontos = new Random().Next(10, 50) + 100 / Tempo.TotalSeconds;

                        if (frm_Tema.perguntas_selecionadas.Count > 0)
                        {
                            pergunta_em_jogo = frm_Tema.perguntas_selecionadas[new Random().Next(0, frm_Tema.perguntas_selecionadas.Count)];
                            Load_Pergunta(pergunta_em_jogo);
                        }
                        else
                        {
                            MessageBox.Show("Parabéns, você concluiu\nestas perguntas!");
                            Close();
                        }
                        timer1.Enabled = true;
                    }
                    else
                    {
                        timer1.Enabled = false;
                        MessageBox.Show("Resposta errada, não desista!");

                        resposta.pontos = 0;

                        if (frm_Tema.perguntas_selecionadas.Count > 0)
                        {
                            pergunta_em_jogo = frm_Tema.perguntas_selecionadas[new Random().Next(0, frm_Tema.perguntas_selecionadas.Count)];
                            Load_Pergunta(pergunta_em_jogo);
                        }
                        else
                        {
                            MessageBox.Show("Você concluiu estás perguntas, tente outras!");
                            Close();
                        }
                    }

                    frm_Login.aluno_logado.Respostas.Add(resposta);
                    Data_Controller.Save_Alunos_To_Storage();
                    rb.Checked = false;
                }
            }
        }

        private void Btn_Pular_Click(object sender, EventArgs e)
        {
            if (limite_pulo > 0)
            {
                pergunta_em_jogo = frm_Tema.perguntas_selecionadas[new Random().Next(0, frm_Tema.perguntas_selecionadas.Count)];
                Load_Pergunta(pergunta_em_jogo);
                Tempo = TimeSpan.FromSeconds(0);
                lbl_Pulos.Text = "Pulos: " + (--limite_pulo).ToString("00");
            }           
            else
            {
                var Result2 = MessageBox.Show("Prefere tentar depois ?"," Não desista!",MessageBoxButtons.YesNo);
                if (Result2 == DialogResult.Yes) { Close(); }                               
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Tempo += TimeSpan.FromSeconds(1);
            lbl_Tempo.Text = Tempo.ToString();
        }

        private void lbl_Alternativa_Click(object sender, EventArgs e)
        {
            int index = int.Parse((sender as Label).Tag.ToString());
            switch (index)
            {
                case 0: rb_Op_1.Checked = true;
                    break;
                case 1: rb_Op_2.Checked = true;
                    break;
                case 2: rb_Op_3.Checked = true;
                    break;
                case 3: rb_Op_4.Checked = true;
                    break;
                case 4: rb_Op_5.Checked = true;
                    break;
                default:
                    break;
            }

        }
    }
}
