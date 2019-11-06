namespace EducaINT
{
    partial class frm_Escolher_Avatar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Escolher_Avatar));
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnl_Avatares = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnl_BG = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btn_Avançar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnl_BG.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this.pnl_Avatares;
            // 
            // pnl_Avatares
            // 
            this.pnl_Avatares.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Avatares.Location = new System.Drawing.Point(12, 55);
            this.pnl_Avatares.Name = "pnl_Avatares";
            this.pnl_Avatares.Size = new System.Drawing.Size(776, 331);
            this.pnl_Avatares.TabIndex = 0;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnl_BG
            // 
            this.pnl_BG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_BG.BackgroundImage")));
            this.pnl_BG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_BG.Controls.Add(this.lbl_Titulo);
            this.pnl_BG.Controls.Add(this.btn_Avançar);
            this.pnl_BG.Controls.Add(this.pnl_Avatares);
            this.pnl_BG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_BG.GradientBottomLeft = System.Drawing.Color.DarkTurquoise;
            this.pnl_BG.GradientBottomRight = System.Drawing.Color.MidnightBlue;
            this.pnl_BG.GradientTopLeft = System.Drawing.Color.DarkTurquoise;
            this.pnl_BG.GradientTopRight = System.Drawing.Color.MidnightBlue;
            this.pnl_BG.Location = new System.Drawing.Point(0, 0);
            this.pnl_BG.Name = "pnl_BG";
            this.pnl_BG.Quality = 10;
            this.pnl_BG.Size = new System.Drawing.Size(800, 450);
            this.pnl_BG.TabIndex = 1;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Titulo.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_Titulo.Location = new System.Drawing.Point(13, 13);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(339, 39);
            this.lbl_Titulo.TabIndex = 5;
            this.lbl_Titulo.Text = "SELECIONE SEU AVATAR:";
            // 
            // btn_Avançar
            // 
            this.btn_Avançar.Active = false;
            this.btn_Avançar.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.btn_Avançar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Avançar.BackColor = System.Drawing.Color.White;
            this.btn_Avançar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Avançar.BorderRadius = 0;
            this.btn_Avançar.ButtonText = "Avançar";
            this.btn_Avançar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Avançar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Avançar.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Avançar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Avançar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Avançar.Iconimage")));
            this.btn_Avançar.Iconimage_right = null;
            this.btn_Avançar.Iconimage_right_Selected = null;
            this.btn_Avançar.Iconimage_Selected = null;
            this.btn_Avançar.IconMarginLeft = 0;
            this.btn_Avançar.IconMarginRight = 0;
            this.btn_Avançar.IconRightVisible = false;
            this.btn_Avançar.IconRightZoom = 0D;
            this.btn_Avançar.IconVisible = false;
            this.btn_Avançar.IconZoom = 90D;
            this.btn_Avançar.IsTab = false;
            this.btn_Avançar.Location = new System.Drawing.Point(590, 393);
            this.btn_Avançar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Avançar.Name = "btn_Avançar";
            this.btn_Avançar.Normalcolor = System.Drawing.Color.White;
            this.btn_Avançar.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.btn_Avançar.OnHoverTextColor = System.Drawing.Color.MidnightBlue;
            this.btn_Avançar.selected = false;
            this.btn_Avançar.Size = new System.Drawing.Size(197, 44);
            this.btn_Avançar.TabIndex = 4;
            this.btn_Avançar.Text = "Avançar";
            this.btn_Avançar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Avançar.Textcolor = System.Drawing.Color.MidnightBlue;
            this.btn_Avançar.TextFont = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            this.btn_Avançar.Click += new System.EventHandler(this.btn_Avançar_Click);
            // 
            // frm_Escolher_Avatar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_BG);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Escolher_Avatar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.pnl_BG.ResumeLayout(false);
            this.pnl_BG.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Panel pnl_Avatares;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Avançar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel pnl_BG;
        private System.Windows.Forms.Label lbl_Titulo;
    }
}