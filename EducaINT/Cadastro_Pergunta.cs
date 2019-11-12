using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducaINT
{
    public partial class frm_Cadastro_Pergunta : Form
    {
        private Pergunta pergunta = new Pergunta();
        public frm_Cadastro_Pergunta()
        {
            InitializeComponent();
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            pergunta.Id = Data_Controller.Perguntas.Count + 1;
            pergunta.Questao = txt_Questão.Text;
            pergunta.Tema = txt_Tema.Text;
            double pts = 10;
            double.TryParse(txt_Pontos.Text.Replace(",", "."), NumberStyles.Any, new CultureInfo("pt-br"), out pts);
            pergunta.Pontuacao = pts;

            if (cb_Resp_1.Checked) { pergunta.Alternativas.Add(txt_Alternativa_1.Text); }
            if (cb_Resp_2.Checked) { pergunta.Alternativas.Add(txt_Alternativa_2.Text); }
            if (cb_Resp_3.Checked) { pergunta.Alternativas.Add(txt_Alternativa_3.Text); }
            if (cb_Resp_4.Checked) { pergunta.Alternativas.Add(txt_Alternativa_4.Text); }
            if (cb_Resp_5.Checked) { pergunta.Alternativas.Add(txt_Alternativa_5.Text); }

            if (pergunta.Alternativas.Count > 1)
            {
                Data_Controller.Add_Pergunta(pergunta);
                Close();
            }
            else MessageBox.Show("Adiciona pelo menos\nduas alternativas!");
        }

        private void rb_Res_Certa_1_Click(object sender, EventArgs e)
        {
            pergunta.Resposta_Certa = int.Parse((sender as LollipopRadioButton).Tag.ToString()) - 1;
        }
    }
}
