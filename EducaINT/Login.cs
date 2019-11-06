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
        public frm_Login()
        {
            InitializeComponent();
            lbl_Titulo.Parent = pic_Banner;
        }

        private void btn_Fechar_Click(object sender, EventArgs e) { Application.Exit(); }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            new frm_Escolher_Avatar().ShowDialog();
            new frm_Perfil().ShowDialog();
        }

        private void btn_Professor_Click(object sender, EventArgs e)
        {
            new frm_Autenticar_Professor().ShowDialog();
            if(frm_Autenticar_Professor.liberar) new frm_Professor().ShowDialog();
        }
    }
}
