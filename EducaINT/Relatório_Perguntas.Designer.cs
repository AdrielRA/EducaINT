namespace EducaINT
{
    partial class frm_Relatório_Perguntas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.repv_Perguntas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // repv_Perguntas
            // 
            this.repv_Perguntas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.repv_Perguntas.Location = new System.Drawing.Point(0, 0);
            this.repv_Perguntas.Name = "repv_Perguntas";
            this.repv_Perguntas.ServerReport.BearerToken = null;
            this.repv_Perguntas.Size = new System.Drawing.Size(484, 361);
            this.repv_Perguntas.TabIndex = 0;
            // 
            // frm_Relatório_Perguntas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.repv_Perguntas);
            this.Font = new System.Drawing.Font("Calibri", 9F);
            this.MinimizeBox = false;
            this.Name = "frm_Relatório_Perguntas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Relatório Perguntas";
            this.Load += new System.EventHandler(this.frm_Relatório_Perguntas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer repv_Perguntas;
    }
}