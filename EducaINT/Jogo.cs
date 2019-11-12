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
        private int pulo = 3;

        public frm_Jogo()
        {
            InitializeComponent();
            timer1.Enabled = true;
            // escolher pergunta aleatória como achar melhor
            //pergunta_em_jogo = frm_Tema.perguntas_selecionadas[new Random().Next(0, frm_Tema.perguntas_selecionadas.Count)];
            pergunta_em_jogo = new Pergunta();
            pergunta_em_jogo.Alternativas.Add("Alternativa 1");
            pergunta_em_jogo.Alternativas.Add("Alternativa 2");
            pergunta_em_jogo.Alternativas.Add("Alternativa 3");
            pergunta_em_jogo.Alternativas.Add("Alternativa 4");
            pergunta_em_jogo.Alternativas.Add("Alternativa 5");
            pergunta_em_jogo.Resposta_Certa = 1;
            pergunta_em_jogo.Questao = "Questao x";
            Load_Pergunta(pergunta_em_jogo);
        }

        private void Load_Pergunta(Pergunta pergunta)
        {
            // carregar pergunta selecionada
            Tempo = TimeSpan.FromSeconds(0);
            lbl_Pergunta.Text = pergunta_em_jogo.Questao;
            if(pergunta.Alternativas.Count>0)
            {
                lbl_Alternativa_1.Text = pergunta.Alternativas[1];
                if(pergunta.Alternativas.Count>1)
                {
                    lbl_Alternativa_2.Text = pergunta.Alternativas[2];
                }
                else
                {
                    lbl_Alternativa_2.Visible = false;
                    rb_Op_2.Visible = false;
                    lbl_Alternativa_3.Visible = false;
                    rb_Op_3.Visible = false;
                    lbl_Alternativa_4.Visible = false;
                    rb_Op_4.Visible = false;
                    lbl_Alternativa_5.Visible = false;
                    rb_Op_5.Visible = false;                    
                }
                if(pergunta.Alternativas.Count>2)
                {
                    lbl_Alternativa_2.Text = pergunta.Alternativas[2];
                    lbl_Alternativa_3.Text = pergunta.Alternativas[3];
                }
                else
                {
                    lbl_Alternativa_3.Visible = false;
                    rb_Op_3.Visible = false;
                    lbl_Alternativa_4.Visible = false;
                    rb_Op_4.Visible = false;
                    lbl_Alternativa_5.Visible = false;
                    rb_Op_5.Visible = false;
                }
                if(pergunta.Alternativas.Count>3)
                {
                    lbl_Alternativa_2.Text = pergunta.Alternativas[2];
                    lbl_Alternativa_3.Text = pergunta.Alternativas[3];
                    lbl_Alternativa_4.Text = pergunta.Alternativas[4];
                }
                else
                {
                    lbl_Alternativa_4.Visible = false;
                    rb_Op_4.Visible = false;
                    lbl_Alternativa_5.Visible = false;
                    rb_Op_5.Visible = false;
                }
                if(pergunta.Alternativas.Count>4)
                {
                    lbl_Alternativa_2.Text = pergunta.Alternativas[2];
                    lbl_Alternativa_3.Text = pergunta.Alternativas[3];
                    lbl_Alternativa_4.Text = pergunta.Alternativas[4];                    
                }
                else
                {
                    lbl_Alternativa_5.Visible = false;
                    rb_Op_5.Visible = false;
                }
            }
            
        }

        private void btn_Pause_Click(object sender, EventArgs e)
        {
            //arrumar a opção de pausar
            Close();
        }

        private void Rb_Op_1_CheckedChanged(object sender, EventArgs e)
        {
            LollipopRadioButton rb = sender as LollipopRadioButton;
            var result = MessageBox.Show("Você tem certeza ?", "Responda!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (rb.Tag != null && rb.Tag.ToString() == pergunta_em_jogo.Resposta_Certa.ToString())
                {
                    MessageBox.Show("Parabéns, você acertou !!");
                    //A.Pontuacao=rand.Next(1, 50);                    
                    pergunta_em_jogo = frm_Tema.perguntas_selecionadas[new Random().Next(0, frm_Tema.perguntas_selecionadas.Count)];
                    Load_Pergunta(pergunta_em_jogo);
                    Tempo = TimeSpan.FromSeconds(0);
                }
                else
                {
                    MessageBox.Show("Resposta errada, não desista !");
                    pergunta_em_jogo = frm_Tema.perguntas_selecionadas[new Random().Next(0, frm_Tema.perguntas_selecionadas.Count)];
                    Load_Pergunta(pergunta_em_jogo);
                    Tempo = TimeSpan.FromSeconds(0);
                }
            }
        }

        private void Rb_Op_2_CheckedChanged(object sender, EventArgs e)
        {
            LollipopRadioButton rb = sender as LollipopRadioButton;
            var result = MessageBox.Show("Você tem certeza ?", "Responda!", MessageBoxButtons.YesNo);
            if (result==DialogResult.Yes)
            {
                if (rb.Tag != null && rb.Tag.ToString() == pergunta_em_jogo.Resposta_Certa.ToString())
                {
                    MessageBox.Show("Parabéns, você acertou !!");
                    //A.Pontuacao=rand.Next(1, 50);                    
                    pergunta_em_jogo = frm_Tema.perguntas_selecionadas[new Random().Next(0, frm_Tema.perguntas_selecionadas.Count)];
                    Load_Pergunta(pergunta_em_jogo);
                    Tempo = TimeSpan.FromSeconds(0);
                }
                else
                {
                    MessageBox.Show("Resposta errada, não desista !");
                    pergunta_em_jogo = frm_Tema.perguntas_selecionadas[new Random().Next(0, frm_Tema.perguntas_selecionadas.Count)];
                    Load_Pergunta(pergunta_em_jogo);
                    Tempo = TimeSpan.FromSeconds(0);
                }
            }
           
        }

        private void Rb_Op_3_CheckedChanged(object sender, EventArgs e)
        {
            LollipopRadioButton rb = sender as LollipopRadioButton;
            var result = MessageBox.Show("Você tem certeza ?", "Responda!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (rb.Tag != null && rb.Tag.ToString() == pergunta_em_jogo.Resposta_Certa.ToString())
                {
                    MessageBox.Show("Parabéns, você acertou !!");
                    //A.Pontuacao=rand.Next(1, 50);                    
                    pergunta_em_jogo = frm_Tema.perguntas_selecionadas[new Random().Next(0, frm_Tema.perguntas_selecionadas.Count)];
                    Load_Pergunta(pergunta_em_jogo);
                    Tempo = TimeSpan.FromSeconds(0);
                }
                else
                {
                    MessageBox.Show("Resposta errada, não desista !");
                    pergunta_em_jogo = frm_Tema.perguntas_selecionadas[new Random().Next(0, frm_Tema.perguntas_selecionadas.Count)];
                    Load_Pergunta(pergunta_em_jogo);
                    Tempo = TimeSpan.FromSeconds(0);
                }
            }

        }

        private void Rb_Op_4_CheckedChanged(object sender, EventArgs e)
        {
            LollipopRadioButton rb = sender as LollipopRadioButton;
            var result = MessageBox.Show("Você tem certeza ?", "Responda!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (rb.Tag != null && rb.Tag.ToString() == pergunta_em_jogo.Resposta_Certa.ToString())
                {
                    MessageBox.Show("Parabéns, você acertou !!");
                    //A.Pontuacao=rand.Next(1, 50);                    
                    pergunta_em_jogo = frm_Tema.perguntas_selecionadas[new Random().Next(0, frm_Tema.perguntas_selecionadas.Count)];
                    Load_Pergunta(pergunta_em_jogo);
                    Tempo = TimeSpan.FromSeconds(0);
                }
                else
                {
                    MessageBox.Show("Resposta errada, não desista !");
                    pergunta_em_jogo = frm_Tema.perguntas_selecionadas[new Random().Next(0, frm_Tema.perguntas_selecionadas.Count)];
                    Load_Pergunta(pergunta_em_jogo);
                    Tempo = TimeSpan.FromSeconds(0);
                }
            }
        }

        private void Rb_Op_5_CheckedChanged(object sender, EventArgs e)
        {
            LollipopRadioButton rb = sender as LollipopRadioButton;
            var result = MessageBox.Show("Você tem certeza ?","Responda!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (rb.Tag != null && rb.Tag.ToString() == pergunta_em_jogo.Resposta_Certa.ToString())
                {
                    MessageBox.Show("Parabéns, você acertou !!");
                    //A.Pontuacao=rand.Next(1, 50);                    
                    pergunta_em_jogo = frm_Tema.perguntas_selecionadas[new Random().Next(0, frm_Tema.perguntas_selecionadas.Count)];
                    Load_Pergunta(pergunta_em_jogo);
                    Tempo = TimeSpan.FromSeconds(0);
                }
                else
                {
                    MessageBox.Show("Resposta errada, não desista !");
                    pergunta_em_jogo = frm_Tema.perguntas_selecionadas[new Random().Next(0, frm_Tema.perguntas_selecionadas.Count)];
                    Load_Pergunta(pergunta_em_jogo);
                    Tempo = TimeSpan.FromSeconds(0);
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
                limite_pulo--;
                pulo--;
                lbl_Pulos.Text = pulo.ToString();
            }           
            else
            {
                var Result2 = MessageBox.Show("Prefere tentar depois ?"," Não desista!",MessageBoxButtons.YesNo);
                if (Result2 == DialogResult.Yes)
                {
                    Close();
                }
                else
                    Close();
                               
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbl_Tempo.Text = Tempo.ToString();
            Tempo += TimeSpan.FromSeconds(1);
        }
    }
}
