using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inregistrare
{
    public partial class Creeaza_un_cont : Form
    {
        private OpenFileDialog dialog;

        public Creeaza_un_cont()
        {
            InitializeComponent();
        }

        private void butt_iesire_Click(object sender, EventArgs e)
        {
            this.Owner.Dispose();
            Application.Exit();
        }

        private void butt_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butt_signin_Click(object sender, EventArgs e)
        {
            //validari si eventual schimb proprietatile
            this.Close();
        }

        private void butt_img_Click(object sender, EventArgs e)
        {
            dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (dialog.ShowDialog() != DialogResult.OK)
                return;
            this.pb_img.Image = new Bitmap(dialog.FileName);


        }

    }
}
