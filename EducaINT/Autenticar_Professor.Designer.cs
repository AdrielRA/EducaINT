namespace EducaINT
{
    partial class frm_Autenticar_Professor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Autenticar_Professor));
            this.btn_Acessar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_Senha = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_UsuárioProf = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SuspendLayout();
            // 
            // btn_Acessar
            // 
            this.btn_Acessar.Active = false;
            this.btn_Acessar.Activecolor = System.Drawing.Color.MidnightBlue;
            this.btn_Acessar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Acessar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(43)))), ((int)(((byte)(122)))));
            this.btn_Acessar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Acessar.BorderRadius = 0;
            this.btn_Acessar.ButtonText = "ACESSAR";
            this.btn_Acessar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Acessar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Acessar.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold);
            this.btn_Acessar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Acessar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Acessar.Iconimage")));
            this.btn_Acessar.Iconimage_right = null;
            this.btn_Acessar.Iconimage_right_Selected = null;
            this.btn_Acessar.Iconimage_Selected = null;
            this.btn_Acessar.IconMarginLeft = 0;
            this.btn_Acessar.IconMarginRight = 0;
            this.btn_Acessar.IconRightVisible = false;
            this.btn_Acessar.IconRightZoom = 0D;
            this.btn_Acessar.IconVisible = false;
            this.btn_Acessar.IconZoom = 90D;
            this.btn_Acessar.IsTab = false;
            this.btn_Acessar.Location = new System.Drawing.Point(13, 97);
            this.btn_Acessar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Acessar.Name = "btn_Acessar";
            this.btn_Acessar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(43)))), ((int)(((byte)(122)))));
            this.btn_Acessar.OnHovercolor = System.Drawing.Color.MidnightBlue;
            this.btn_Acessar.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Acessar.selected = false;
            this.btn_Acessar.Size = new System.Drawing.Size(358, 39);
            this.btn_Acessar.TabIndex = 7;
            this.btn_Acessar.Text = "ACESSAR";
            this.btn_Acessar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Acessar.Textcolor = System.Drawing.Color.White;
            this.btn_Acessar.TextFont = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Acessar.Click += new System.EventHandler(this.btn_Acessar_Click);
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
            this.txt_Senha.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Senha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(43)))), ((int)(((byte)(122)))));
            this.txt_Senha.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Senha.HintText = "Senha";
            this.txt_Senha.isPassword = true;
            this.txt_Senha.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.txt_Senha.LineIdleColor = System.Drawing.Color.RoyalBlue;
            this.txt_Senha.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(43)))), ((int)(((byte)(122)))));
            this.txt_Senha.LineThickness = 3;
            this.txt_Senha.Location = new System.Drawing.Point(13, 56);
            this.txt_Senha.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Senha.MaxLength = 32767;
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(358, 33);
            this.txt_Senha.TabIndex = 6;
            this.txt_Senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_UsuárioProf
            // 
            this.txt_UsuárioProf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_UsuárioProf.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_UsuárioProf.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_UsuárioProf.BackColor = System.Drawing.Color.White;
            this.txt_UsuárioProf.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_UsuárioProf.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_UsuárioProf.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_UsuárioProf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(43)))), ((int)(((byte)(122)))));
            this.txt_UsuárioProf.HintForeColor = System.Drawing.Color.Empty;
            this.txt_UsuárioProf.HintText = "Usuário";
            this.txt_UsuárioProf.isPassword = false;
            this.txt_UsuárioProf.LineFocusedColor = System.Drawing.Color.MidnightBlue;
            this.txt_UsuárioProf.LineIdleColor = System.Drawing.Color.RoyalBlue;
            this.txt_UsuárioProf.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(43)))), ((int)(((byte)(122)))));
            this.txt_UsuárioProf.LineThickness = 3;
            this.txt_UsuárioProf.Location = new System.Drawing.Point(13, 13);
            this.txt_UsuárioProf.Margin = new System.Windows.Forms.Padding(4);
            this.txt_UsuárioProf.MaxLength = 32767;
            this.txt_UsuárioProf.Name = "txt_UsuárioProf";
            this.txt_UsuárioProf.Size = new System.Drawing.Size(358, 33);
            this.txt_UsuárioProf.TabIndex = 5;
            this.txt_UsuárioProf.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // frm_Autenticar_Professor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(384, 151);
            this.Controls.Add(this.btn_Acessar);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.txt_UsuárioProf);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Autenticar_Professor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Autenticar Professor";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btn_Acessar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Senha;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_UsuárioProf;
    }
}