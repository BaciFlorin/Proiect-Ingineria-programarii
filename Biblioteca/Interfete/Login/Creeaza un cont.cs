using System;
using Entitati;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.IO;

namespace Login
{
    public partial class Creeaza_un_cont : Form, IViewSignup
    {
        private OpenFileDialog dialog;
        private string error = "";

        private IControllerLogin _controllerLogin;

        private const int CP_NOCLOSE_BUTTON = 0x200;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        public Creeaza_un_cont()
        {
            InitializeComponent();
        }

        public void SetController(IControllerLogin controllerLogin)
        {
            _controllerLogin = controllerLogin;
        }

        private void butt_iesire_Click(object sender, EventArgs e)
        {
            // inainte de a iesi din aplicatie din interfata fiu trebuie 
            // oprita si interfata parinte (Owner.Dispose())
            this.Owner.Dispose();

            // iesirea propriu-zisa din aplicatie se poate face cu orice functie
            Application.Exit();
        }

        private void butt_cancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void butt_signin_Click(object sender, EventArgs e)
        {
            foreach (var control in Controls.OfType<TextBox>())
            {
                if (control.Name != "input_adresa" && control.Name != "input_telefon")
                {
                    if (control.Text == "")
                        control.BackColor = Color.LightPink;

                }
            }

            Persoana persoana = new Persoana(0, input_nume.Text, input_prenume.Text,
                input_adresa.Text, input_email.Text, input_telefon.Text, Path.GetFileName(dialog.FileName));
            

            User user = new User(0, input_usr.Text, input_pwd.Text);
            _controllerLogin.Inregistrare(persoana, user, input_pwd_conf.Text);
        }

        private void butt_img_Click(object sender, EventArgs e)
        {
            dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (dialog.ShowDialog() != DialogResult.OK)
                return;
            pb_img.Image = new Bitmap(dialog.FileName);
            string imagesPath = Directory.GetCurrentDirectory() +@"\images\"+ Path.GetFileName(dialog.FileName);

            File.Copy(dialog.FileName, imagesPath);
        }

        private void butt_reseteaza_Click(object sender, EventArgs e)
        {
            ReseteazaCampuri();
        }


        public void ReseteazaCampuri()
        {
            foreach (var control in this.gb_det_pers.Controls.OfType<TextBox>())
            {
                    control.Clear();
            }
            foreach (var control in this.gb_cont.Controls.OfType<TextBox>())
            {
                control.Clear();
            }

        }

        public void SpecificaEroarea()
        {
            MessageBox.Show(error, "Din pacate, au aparut erori la creearea contului", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void SeteazaEroarea(string message)
        {
            error = message;
        }

        public void InregistrareCuSucces()
        {
            MessageBox.Show("Inregistrare reusita!\nSe revine la meniul de login", "Inregistrare");
            this.Close();
        }
    }
}
