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
    public partial class frm_Autenticar_Professor : Form
    {
        public static bool liberar = false;
        public ClasseProf prof;
        public frm_Autenticar_Professor()
        {
            InitializeComponent();
            liberar = false;
        }

        private void btn_Acessar_Click(object sender, EventArgs e)
        {
            if(txt_UsuárioProf.Text==prof.Usuario && txt_Senha.Text == prof.Senha)
               liberar = true;
            else
              liberar = false;
            Close();
        }

        
    }
}
