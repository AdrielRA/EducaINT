﻿using System;
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

        public frm_Tema()
        {
            InitializeComponent();
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            voltou = true;
            Close();
        }

        private void btn_Avançar_Click(object sender, EventArgs e)
        {
            voltou = false;
            Close();
        }
    }
}