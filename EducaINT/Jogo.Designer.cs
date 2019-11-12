namespace EducaINT
{
    partial class frm_Jogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Jogo));
            this.pnl_BG = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lbl_Alternativa_5 = new System.Windows.Forms.Label();
            this.rb_Op_5 = new LollipopRadioButton();
            this.rb_Op_4 = new LollipopRadioButton();
            this.rb_Op_3 = new LollipopRadioButton();
            this.rb_Op_2 = new LollipopRadioButton();
            this.rb_Op_1 = new LollipopRadioButton();
            this.lbl_Tempo = new System.Windows.Forms.Label();
            this.lbl_Alternativa_4 = new System.Windows.Forms.Label();
            this.lbl_Alternativa_3 = new System.Windows.Forms.Label();
            this.lbl_Alternativa_2 = new System.Windows.Forms.Label();
            this.btn_Pause = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbl_Pergunta = new System.Windows.Forms.Label();
            this.btn_Pular = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbl_Alternativa_1 = new System.Windows.Forms.Label();
            this.elip_Form = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elip_Rb_1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elip_Rb_2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elip_Rb_3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elip_Rb_4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.elip_Rb_5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnl_BG.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_BG
            // 
            this.pnl_BG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnl_BG.BackgroundImage")));
            this.pnl_BG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_BG.Controls.Add(this.lbl_Alternativa_5);
            this.pnl_BG.Controls.Add(this.rb_Op_5);
            this.pnl_BG.Controls.Add(this.rb_Op_4);
            this.pnl_BG.Controls.Add(this.rb_Op_3);
            this.pnl_BG.Controls.Add(this.rb_Op_2);
            this.pnl_BG.Controls.Add(this.rb_Op_1);
            this.pnl_BG.Controls.Add(this.lbl_Tempo);
            this.pnl_BG.Controls.Add(this.lbl_Alternativa_4);
            this.pnl_BG.Controls.Add(this.lbl_Alternativa_3);
            this.pnl_BG.Controls.Add(this.lbl_Alternativa_2);
            this.pnl_BG.Controls.Add(this.btn_Pause);
            this.pnl_BG.Controls.Add(this.lbl_Pergunta);
            this.pnl_BG.Controls.Add(this.btn_Pular);
            this.pnl_BG.Controls.Add(this.lbl_Alternativa_1);
            this.pnl_BG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_BG.GradientBottomLeft = System.Drawing.Color.DarkTurquoise;
            this.pnl_BG.GradientBottomRight = System.Drawing.Color.MidnightBlue;
            this.pnl_BG.GradientTopLeft = System.Drawing.Color.DarkTurquoise;
            this.pnl_BG.GradientTopRight = System.Drawing.Color.MidnightBlue;
            this.pnl_BG.Location = new System.Drawing.Point(0, 0);
            this.pnl_BG.Name = "pnl_BG";
            this.pnl_BG.Quality = 10;
            this.pnl_BG.Size = new System.Drawing.Size(800, 450);
            this.pnl_BG.TabIndex = 4;
            // 
            // lbl_Alternativa_5
            // 
            this.lbl_Alternativa_5.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Alternativa_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Alternativa_5.ForeColor = System.Drawing.Color.White;
            this.lbl_Alternativa_5.Location = new System.Drawing.Point(71, 277);
            this.lbl_Alternativa_5.Name = "lbl_Alternativa_5";
            this.lbl_Alternativa_5.Size = new System.Drawing.Size(686, 31);
            this.lbl_Alternativa_5.TabIndex = 25;
            this.lbl_Alternativa_5.Text = "Alternativa qualquer.";
            this.lbl_Alternativa_5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rb_Op_5
            // 
            this.rb_Op_5.AutoSize = true;
            this.rb_Op_5.BackColor = System.Drawing.Color.Transparent;
            this.rb_Op_5.CheckColor = "#162B7A";
            this.rb_Op_5.Location = new System.Drawing.Point(46, 283);
            this.rb_Op_5.Name = "rb_Op_5";
            this.rb_Op_5.Size = new System.Drawing.Size(19, 19);
            this.rb_Op_5.TabIndex = 24;
            this.rb_Op_5.TabStop = true;
            this.rb_Op_5.Tag = "4";
            this.rb_Op_5.UseVisualStyleBackColor = false;
            this.rb_Op_5.CheckedChanged += new System.EventHandler(this.Rb_Op_5_CheckedChanged);
            // 
            // rb_Op_4
            // 
            this.rb_Op_4.AutoSize = true;
            this.rb_Op_4.BackColor = System.Drawing.Color.Transparent;
            this.rb_Op_4.CheckColor = "#162B7A";
            this.rb_Op_4.Location = new System.Drawing.Point(46, 232);
            this.rb_Op_4.Name = "rb_Op_4";
            this.rb_Op_4.Size = new System.Drawing.Size(19, 19);
            this.rb_Op_4.TabIndex = 23;
            this.rb_Op_4.TabStop = true;
            this.rb_Op_4.Tag = "3";
            this.rb_Op_4.UseVisualStyleBackColor = false;
            this.rb_Op_4.CheckedChanged += new System.EventHandler(this.Rb_Op_4_CheckedChanged);
            // 
            // rb_Op_3
            // 
            this.rb_Op_3.AutoSize = true;
            this.rb_Op_3.BackColor = System.Drawing.Color.Transparent;
            this.rb_Op_3.CheckColor = "#162B7A";
            this.rb_Op_3.Location = new System.Drawing.Point(46, 181);
            this.rb_Op_3.Name = "rb_Op_3";
            this.rb_Op_3.Size = new System.Drawing.Size(19, 19);
            this.rb_Op_3.TabIndex = 22;
            this.rb_Op_3.TabStop = true;
            this.rb_Op_3.Tag = "2";
            this.rb_Op_3.UseVisualStyleBackColor = false;
            this.rb_Op_3.CheckedChanged += new System.EventHandler(this.Rb_Op_3_CheckedChanged);
            // 
            // rb_Op_2
            // 
            this.rb_Op_2.AutoSize = true;
            this.rb_Op_2.BackColor = System.Drawing.Color.Transparent;
            this.rb_Op_2.CheckColor = "#162B7A";
            this.rb_Op_2.Location = new System.Drawing.Point(46, 130);
            this.rb_Op_2.Name = "rb_Op_2";
            this.rb_Op_2.Size = new System.Drawing.Size(19, 19);
            this.rb_Op_2.TabIndex = 21;
            this.rb_Op_2.TabStop = true;
            this.rb_Op_2.Tag = "1";
            this.rb_Op_2.UseVisualStyleBackColor = false;
            this.rb_Op_2.CheckedChanged += new System.EventHandler(this.Rb_Op_2_CheckedChanged);
            // 
            // rb_Op_1
            // 
            this.rb_Op_1.AutoSize = true;
            this.rb_Op_1.BackColor = System.Drawing.Color.Transparent;
            this.rb_Op_1.CheckColor = "#162B7A";
            this.rb_Op_1.Location = new System.Drawing.Point(46, 79);
            this.rb_Op_1.Margin = new System.Windows.Forms.Padding(0);
            this.rb_Op_1.Name = "rb_Op_1";
            this.rb_Op_1.Size = new System.Drawing.Size(19, 19);
            this.rb_Op_1.TabIndex = 20;
            this.rb_Op_1.TabStop = true;
            this.rb_Op_1.Tag = "0";
            this.rb_Op_1.UseVisualStyleBackColor = false;
            this.rb_Op_1.CheckedChanged += new System.EventHandler(this.Rb_Op_1_CheckedChanged);
            // 
            // lbl_Tempo
            // 
            this.lbl_Tempo.BackColor = System.Drawing.Color.White;
            this.lbl_Tempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tempo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Tempo.Location = new System.Drawing.Point(0, -1);
            this.lbl_Tempo.Name = "lbl_Tempo";
            this.lbl_Tempo.Size = new System.Drawing.Size(175, 29);
            this.lbl_Tempo.TabIndex = 19;
            this.lbl_Tempo.Text = "00:00";
            this.lbl_Tempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Alternativa_4
            // 
            this.lbl_Alternativa_4.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Alternativa_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Alternativa_4.ForeColor = System.Drawing.Color.White;
            this.lbl_Alternativa_4.Location = new System.Drawing.Point(71, 226);
            this.lbl_Alternativa_4.Name = "lbl_Alternativa_4";
            this.lbl_Alternativa_4.Size = new System.Drawing.Size(686, 31);
            this.lbl_Alternativa_4.TabIndex = 14;
            this.lbl_Alternativa_4.Text = "Alternativa qualquer.";
            this.lbl_Alternativa_4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Alternativa_3
            // 
            this.lbl_Alternativa_3.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Alternativa_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Alternativa_3.ForeColor = System.Drawing.Color.White;
            this.lbl_Alternativa_3.Location = new System.Drawing.Point(71, 175);
            this.lbl_Alternativa_3.Name = "lbl_Alternativa_3";
            this.lbl_Alternativa_3.Size = new System.Drawing.Size(686, 31);
            this.lbl_Alternativa_3.TabIndex = 13;
            this.lbl_Alternativa_3.Text = "Alternativa qualquer.";
            this.lbl_Alternativa_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Alternativa_2
            // 
            this.lbl_Alternativa_2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Alternativa_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Alternativa_2.ForeColor = System.Drawing.Color.White;
            this.lbl_Alternativa_2.Location = new System.Drawing.Point(71, 124);
            this.lbl_Alternativa_2.Name = "lbl_Alternativa_2";
            this.lbl_Alternativa_2.Size = new System.Drawing.Size(686, 31);
            this.lbl_Alternativa_2.TabIndex = 12;
            this.lbl_Alternativa_2.Text = "Alternativa qualquer.";
            this.lbl_Alternativa_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Pause
            // 
            this.btn_Pause.Active = false;
            this.btn_Pause.Activecolor = System.Drawing.Color.SlateGray;
            this.btn_Pause.BackColor = System.Drawing.Color.White;
            this.btn_Pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Pause.BorderRadius = 0;
            this.btn_Pause.ButtonText = "I I";
            this.btn_Pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Pause.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Pause.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Pause.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Pause.Iconimage")));
            this.btn_Pause.Iconimage_right = null;
            this.btn_Pause.Iconimage_right_Selected = null;
            this.btn_Pause.Iconimage_Selected = null;
            this.btn_Pause.IconMarginLeft = 0;
            this.btn_Pause.IconMarginRight = 0;
            this.btn_Pause.IconRightVisible = false;
            this.btn_Pause.IconRightZoom = 0D;
            this.btn_Pause.IconVisible = false;
            this.btn_Pause.IconZoom = 90D;
            this.btn_Pause.IsTab = false;
            this.btn_Pause.Location = new System.Drawing.Point(730, -1);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Normalcolor = System.Drawing.Color.White;
            this.btn_Pause.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.btn_Pause.OnHoverTextColor = System.Drawing.Color.MidnightBlue;
            this.btn_Pause.selected = false;
            this.btn_Pause.Size = new System.Drawing.Size(70, 29);
            this.btn_Pause.TabIndex = 11;
            this.btn_Pause.Text = "I I";
            this.btn_Pause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Pause.Textcolor = System.Drawing.Color.MidnightBlue;
            this.btn_Pause.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pause.Click += new System.EventHandler(this.btn_Pause_Click);
            // 
            // lbl_Pergunta
            // 
            this.lbl_Pergunta.BackColor = System.Drawing.Color.White;
            this.lbl_Pergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pergunta.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Pergunta.Location = new System.Drawing.Point(0, 350);
            this.lbl_Pergunta.Name = "lbl_Pergunta";
            this.lbl_Pergunta.Size = new System.Drawing.Size(800, 100);
            this.lbl_Pergunta.TabIndex = 10;
            this.lbl_Pergunta.Text = "Pergunta qualquer?";
            this.lbl_Pergunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Pular
            // 
            this.btn_Pular.Active = false;
            this.btn_Pular.Activecolor = System.Drawing.Color.SlateGray;
            this.btn_Pular.BackColor = System.Drawing.Color.White;
            this.btn_Pular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Pular.BorderRadius = 0;
            this.btn_Pular.ButtonText = "PULAR";
            this.btn_Pular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Pular.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Pular.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Pular.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Pular.Iconimage")));
            this.btn_Pular.Iconimage_right = null;
            this.btn_Pular.Iconimage_right_Selected = null;
            this.btn_Pular.Iconimage_Selected = null;
            this.btn_Pular.IconMarginLeft = 0;
            this.btn_Pular.IconMarginRight = 0;
            this.btn_Pular.IconRightVisible = false;
            this.btn_Pular.IconRightZoom = 0D;
            this.btn_Pular.IconVisible = false;
            this.btn_Pular.IconZoom = 90D;
            this.btn_Pular.IsTab = false;
            this.btn_Pular.Location = new System.Drawing.Point(631, -1);
            this.btn_Pular.Name = "btn_Pular";
            this.btn_Pular.Normalcolor = System.Drawing.Color.White;
            this.btn_Pular.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.btn_Pular.OnHoverTextColor = System.Drawing.Color.MidnightBlue;
            this.btn_Pular.selected = false;
            this.btn_Pular.Size = new System.Drawing.Size(103, 29);
            this.btn_Pular.TabIndex = 10;
            this.btn_Pular.Text = "PULAR";
            this.btn_Pular.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Pular.Textcolor = System.Drawing.Color.MidnightBlue;
            this.btn_Pular.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pular.Click += new System.EventHandler(this.Btn_Pular_Click);
            // 
            // lbl_Alternativa_1
            // 
            this.lbl_Alternativa_1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Alternativa_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Alternativa_1.ForeColor = System.Drawing.Color.White;
            this.lbl_Alternativa_1.Location = new System.Drawing.Point(71, 73);
            this.lbl_Alternativa_1.Name = "lbl_Alternativa_1";
            this.lbl_Alternativa_1.Size = new System.Drawing.Size(686, 31);
            this.lbl_Alternativa_1.TabIndex = 8;
            this.lbl_Alternativa_1.Text = "Alternativa qualquer.";
            this.lbl_Alternativa_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // elip_Form
            // 
            this.elip_Form.ElipseRadius = 10;
            this.elip_Form.TargetControl = this;
            // 
            // elip_Rb_1
            // 
            this.elip_Rb_1.ElipseRadius = 20;
            this.elip_Rb_1.TargetControl = this.rb_Op_1;
            // 
            // elip_Rb_2
            // 
            this.elip_Rb_2.ElipseRadius = 20;
            this.elip_Rb_2.TargetControl = this.rb_Op_2;
            // 
            // elip_Rb_3
            // 
            this.elip_Rb_3.ElipseRadius = 20;
            this.elip_Rb_3.TargetControl = this.rb_Op_3;
            // 
            // elip_Rb_4
            // 
            this.elip_Rb_4.ElipseRadius = 20;
            this.elip_Rb_4.TargetControl = this.rb_Op_4;
            // 
            // elip_Rb_5
            // 
            this.elip_Rb_5.ElipseRadius = 20;
            this.elip_Rb_5.TargetControl = this.rb_Op_5;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // frm_Jogo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_BG);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Jogo";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form5";
            this.pnl_BG.ResumeLayout(false);
            this.pnl_BG.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pnl_BG;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Pular;
        private System.Windows.Forms.Label lbl_Pergunta;
        private System.Windows.Forms.Label lbl_Alternativa_1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Pause;
        private Bunifu.Framework.UI.BunifuElipse elip_Form;
        private System.Windows.Forms.Label lbl_Alternativa_4;
        private System.Windows.Forms.Label lbl_Alternativa_3;
        private System.Windows.Forms.Label lbl_Alternativa_2;
        private System.Windows.Forms.Label lbl_Tempo;
        private LollipopRadioButton rb_Op_1;
        private System.Windows.Forms.Label lbl_Alternativa_5;
        private LollipopRadioButton rb_Op_5;
        private LollipopRadioButton rb_Op_4;
        private LollipopRadioButton rb_Op_3;
        private LollipopRadioButton rb_Op_2;
        private Bunifu.Framework.UI.BunifuElipse elip_Rb_1;
        private Bunifu.Framework.UI.BunifuElipse elip_Rb_2;
        private Bunifu.Framework.UI.BunifuElipse elip_Rb_3;
        private Bunifu.Framework.UI.BunifuElipse elip_Rb_4;
        private Bunifu.Framework.UI.BunifuElipse elip_Rb_5;
        private System.Windows.Forms.Timer timer1;
    }
}