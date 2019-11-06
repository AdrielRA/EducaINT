namespace EducaINT
{
    partial class frm_Professor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Professor));
            this.elip_PanelPerfil = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elip_Form = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnl_BG = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.pnl_Perfil = new System.Windows.Forms.Panel();
            this.btn_Relatorio = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbl_SubTitulo = new System.Windows.Forms.Label();
            this.lbl_Info = new System.Windows.Forms.Label();
            this.btn_Sair = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Add = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_BG.SuspendLayout();
            this.pnl_Perfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // elip_PanelPerfil
            // 
            this.elip_PanelPerfil.ElipseRadius = 10;
            this.elip_PanelPerfil.TargetControl = this.pnl_Perfil;
            // 
            // elip_Form
            // 
            this.elip_Form.ElipseRadius = 10;
            this.elip_Form.TargetControl = this;
            // 
            // pnl_BG
            // 
            this.pnl_BG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_BG.BackgroundImage")));
            this.pnl_BG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_BG.Controls.Add(this.lbl_Titulo);
            this.pnl_BG.Controls.Add(this.pnl_Perfil);
            this.pnl_BG.Controls.Add(this.pictureBox1);
            this.pnl_BG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_BG.GradientBottomLeft = System.Drawing.Color.DarkTurquoise;
            this.pnl_BG.GradientBottomRight = System.Drawing.Color.MidnightBlue;
            this.pnl_BG.GradientTopLeft = System.Drawing.Color.DarkTurquoise;
            this.pnl_BG.GradientTopRight = System.Drawing.Color.MidnightBlue;
            this.pnl_BG.Location = new System.Drawing.Point(0, 0);
            this.pnl_BG.Name = "pnl_BG";
            this.pnl_BG.Quality = 10;
            this.pnl_BG.Size = new System.Drawing.Size(800, 450);
            this.pnl_BG.TabIndex = 3;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Titulo.AutoEllipsis = true;
            this.lbl_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Titulo.Font = new System.Drawing.Font("Geometr415 Blk BT", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_Titulo.Location = new System.Drawing.Point(272, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(516, 203);
            this.lbl_Titulo.TabIndex = 5;
            this.lbl_Titulo.Text = "EDUCAINT";
            this.lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_Perfil
            // 
            this.pnl_Perfil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnl_Perfil.Controls.Add(this.btn_Relatorio);
            this.pnl_Perfil.Controls.Add(this.lbl_SubTitulo);
            this.pnl_Perfil.Controls.Add(this.lbl_Info);
            this.pnl_Perfil.Controls.Add(this.btn_Sair);
            this.pnl_Perfil.Controls.Add(this.bunifuFlatButton1);
            this.pnl_Perfil.Controls.Add(this.btn_Add);
            this.pnl_Perfil.Location = new System.Drawing.Point(0, 0);
            this.pnl_Perfil.Name = "pnl_Perfil";
            this.pnl_Perfil.Size = new System.Drawing.Size(266, 450);
            this.pnl_Perfil.TabIndex = 0;
            // 
            // btn_Relatorio
            // 
            this.btn_Relatorio.Active = false;
            this.btn_Relatorio.Activecolor = System.Drawing.Color.MidnightBlue;
            this.btn_Relatorio.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Relatorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Relatorio.BorderRadius = 0;
            this.btn_Relatorio.ButtonText = "VER RELATÓRIO";
            this.btn_Relatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Relatorio.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Relatorio.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Relatorio.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Relatorio.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Relatorio.Iconimage")));
            this.btn_Relatorio.Iconimage_right = null;
            this.btn_Relatorio.Iconimage_right_Selected = null;
            this.btn_Relatorio.Iconimage_Selected = null;
            this.btn_Relatorio.IconMarginLeft = 0;
            this.btn_Relatorio.IconMarginRight = 0;
            this.btn_Relatorio.IconRightVisible = false;
            this.btn_Relatorio.IconRightZoom = 0D;
            this.btn_Relatorio.IconVisible = false;
            this.btn_Relatorio.IconZoom = 90D;
            this.btn_Relatorio.IsTab = false;
            this.btn_Relatorio.Location = new System.Drawing.Point(12, 107);
            this.btn_Relatorio.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Relatorio.Name = "btn_Relatorio";
            this.btn_Relatorio.Normalcolor = System.Drawing.Color.MidnightBlue;
            this.btn_Relatorio.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btn_Relatorio.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Relatorio.selected = false;
            this.btn_Relatorio.Size = new System.Drawing.Size(241, 38);
            this.btn_Relatorio.TabIndex = 9;
            this.btn_Relatorio.Text = "VER RELATÓRIO";
            this.btn_Relatorio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Relatorio.Textcolor = System.Drawing.Color.White;
            this.btn_Relatorio.TextFont = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Relatorio.Click += new System.EventHandler(this.btn_Relatorio_Click);
            // 
            // lbl_SubTitulo
            // 
            this.lbl_SubTitulo.AutoEllipsis = true;
            this.lbl_SubTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_SubTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_SubTitulo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubTitulo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_SubTitulo.Location = new System.Drawing.Point(0, 0);
            this.lbl_SubTitulo.Name = "lbl_SubTitulo";
            this.lbl_SubTitulo.Size = new System.Drawing.Size(266, 35);
            this.lbl_SubTitulo.TabIndex = 8;
            this.lbl_SubTitulo.Text = "PROFESSOR";
            this.lbl_SubTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btn_Sair.Location = new System.Drawing.Point(12, 375);
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
            // btn_Add
            // 
            this.btn_Add.Active = false;
            this.btn_Add.Activecolor = System.Drawing.Color.MidnightBlue;
            this.btn_Add.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Add.BorderRadius = 0;
            this.btn_Add.ButtonText = "ADICIONAR PERGUNTAS";
            this.btn_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Add.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Add.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Add.Iconimage")));
            this.btn_Add.Iconimage_right = null;
            this.btn_Add.Iconimage_right_Selected = null;
            this.btn_Add.Iconimage_Selected = null;
            this.btn_Add.IconMarginLeft = 0;
            this.btn_Add.IconMarginRight = 0;
            this.btn_Add.IconRightVisible = false;
            this.btn_Add.IconRightZoom = 0D;
            this.btn_Add.IconVisible = false;
            this.btn_Add.IconZoom = 90D;
            this.btn_Add.IsTab = false;
            this.btn_Add.Location = new System.Drawing.Point(12, 57);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Normalcolor = System.Drawing.Color.MidnightBlue;
            this.btn_Add.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btn_Add.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Add.selected = false;
            this.btn_Add.Size = new System.Drawing.Size(241, 38);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = "ADICIONAR PERGUNTAS";
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Add.Textcolor = System.Drawing.Color.White;
            this.btn_Add.TextFont = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::EducaINT.Properties.Resources.BG_Perfil;
            this.pictureBox1.Location = new System.Drawing.Point(259, 215);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(541, 235);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frm_Professor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_BG);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Professor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Professor";
            this.pnl_BG.ResumeLayout(false);
            this.pnl_Perfil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Info;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Sair;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Add;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Panel pnl_Perfil;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Relatorio;
        private System.Windows.Forms.Label lbl_SubTitulo;
        private Bunifu.Framework.UI.BunifuElipse elip_PanelPerfil;
        private Bunifu.Framework.UI.BunifuElipse elip_Form;
        private Bunifu.Framework.UI.BunifuGradientPanel pnl_BG;
    }
}