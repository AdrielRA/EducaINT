namespace EducaINT
{
    partial class frm_Perfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Perfil));
            this.elip_Form = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elip_PanelPerfil = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnl_Perfil = new System.Windows.Forms.Panel();
            this.lblNome = new System.Windows.Forms.Label();
            this.pnl_Prog_2 = new System.Windows.Forms.Panel();
            this.prog_Bar_2 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.lbl_Pro_Desc_2 = new System.Windows.Forms.Label();
            this.pnl_Prog_1 = new System.Windows.Forms.Panel();
            this.prog_Bar_1 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.lbl_Pro_Desc_1 = new System.Windows.Forms.Label();
            this.pic_Aluno = new System.Windows.Forms.PictureBox();
            this.lbl_Info = new System.Windows.Forms.Label();
            this.btn_Sair = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Jogar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnl_BG = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.pic_Arte = new System.Windows.Forms.PictureBox();
            this.elip_Foto = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnl_Perfil.SuspendLayout();
            this.pnl_Prog_2.SuspendLayout();
            this.pnl_Prog_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Aluno)).BeginInit();
            this.pnl_BG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Arte)).BeginInit();
            this.SuspendLayout();
            // 
            // elip_Form
            // 
            this.elip_Form.ElipseRadius = 10;
            this.elip_Form.TargetControl = this;
            // 
            // elip_PanelPerfil
            // 
            this.elip_PanelPerfil.ElipseRadius = 10;
            this.elip_PanelPerfil.TargetControl = this.pnl_Perfil;
            // 
            // pnl_Perfil
            // 
            this.pnl_Perfil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnl_Perfil.Controls.Add(this.lblNome);
            this.pnl_Perfil.Controls.Add(this.pnl_Prog_2);
            this.pnl_Perfil.Controls.Add(this.pnl_Prog_1);
            this.pnl_Perfil.Controls.Add(this.pic_Aluno);
            this.pnl_Perfil.Controls.Add(this.lbl_Info);
            this.pnl_Perfil.Controls.Add(this.btn_Sair);
            this.pnl_Perfil.Controls.Add(this.bunifuFlatButton1);
            this.pnl_Perfil.Controls.Add(this.btn_Jogar);
            this.pnl_Perfil.Location = new System.Drawing.Point(0, 0);
            this.pnl_Perfil.Name = "pnl_Perfil";
            this.pnl_Perfil.Size = new System.Drawing.Size(266, 450);
            this.pnl_Perfil.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNome.Location = new System.Drawing.Point(18, 196);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(60, 16);
            this.lblNome.TabIndex = 10;
            this.lblNome.Text = "Nome: ";
            // 
            // pnl_Prog_2
            // 
            this.pnl_Prog_2.Controls.Add(this.prog_Bar_2);
            this.pnl_Prog_2.Controls.Add(this.lbl_Pro_Desc_2);
            this.pnl_Prog_2.Location = new System.Drawing.Point(15, 283);
            this.pnl_Prog_2.Name = "pnl_Prog_2";
            this.pnl_Prog_2.Size = new System.Drawing.Size(240, 55);
            this.pnl_Prog_2.TabIndex = 10;
            // 
            // prog_Bar_2
            // 
            this.prog_Bar_2.BackColor = System.Drawing.Color.Silver;
            this.prog_Bar_2.BorderRadius = 5;
            this.prog_Bar_2.Location = new System.Drawing.Point(6, 31);
            this.prog_Bar_2.MaximumValue = 100;
            this.prog_Bar_2.Name = "prog_Bar_2";
            this.prog_Bar_2.ProgressColor = System.Drawing.Color.MidnightBlue;
            this.prog_Bar_2.Size = new System.Drawing.Size(222, 10);
            this.prog_Bar_2.TabIndex = 10;
            this.prog_Bar_2.Value = 68;
            // 
            // lbl_Pro_Desc_2
            // 
            this.lbl_Pro_Desc_2.AutoSize = true;
            this.lbl_Pro_Desc_2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Pro_Desc_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pro_Desc_2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Pro_Desc_2.Location = new System.Drawing.Point(3, 0);
            this.lbl_Pro_Desc_2.Name = "lbl_Pro_Desc_2";
            this.lbl_Pro_Desc_2.Size = new System.Drawing.Size(168, 16);
            this.lbl_Pro_Desc_2.TabIndex = 9;
            this.lbl_Pro_Desc_2.Text = "Percentual de acertos:";
            // 
            // pnl_Prog_1
            // 
            this.pnl_Prog_1.Controls.Add(this.prog_Bar_1);
            this.pnl_Prog_1.Controls.Add(this.lbl_Pro_Desc_1);
            this.pnl_Prog_1.Location = new System.Drawing.Point(15, 223);
            this.pnl_Prog_1.Name = "pnl_Prog_1";
            this.pnl_Prog_1.Size = new System.Drawing.Size(240, 54);
            this.pnl_Prog_1.TabIndex = 9;
            // 
            // prog_Bar_1
            // 
            this.prog_Bar_1.BackColor = System.Drawing.Color.Silver;
            this.prog_Bar_1.BorderRadius = 5;
            this.prog_Bar_1.Location = new System.Drawing.Point(6, 37);
            this.prog_Bar_1.MaximumValue = 100;
            this.prog_Bar_1.Name = "prog_Bar_1";
            this.prog_Bar_1.ProgressColor = System.Drawing.Color.MidnightBlue;
            this.prog_Bar_1.Size = new System.Drawing.Size(222, 10);
            this.prog_Bar_1.TabIndex = 9;
            this.prog_Bar_1.Value = 25;
            // 
            // lbl_Pro_Desc_1
            // 
            this.lbl_Pro_Desc_1.AutoSize = true;
            this.lbl_Pro_Desc_1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Pro_Desc_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pro_Desc_1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Pro_Desc_1.Location = new System.Drawing.Point(3, 9);
            this.lbl_Pro_Desc_1.Name = "lbl_Pro_Desc_1";
            this.lbl_Pro_Desc_1.Size = new System.Drawing.Size(176, 16);
            this.lbl_Pro_Desc_1.TabIndex = 8;
            this.lbl_Pro_Desc_1.Text = "Perguntas respondidas:";
            // 
            // pic_Aluno
            // 
            this.pic_Aluno.BackColor = System.Drawing.Color.MidnightBlue;
            this.pic_Aluno.Location = new System.Drawing.Point(12, 12);
            this.pic_Aluno.Name = "pic_Aluno";
            this.pic_Aluno.Size = new System.Drawing.Size(241, 175);
            this.pic_Aluno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Aluno.TabIndex = 8;
            this.pic_Aluno.TabStop = false;
            // 
            // lbl_Info
            // 
            this.lbl_Info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Info.AutoEllipsis = true;
            this.lbl_Info.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Info.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Info.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Info.Location = new System.Drawing.Point(12, 424);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(241, 26);
            this.lbl_Info.TabIndex = 7;
            this.lbl_Info.Text = "UNIFENAS - 2019";
            this.lbl_Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Sair
            // 
            this.btn_Sair.Active = false;
            this.btn_Sair.Activecolor = System.Drawing.Color.MidnightBlue;
            this.btn_Sair.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Sair.BorderRadius = 0;
            this.btn_Sair.ButtonText = "SAIR";
            this.btn_Sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sair.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Sair.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Sair.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Sair.Iconimage")));
            this.btn_Sair.Iconimage_right = null;
            this.btn_Sair.Iconimage_right_Selected = null;
            this.btn_Sair.Iconimage_Selected = null;
            this.btn_Sair.IconMarginLeft = 0;
            this.btn_Sair.IconMarginRight = 0;
            this.btn_Sair.IconRightVisible = false;
            this.btn_Sair.IconRightZoom = 0D;
            this.btn_Sair.IconVisible = false;
            this.btn_Sair.IconZoom = 90D;
            this.btn_Sair.IsTab = false;
            this.btn_Sair.Location = new System.Drawing.Point(14, 388);
            this.btn_Sair.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Normalcolor = System.Drawing.Color.MidnightBlue;
            this.btn_Sair.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btn_Sair.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Sair.selected = false;
            this.btn_Sair.Size = new System.Drawing.Size(241, 38);
            this.btn_Sair.TabIndex = 5;
            this.btn_Sair.Text = "SAIR";
            this.btn_Sair.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Sair.Textcolor = System.Drawing.Color.White;
            this.btn_Sair.TextFont = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.MidnightBlue;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.MidnightBlue;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "bunifuFlatButton1";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(232, 579);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.MidnightBlue;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(522, 92);
            this.bunifuFlatButton1.TabIndex = 3;
            this.bunifuFlatButton1.Text = "bunifuFlatButton1";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_Jogar
            // 
            this.btn_Jogar.Active = false;
            this.btn_Jogar.Activecolor = System.Drawing.Color.MidnightBlue;
            this.btn_Jogar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Jogar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Jogar.BorderRadius = 0;
            this.btn_Jogar.ButtonText = "JOGAR";
            this.btn_Jogar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Jogar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Jogar.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Jogar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Jogar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Jogar.Iconimage")));
            this.btn_Jogar.Iconimage_right = null;
            this.btn_Jogar.Iconimage_right_Selected = null;
            this.btn_Jogar.Iconimage_Selected = null;
            this.btn_Jogar.IconMarginLeft = 0;
            this.btn_Jogar.IconMarginRight = 0;
            this.btn_Jogar.IconRightVisible = false;
            this.btn_Jogar.IconRightZoom = 0D;
            this.btn_Jogar.IconVisible = false;
            this.btn_Jogar.IconZoom = 90D;
            this.btn_Jogar.IsTab = false;
            this.btn_Jogar.Location = new System.Drawing.Point(14, 344);
            this.btn_Jogar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Jogar.Name = "btn_Jogar";
            this.btn_Jogar.Normalcolor = System.Drawing.Color.MidnightBlue;
            this.btn_Jogar.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btn_Jogar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Jogar.selected = false;
            this.btn_Jogar.Size = new System.Drawing.Size(241, 38);
            this.btn_Jogar.TabIndex = 4;
            this.btn_Jogar.Text = "JOGAR";
            this.btn_Jogar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Jogar.Textcolor = System.Drawing.Color.White;
            this.btn_Jogar.TextFont = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Jogar.Click += new System.EventHandler(this.btn_Jogar_Click);
            // 
            // pnl_BG
            // 
            this.pnl_BG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_BG.BackgroundImage")));
            this.pnl_BG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_BG.Controls.Add(this.lbl_Titulo);
            this.pnl_BG.Controls.Add(this.pnl_Perfil);
            this.pnl_BG.Controls.Add(this.pic_Arte);
            this.pnl_BG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_BG.GradientBottomLeft = System.Drawing.Color.DarkTurquoise;
            this.pnl_BG.GradientBottomRight = System.Drawing.Color.MidnightBlue;
            this.pnl_BG.GradientTopLeft = System.Drawing.Color.DarkTurquoise;
            this.pnl_BG.GradientTopRight = System.Drawing.Color.MidnightBlue;
            this.pnl_BG.Location = new System.Drawing.Point(0, 0);
            this.pnl_BG.Name = "pnl_BG";
            this.pnl_BG.Quality = 10;
            this.pnl_BG.Size = new System.Drawing.Size(800, 450);
            this.pnl_BG.TabIndex = 2;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Titulo.AutoEllipsis = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Titulo.Font = new System.Drawing.Font("Geometr415 Blk BT", 60F);
            this.lbl_Titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_Titulo.Location = new System.Drawing.Point(272, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(516, 203);
            this.lbl_Titulo.TabIndex = 5;
            this.lbl_Titulo.Text = "EDUCAINT";
            this.lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_Arte
            // 
            this.pic_Arte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_Arte.BackColor = System.Drawing.Color.Transparent;
            this.pic_Arte.Image = global::EducaINT.Properties.Resources.BG_Perfil;
            this.pic_Arte.Location = new System.Drawing.Point(259, 215);
            this.pic_Arte.Name = "pic_Arte";
            this.pic_Arte.Size = new System.Drawing.Size(541, 235);
            this.pic_Arte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_Arte.TabIndex = 6;
            this.pic_Arte.TabStop = false;
            // 
            // elip_Foto
            // 
            this.elip_Foto.ElipseRadius = 30;
            this.elip_Foto.TargetControl = this.pic_Aluno;
            // 
            // frm_Perfil
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_BG);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Perfil";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form3";
            this.pnl_Perfil.ResumeLayout(false);
            this.pnl_Perfil.PerformLayout();
            this.pnl_Prog_2.ResumeLayout(false);
            this.pnl_Prog_2.PerformLayout();
            this.pnl_Prog_1.ResumeLayout(false);
            this.pnl_Prog_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Aluno)).EndInit();
            this.pnl_BG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Arte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pnl_BG;
        private System.Windows.Forms.Label lbl_Titulo;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Jogar;
        private System.Windows.Forms.Panel pnl_Perfil;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Label lbl_Info;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Sair;
        private System.Windows.Forms.PictureBox pic_Arte;
        private Bunifu.Framework.UI.BunifuElipse elip_Form;
        private Bunifu.Framework.UI.BunifuElipse elip_PanelPerfil;
        private System.Windows.Forms.Panel pnl_Prog_2;
        private Bunifu.Framework.UI.BunifuProgressBar prog_Bar_2;
        private System.Windows.Forms.Label lbl_Pro_Desc_2;
        private System.Windows.Forms.Panel pnl_Prog_1;
        private Bunifu.Framework.UI.BunifuProgressBar prog_Bar_1;
        private System.Windows.Forms.Label lbl_Pro_Desc_1;
        private System.Windows.Forms.PictureBox pic_Aluno;
        private Bunifu.Framework.UI.BunifuElipse elip_Foto;
        private System.Windows.Forms.Label lblNome;
    }
}