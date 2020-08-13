namespace EducaINT
{
    partial class frm_Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.elip_Form = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elip_Login = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnl_Login = new System.Windows.Forms.Panel();
            this.pnl_Formulario = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Professor = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LOGIN = new System.Windows.Forms.Label();
            this.btn_Entrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_Senha = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_NomeUsuario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pic_Banner = new System.Windows.Forms.PictureBox();
            this.elip_Banner = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnl_BG = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_Fechar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.drag_Form = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btn_Info = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnl_Login.SuspendLayout();
            this.pnl_Formulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Banner)).BeginInit();
            this.pnl_BG.SuspendLayout();
            this.SuspendLayout();
            // 
            // elip_Form
            // 
            this.elip_Form.ElipseRadius = 10;
            this.elip_Form.TargetControl = this;
            // 
            // elip_Login
            // 
            this.elip_Login.ElipseRadius = 10;
            this.elip_Login.TargetControl = this.pnl_Login;
            // 
            // pnl_Login
            // 
            this.pnl_Login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Login.Controls.Add(this.pnl_Formulario);
            this.pnl_Login.Controls.Add(this.lbl_Titulo);
            this.pnl_Login.Controls.Add(this.bunifuFlatButton1);
            this.pnl_Login.Controls.Add(this.pic_Banner);
            this.pnl_Login.Location = new System.Drawing.Point(185, 30);
            this.pnl_Login.Name = "pnl_Login";
            this.pnl_Login.Size = new System.Drawing.Size(430, 391);
            this.pnl_Login.TabIndex = 0;
            // 
            // pnl_Formulario
            // 
            this.pnl_Formulario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Formulario.Controls.Add(this.btn_Info);
            this.pnl_Formulario.Controls.Add(this.label1);
            this.pnl_Formulario.Controls.Add(this.btn_Professor);
            this.pnl_Formulario.Controls.Add(this.LOGIN);
            this.pnl_Formulario.Controls.Add(this.btn_Entrar);
            this.pnl_Formulario.Controls.Add(this.bunifuFlatButton3);
            this.pnl_Formulario.Controls.Add(this.txt_Senha);
            this.pnl_Formulario.Controls.Add(this.txt_NomeUsuario);
            this.pnl_Formulario.Location = new System.Drawing.Point(13, 84);
            this.pnl_Formulario.Name = "pnl_Formulario";
            this.pnl_Formulario.Size = new System.Drawing.Size(405, 293);
            this.pnl_Formulario.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "UNIFENAS - 2019";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Professor
            // 
            this.btn_Professor.Active = false;
            this.btn_Professor.Activecolor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Professor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Professor.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Professor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Professor.BorderRadius = 0;
            this.btn_Professor.ButtonText = "PAINEL DO PROFESSOR";
            this.btn_Professor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Professor.DisabledColor = System.Drawing.SystemColors.Control;
            this.btn_Professor.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold);
            this.btn_Professor.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Professor.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Professor.Iconimage")));
            this.btn_Professor.Iconimage_right = null;
            this.btn_Professor.Iconimage_right_Selected = null;
            this.btn_Professor.Iconimage_Selected = null;
            this.btn_Professor.IconMarginLeft = 0;
            this.btn_Professor.IconMarginRight = 0;
            this.btn_Professor.IconRightVisible = false;
            this.btn_Professor.IconRightZoom = 0D;
            this.btn_Professor.IconVisible = false;
            this.btn_Professor.IconZoom = 90D;
            this.btn_Professor.IsTab = false;
            this.btn_Professor.Location = new System.Drawing.Point(11, 184);
            this.btn_Professor.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Professor.Name = "btn_Professor";
            this.btn_Professor.Normalcolor = System.Drawing.SystemColors.ControlDark;
            this.btn_Professor.OnHovercolor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Professor.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Professor.selected = false;
            this.btn_Professor.Size = new System.Drawing.Size(383, 39);
            this.btn_Professor.TabIndex = 6;
            this.btn_Professor.Text = "PAINEL DO PROFESSOR";
            this.btn_Professor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Professor.Textcolor = System.Drawing.Color.White;
            this.btn_Professor.TextFont = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Professor.Click += new System.EventHandler(this.btn_Professor_Click);
            // 
            // LOGIN
            // 
            this.LOGIN.Dock = System.Windows.Forms.DockStyle.Top;
            this.LOGIN.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN.Location = new System.Drawing.Point(0, 0);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(405, 40);
            this.LOGIN.TabIndex = 5;
            this.LOGIN.Text = "LOGIN";
            this.LOGIN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Entrar
            // 
            this.btn_Entrar.Active = false;
            this.btn_Entrar.Activecolor = System.Drawing.Color.MidnightBlue;
            this.btn_Entrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Entrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(43)))), ((int)(((byte)(122)))));
            this.btn_Entrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Entrar.BorderRadius = 0;
            this.btn_Entrar.ButtonText = "ENTRAR";
            this.btn_Entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Entrar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Entrar.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold);
            this.btn_Entrar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Entrar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Entrar.Iconimage")));
            this.btn_Entrar.Iconimage_right = null;
            this.btn_Entrar.Iconimage_right_Selected = null;
            this.btn_Entrar.Iconimage_Selected = null;
            this.btn_Entrar.IconMarginLeft = 0;
            this.btn_Entrar.IconMarginRight = 0;
            this.btn_Entrar.IconRightVisible = false;
            this.btn_Entrar.IconRightZoom = 0D;
            this.btn_Entrar.IconVisible = false;
            this.btn_Entrar.IconZoom = 90D;
            this.btn_Entrar.IsTab = false;
            this.btn_Entrar.Location = new System.Drawing.Point(11, 137);
            this.btn_Entrar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Entrar.Name = "btn_Entrar";
            this.btn_Entrar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(43)))), ((int)(((byte)(122)))));
            this.btn_Entrar.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btn_Entrar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Entrar.selected = false;
            this.btn_Entrar.Size = new System.Drawing.Size(383, 39);
            this.btn_Entrar.TabIndex = 4;
            this.btn_Entrar.Text = "ENTRAR";
            this.btn_Entrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Entrar.Textcolor = System.Drawing.Color.White;
            this.btn_Entrar.TextFont = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Entrar.Click += new System.EventHandler(this.btn_Entrar_Click);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Active = false;
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.MidnightBlue;
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.MidnightBlue;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "bunifuFlatButton3";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(206, 600);
            this.bunifuFlatButton3.Margin = new System.Windows.Forms.Padding(9);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.MidnightBlue;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(720, 134);
            this.bunifuFlatButton3.TabIndex = 3;
            this.bunifuFlatButton3.Text = "bunifuFlatButton3";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txt_Senha
            // 
            this.txt_Senha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Senha.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_Senha.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_Senha.BackColor = System.Drawing.Color.White;
            this.txt_Senha.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Senha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_Senha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(43)))), ((int)(((byte)(122)))));
            this.txt_Senha.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Senha.HintText = "Senha";
            this.txt_Senha.isPassword = true;
            this.txt_Senha.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.txt_Senha.LineIdleColor = System.Drawing.Color.RoyalBlue;
            this.txt_Senha.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(43)))), ((int)(((byte)(122)))));
            this.txt_Senha.LineThickness = 3;
            this.txt_Senha.Location = new System.Drawing.Point(11, 96);
            this.txt_Senha.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Senha.MaxLength = 32767;
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(383, 33);
            this.txt_Senha.TabIndex = 2;
            this.txt_Senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_NomeUsuario
            // 
            this.txt_NomeUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_NomeUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_NomeUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_NomeUsuario.BackColor = System.Drawing.Color.White;
            this.txt_NomeUsuario.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_NomeUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_NomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txt_NomeUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(43)))), ((int)(((byte)(122)))));
            this.txt_NomeUsuario.HintForeColor = System.Drawing.Color.Empty;
            this.txt_NomeUsuario.HintText = "Nome de Usuário";
            this.txt_NomeUsuario.isPassword = false;
            this.txt_NomeUsuario.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.txt_NomeUsuario.LineIdleColor = System.Drawing.Color.RoyalBlue;
            this.txt_NomeUsuario.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(43)))), ((int)(((byte)(122)))));
            this.txt_NomeUsuario.LineThickness = 3;
            this.txt_NomeUsuario.Location = new System.Drawing.Point(11, 53);
            this.txt_NomeUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NomeUsuario.MaxLength = 32767;
            this.txt_NomeUsuario.Name = "txt_NomeUsuario";
            this.txt_NomeUsuario.Size = new System.Drawing.Size(383, 33);
            this.txt_NomeUsuario.TabIndex = 1;
            this.txt_NomeUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(43)))), ((int)(((byte)(122)))));
            this.lbl_Titulo.Location = new System.Drawing.Point(0, 0);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(430, 84);
            this.lbl_Titulo.TabIndex = 6;
            this.lbl_Titulo.Text = "EDUCAINT";
            this.lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(214, 579);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.MidnightBlue;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(540, 92);
            this.bunifuFlatButton1.TabIndex = 3;
            this.bunifuFlatButton1.Text = "bunifuFlatButton1";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pic_Banner
            // 
            this.pic_Banner.Image = global::EducaINT.Properties.Resources.Banner_Login;
            this.pic_Banner.Location = new System.Drawing.Point(0, 0);
            this.pic_Banner.Name = "pic_Banner";
            this.pic_Banner.Size = new System.Drawing.Size(430, 115);
            this.pic_Banner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_Banner.TabIndex = 0;
            this.pic_Banner.TabStop = false;
            // 
            // elip_Banner
            // 
            this.elip_Banner.ElipseRadius = 10;
            this.elip_Banner.TargetControl = this.pic_Banner;
            // 
            // pnl_BG
            // 
            this.pnl_BG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_BG.BackgroundImage")));
            this.pnl_BG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_BG.Controls.Add(this.btn_Fechar);
            this.pnl_BG.Controls.Add(this.pnl_Login);
            this.pnl_BG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_BG.GradientBottomLeft = System.Drawing.Color.DarkTurquoise;
            this.pnl_BG.GradientBottomRight = System.Drawing.Color.MidnightBlue;
            this.pnl_BG.GradientTopLeft = System.Drawing.Color.DarkTurquoise;
            this.pnl_BG.GradientTopRight = System.Drawing.Color.MidnightBlue;
            this.pnl_BG.Location = new System.Drawing.Point(0, 0);
            this.pnl_BG.Name = "pnl_BG";
            this.pnl_BG.Quality = 10;
            this.pnl_BG.Size = new System.Drawing.Size(800, 450);
            this.pnl_BG.TabIndex = 0;
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Active = false;
            this.btn_Fechar.Activecolor = System.Drawing.Color.MidnightBlue;
            this.btn_Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Fechar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(43)))), ((int)(((byte)(122)))));
            this.btn_Fechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Fechar.BorderRadius = 0;
            this.btn_Fechar.ButtonText = "X";
            this.btn_Fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Fechar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Fechar.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold);
            this.btn_Fechar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Fechar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Fechar.Iconimage")));
            this.btn_Fechar.Iconimage_right = null;
            this.btn_Fechar.Iconimage_right_Selected = null;
            this.btn_Fechar.Iconimage_Selected = null;
            this.btn_Fechar.IconMarginLeft = 0;
            this.btn_Fechar.IconMarginRight = 0;
            this.btn_Fechar.IconRightVisible = false;
            this.btn_Fechar.IconRightZoom = 0D;
            this.btn_Fechar.IconVisible = false;
            this.btn_Fechar.IconZoom = 90D;
            this.btn_Fechar.IsTab = false;
            this.btn_Fechar.Location = new System.Drawing.Point(756, -1);
            this.btn_Fechar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(43)))), ((int)(((byte)(122)))));
            this.btn_Fechar.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btn_Fechar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Fechar.selected = false;
            this.btn_Fechar.Size = new System.Drawing.Size(45, 38);
            this.btn_Fechar.TabIndex = 5;
            this.btn_Fechar.Text = "X";
            this.btn_Fechar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Fechar.Textcolor = System.Drawing.Color.White;
            this.btn_Fechar.TextFont = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // drag_Form
            // 
            this.drag_Form.Fixed = true;
            this.drag_Form.Horizontal = true;
            this.drag_Form.TargetControl = this.pnl_BG;
            this.drag_Form.Vertical = true;
            // 
            // btn_Info
            // 
            this.btn_Info.Active = false;
            this.btn_Info.Activecolor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Info.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_Info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Info.BorderRadius = 0;
            this.btn_Info.ButtonText = "?";
            this.btn_Info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Info.DisabledColor = System.Drawing.SystemColors.Control;
            this.btn_Info.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold);
            this.btn_Info.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Info.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Info.Iconimage")));
            this.btn_Info.Iconimage_right = null;
            this.btn_Info.Iconimage_right_Selected = null;
            this.btn_Info.Iconimage_Selected = null;
            this.btn_Info.IconMarginLeft = 0;
            this.btn_Info.IconMarginRight = 0;
            this.btn_Info.IconRightVisible = false;
            this.btn_Info.IconRightZoom = 0D;
            this.btn_Info.IconVisible = false;
            this.btn_Info.IconZoom = 90D;
            this.btn_Info.IsTab = false;
            this.btn_Info.Location = new System.Drawing.Point(355, 254);
            this.btn_Info.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Info.Name = "btn_Info";
            this.btn_Info.Normalcolor = System.Drawing.SystemColors.ControlDark;
            this.btn_Info.OnHovercolor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Info.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Info.selected = false;
            this.btn_Info.Size = new System.Drawing.Size(39, 39);
            this.btn_Info.TabIndex = 8;
            this.btn_Info.Text = "?";
            this.btn_Info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Info.Textcolor = System.Drawing.Color.White;
            this.btn_Info.TextFont = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Info.Click += new System.EventHandler(this.btn_Info_Click);
            // 
            // frm_Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_BG);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(43)))), ((int)(((byte)(122)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EducaINT - Login";
            this.pnl_Login.ResumeLayout(false);
            this.pnl_Formulario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Banner)).EndInit();
            this.pnl_BG.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pnl_BG;
        private System.Windows.Forms.Panel pnl_Login;
        private System.Windows.Forms.PictureBox pic_Banner;
        private Bunifu.Framework.UI.BunifuElipse elip_Form;
        private Bunifu.Framework.UI.BunifuElipse elip_Login;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuElipse elip_Banner;
        private System.Windows.Forms.Panel pnl_Formulario;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Professor;
        private System.Windows.Forms.Label LOGIN;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Entrar;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Senha;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_NomeUsuario;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Fechar;
        private Bunifu.Framework.UI.BunifuDragControl drag_Form;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Info;
    }
}

