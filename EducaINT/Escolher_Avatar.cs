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
    public partial class frm_Escolher_Avatar : Form
    {
        public frm_Escolher_Avatar()
        {
            InitializeComponent();
        }

        private void btn_Avançar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
