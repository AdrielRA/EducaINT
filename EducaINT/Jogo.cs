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
        public frm_Jogo()
        {
            InitializeComponent();
            // escolher pergunta aleatória como achar melhor
            pergunta_em_jogo = frm_Tema.perguntas_selecionadas[new Random().Next(0, frm_Tema.perguntas_selecionadas.Count)];
            Load_Pergunta(pergunta_em_jogo);
        }

        private void Load_Pergunta(Pergunta pergunta)
        {
            // carregar pergunta selecionada
        }

        private void btn_Pause_Click(object sender, EventArgs e)
        {
            // arrumar op de pausar, proxima pergunta e pular...
            Close();
        }
    }
}
