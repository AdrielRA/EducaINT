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
    public partial class frm_Relatório_Alunos : Form
    {
        public frm_Relatório_Alunos()
        {
            InitializeComponent();
        }

        private void frm_Relatório_Alunos_Load(object sender, EventArgs e)
        {
            List<Data_Aluno> data_Alunos = new List<Data_Aluno>();

            foreach (Aluno a in Data_Controller.Alunos)
            {
                data_Alunos.Add(new Data_Aluno() { Nome = a.Nome, Qnt_Respostas = a.Respostas.Count, Qnt_Acertos = a.Respostas.Where(r => r.acertou).Count() });
            }

            repv_Alunos.LocalReport.ReportEmbeddedResource = "EducaINT.rep_Alunos.rdlc";
            repv_Alunos.LocalReport.DataSources.Clear();
            repv_Alunos.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", data_Alunos));
            this.repv_Alunos.RefreshReport();
        }
    }
}
