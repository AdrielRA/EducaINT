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
    public partial class frm_Tema : Form
    {
        public static bool voltou = false;
        public static List<Pergunta> perguntas_selecionadas = null;
        private List<string> temas = null;
        private string tema_escolhido = "";

        public frm_Tema()
        {
            InitializeComponent();
            Load_Temas();
        }

        private void Load_Temas()
        {
            temas = Data_Controller.Perguntas.GroupBy(p => p.Tema).Select(t => t.Key).ToList();
            foreach(string tema in temas)
            {
                // mostrar e escolher um tema
                tema_escolhido = tema;
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
            perguntas_selecionadas = Data_Controller.Perguntas.Where(p => p.Tema == tema_escolhido).ToList();
            Close();
        }
    }
}
