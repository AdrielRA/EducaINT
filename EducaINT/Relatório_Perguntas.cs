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
    public partial class frm_Relatório_Perguntas : Form
    {
        public frm_Relatório_Perguntas()
        {
            InitializeComponent();
        }

        private void frm_Relatório_Perguntas_Load(object sender, EventArgs e)
        {
            repv_Perguntas.LocalReport.ReportEmbeddedResource = "EducaINT.rep_Perguntas_Registradas.rdlc";
            repv_Perguntas.LocalReport.DataSources.Clear();
            repv_Perguntas.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", Data_Controller.Perguntas));
            this.repv_Perguntas.RefreshReport();
        }
    }
}
