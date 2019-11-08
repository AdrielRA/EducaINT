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
    public partial class frm_Cadastro_Pergunta : Form
    {
        private Pergunta pergunta;
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
            pergunta = new Pergunta();
            // preencher dados pergunta;
            Data_Controller.Add_Pergunta(pergunta);
            Close();
        }
    }
}
