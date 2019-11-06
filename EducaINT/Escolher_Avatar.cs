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
    public partial class frm_Escolher_Avatar : Form
    {
        public static Bitmap avatar = null;
        private List<Bitmap> avatares;

        public frm_Escolher_Avatar()
        {
            InitializeComponent();
            avatares = new List<Bitmap>();
            Load_Avatares();
        }

        private void Load_Avatares()
        {
            int id_avatar = 0;
            string path_avatar = string.Format("{0}{1:00}.{2}", Data_Controller.path_images, id_avatar, "png");
            while (Data_Controller.File_Exists(path_avatar))
            {
                avatares.Add(new Bitmap(path_avatar));

                PictureBox pic_avatar = new PictureBox();
                pic_avatar.Image = new Bitmap(avatares[id_avatar]);
                pic_avatar.Tag = id_avatar;
                pic_avatar.Cursor = Cursors.Hand;
                pic_avatar.Size = new Size(135, 135);
                pic_avatar.BackColor = Color.White;
                pic_avatar.SizeMode = PictureBoxSizeMode.Zoom;
                pic_avatar.Margin = new Padding(0, 0, 10, 10);
                pic_avatar.Click += (sender, EventArgs) => { Select_Avatar_Click(sender, EventArgs, pic_avatar); };
                flw_Avatares.Controls.Add(pic_avatar);

                path_avatar = string.Format("{0}{1:00}.{2}", Data_Controller.path_images, ++id_avatar, "png");
            }
            flw_Avatares.AutoScroll = avatares.Count > 8;
        }

        private void Select_Avatar_Click(object sender, EventArgs e, PictureBox pic_avatar)
        {
            avatar = avatares[int.Parse(pic_avatar.Tag.ToString())];
            foreach(Control c in flw_Avatares.Controls)
            {
                if(c is PictureBox)
                {
                    PictureBox pic_box = c as PictureBox;
                    if (pic_box != pic_avatar) { pic_box.BackColor = Color.White; }
                }
            }
            pic_avatar.BackColor = Color.DarkTurquoise;
        }

        private void btn_Avançar_Click(object sender, EventArgs e)
        {
            if (avatar == null) { MessageBox.Show("Selecione seu avatar primeiro!"); }
            else Close();
        }
    }
}
