namespace Inregistrare
{
    partial class Creeaza_un_cont
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
            this.butt_iesire = new System.Windows.Forms.Button();
            this.label_usr = new System.Windows.Forms.Label();
            this.label_pwd = new System.Windows.Forms.Label();
            this.gb_cont = new System.Windows.Forms.GroupBox();
            this.input_pwd_conf = new System.Windows.Forms.TextBox();
            this.input_pwd = new System.Windows.Forms.TextBox();
            this.input_usr = new System.Windows.Forms.TextBox();
            this.label_pwd_conf = new System.Windows.Forms.Label();
            this.gb_det_pers = new System.Windows.Forms.GroupBox();
            this.input_adresa = new System.Windows.Forms.TextBox();
            this.input_nr_matricol = new System.Windows.Forms.TextBox();
            this.input_unitate_inv = new System.Windows.Forms.TextBox();
            this.input_email = new System.Windows.Forms.TextBox();
            this.input_prenume = new System.Windows.Forms.TextBox();
            this.input_nume = new System.Windows.Forms.TextBox();
            this.label_nr_tel = new System.Windows.Forms.Label();
            this.label_adresa = new System.Windows.Forms.Label();
            this.label_nr_matricol = new System.Windows.Forms.Label();
            this.label_unitate_inv = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_prenume = new System.Windows.Forms.Label();
            this.butt_signin = new System.Windows.Forms.Button();
            this.butt_cancel = new System.Windows.Forms.Button();
            this.gb_img = new System.Windows.Forms.GroupBox();
            this.pb_img = new System.Windows.Forms.PictureBox();
            this.butt_img = new System.Windows.Forms.Button();
            this.file_diag_img = new System.Windows.Forms.OpenFileDialog();
            this.label_prefix = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gb_cont.SuspendLayout();
            this.gb_det_pers.SuspendLayout();
            this.gb_img.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_img)).BeginInit();
            this.SuspendLayout();
            // 
            // butt_iesire
            // 
            this.butt_iesire.Location = new System.Drawing.Point(480, 465);
            this.butt_iesire.Name = "butt_iesire";
            this.butt_iesire.Size = new System.Drawing.Size(85, 26);
            this.butt_iesire.TabIndex = 0;
            this.butt_iesire.Text = "Valea! :)";
            this.butt_iesire.UseVisualStyleBackColor = true;
            this.butt_iesire.Click += new System.EventHandler(this.butt_iesire_Click);
            // 
            // label_usr
            // 
            this.label_usr.AutoSize = true;
            this.label_usr.Location = new System.Drawing.Point(19, 31);
            this.label_usr.Name = "label_usr";
            this.label_usr.Size = new System.Drawing.Size(106, 17);
            this.label_usr.TabIndex = 1;
            this.label_usr.Text = "Nume utilizator:";
            // 
            // label_pwd
            // 
            this.label_pwd.AutoSize = true;
            this.label_pwd.Location = new System.Drawing.Point(19, 75);
            this.label_pwd.Name = "label_pwd";
            this.label_pwd.Size = new System.Drawing.Size(53, 17);
            this.label_pwd.TabIndex = 2;
            this.label_pwd.Text = "Parola:";
            // 
            // gb_cont
            // 
            this.gb_cont.Controls.Add(this.input_pwd_conf);
            this.gb_cont.Controls.Add(this.input_pwd);
            this.gb_cont.Controls.Add(this.input_usr);
            this.gb_cont.Controls.Add(this.label_pwd_conf);
            this.gb_cont.Controls.Add(this.label_usr);
            this.gb_cont.Controls.Add(this.label_pwd);
            this.gb_cont.Location = new System.Drawing.Point(26, 22);
            this.gb_cont.Name = "gb_cont";
            this.gb_cont.Size = new System.Drawing.Size(330, 166);
            this.gb_cont.TabIndex = 3;
            this.gb_cont.TabStop = false;
            this.gb_cont.Text = "Detalii cont";
            // 
            // input_pwd_conf
            // 
            this.input_pwd_conf.Location = new System.Drawing.Point(150, 116);
            this.input_pwd_conf.MaxLength = 64;
            this.input_pwd_conf.Name = "input_pwd_conf";
            this.input_pwd_conf.PasswordChar = '♥';
            this.input_pwd_conf.Size = new System.Drawing.Size(151, 22);
            this.input_pwd_conf.TabIndex = 6;
            // 
            // input_pwd
            // 
            this.input_pwd.Location = new System.Drawing.Point(150, 72);
            this.input_pwd.MaxLength = 64;
            this.input_pwd.Name = "input_pwd";
            this.input_pwd.PasswordChar = '♥';
            this.input_pwd.Size = new System.Drawing.Size(151, 22);
            this.input_pwd.TabIndex = 5;
            // 
            // input_usr
            // 
            this.input_usr.Location = new System.Drawing.Point(150, 28);
            this.input_usr.MaxLength = 256;
            this.input_usr.Name = "input_usr";
            this.input_usr.Size = new System.Drawing.Size(151, 22);
            this.input_usr.TabIndex = 4;
            // 
            // label_pwd_conf
            // 
            this.label_pwd_conf.AutoSize = true;
            this.label_pwd_conf.Location = new System.Drawing.Point(19, 119);
            this.label_pwd_conf.Name = "label_pwd_conf";
            this.label_pwd_conf.Size = new System.Drawing.Size(125, 17);
            this.label_pwd_conf.TabIndex = 3;
            this.label_pwd_conf.Text = "Confirmare parola:";
            // 
            // gb_det_pers
            // 
            this.gb_det_pers.Controls.Add(this.textBox1);
            this.gb_det_pers.Controls.Add(this.label_prefix);
            this.gb_det_pers.Controls.Add(this.input_adresa);
            this.gb_det_pers.Controls.Add(this.input_nr_matricol);
            this.gb_det_pers.Controls.Add(this.input_unitate_inv);
            this.gb_det_pers.Controls.Add(this.input_email);
            this.gb_det_pers.Controls.Add(this.input_prenume);
            this.gb_det_pers.Controls.Add(this.input_nume);
            this.gb_det_pers.Controls.Add(this.label_nr_tel);
            this.gb_det_pers.Controls.Add(this.label_adresa);
            this.gb_det_pers.Controls.Add(this.label_nr_matricol);
            this.gb_det_pers.Controls.Add(this.label_unitate_inv);
            this.gb_det_pers.Controls.Add(this.label_email);
            this.gb_det_pers.Controls.Add(this.label2);
            this.gb_det_pers.Controls.Add(this.label_prenume);
            this.gb_det_pers.Location = new System.Drawing.Point(26, 206);
            this.gb_det_pers.Name = "gb_det_pers";
            this.gb_det_pers.Size = new System.Drawing.Size(568, 241);
            this.gb_det_pers.TabIndex = 4;
            this.gb_det_pers.TabStop = false;
            this.gb_det_pers.Text = "Detalii personale";
            // 
            // input_adresa
            // 
            this.input_adresa.Location = new System.Drawing.Point(27, 193);
            this.input_adresa.MaxLength = 512;
            this.input_adresa.Name = "input_adresa";
            this.input_adresa.Size = new System.Drawing.Size(308, 22);
            this.input_adresa.TabIndex = 13;
            // 
            // input_nr_matricol
            // 
            this.input_nr_matricol.Location = new System.Drawing.Point(372, 131);
            this.input_nr_matricol.MaxLength = 10;
            this.input_nr_matricol.Name = "input_nr_matricol";
            this.input_nr_matricol.Size = new System.Drawing.Size(118, 22);
            this.input_nr_matricol.TabIndex = 12;
            // 
            // input_unitate_inv
            // 
            this.input_unitate_inv.Location = new System.Drawing.Point(27, 131);
            this.input_unitate_inv.MaxLength = 512;
            this.input_unitate_inv.Name = "input_unitate_inv";
            this.input_unitate_inv.Size = new System.Drawing.Size(308, 22);
            this.input_unitate_inv.TabIndex = 11;
            // 
            // input_email
            // 
            this.input_email.Location = new System.Drawing.Point(372, 61);
            this.input_email.MaxLength = 128;
            this.input_email.Name = "input_email";
            this.input_email.Size = new System.Drawing.Size(168, 22);
            this.input_email.TabIndex = 10;
            // 
            // input_prenume
            // 
            this.input_prenume.Location = new System.Drawing.Point(192, 61);
            this.input_prenume.MaxLength = 128;
            this.input_prenume.Name = "input_prenume";
            this.input_prenume.Size = new System.Drawing.Size(138, 22);
            this.input_prenume.TabIndex = 9;
            // 
            // input_nume
            // 
            this.input_nume.Location = new System.Drawing.Point(27, 61);
            this.input_nume.MaxLength = 64;
            this.input_nume.Name = "input_nume";
            this.input_nume.Size = new System.Drawing.Size(122, 22);
            this.input_nume.TabIndex = 8;
            // 
            // label_nr_tel
            // 
            this.label_nr_tel.AutoSize = true;
            this.label_nr_tel.Location = new System.Drawing.Point(369, 167);
            this.label_nr_tel.Name = "label_nr_tel";
            this.label_nr_tel.Size = new System.Drawing.Size(121, 17);
            this.label_nr_tel.TabIndex = 7;
            this.label_nr_tel.Text = "Numar de telefon:";
            // 
            // label_adresa
            // 
            this.label_adresa.AutoSize = true;
            this.label_adresa.Location = new System.Drawing.Point(24, 167);
            this.label_adresa.Name = "label_adresa";
            this.label_adresa.Size = new System.Drawing.Size(57, 17);
            this.label_adresa.TabIndex = 6;
            this.label_adresa.Text = "Adresa:";
            // 
            // label_nr_matricol
            // 
            this.label_nr_matricol.AutoSize = true;
            this.label_nr_matricol.Location = new System.Drawing.Point(369, 99);
            this.label_nr_matricol.Name = "label_nr_matricol";
            this.label_nr_matricol.Size = new System.Drawing.Size(107, 17);
            this.label_nr_matricol.TabIndex = 5;
            this.label_nr_matricol.Text = "Numar matricol:";
            // 
            // label_unitate_inv
            // 
            this.label_unitate_inv.AutoSize = true;
            this.label_unitate_inv.Location = new System.Drawing.Point(24, 99);
            this.label_unitate_inv.Name = "label_unitate_inv";
            this.label_unitate_inv.Size = new System.Drawing.Size(158, 17);
            this.label_unitate_inv.TabIndex = 4;
            this.label_unitate_inv.Text = "Unitatea de invatamant:";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(369, 31);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(51, 17);
            this.label_email.TabIndex = 3;
            this.label_email.Text = "E-mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nume:";
            // 
            // label_prenume
            // 
            this.label_prenume.AutoSize = true;
            this.label_prenume.Location = new System.Drawing.Point(189, 31);
            this.label_prenume.Name = "label_prenume";
            this.label_prenume.Size = new System.Drawing.Size(69, 17);
            this.label_prenume.TabIndex = 2;
            this.label_prenume.Text = "Prenume:";
            // 
            // butt_signin
            // 
            this.butt_signin.Location = new System.Drawing.Point(247, 465);
            this.butt_signin.Name = "butt_signin";
            this.butt_signin.Size = new System.Drawing.Size(122, 26);
            this.butt_signin.TabIndex = 5;
            this.butt_signin.Text = "Inregistreaza-te";
            this.butt_signin.UseVisualStyleBackColor = true;
            this.butt_signin.Click += new System.EventHandler(this.butt_signin_Click);
            // 
            // butt_cancel
            // 
            this.butt_cancel.Location = new System.Drawing.Point(57, 465);
            this.butt_cancel.Name = "butt_cancel";
            this.butt_cancel.Size = new System.Drawing.Size(85, 26);
            this.butt_cancel.TabIndex = 6;
            this.butt_cancel.Text = "Renunta";
            this.butt_cancel.UseVisualStyleBackColor = true;
            this.butt_cancel.Click += new System.EventHandler(this.butt_cancel_Click);
            // 
            // gb_img
            // 
            this.gb_img.Controls.Add(this.pb_img);
            this.gb_img.Controls.Add(this.butt_img);
            this.gb_img.Location = new System.Drawing.Point(376, 22);
            this.gb_img.Name = "gb_img";
            this.gb_img.Size = new System.Drawing.Size(217, 166);
            this.gb_img.TabIndex = 7;
            this.gb_img.TabStop = false;
            this.gb_img.Text = "Imagine";
            // 
            // pb_img
            // 
            this.pb_img.Image = global::Inregistrare.Properties.Resources.user;
            this.pb_img.InitialImage = null;
            this.pb_img.Location = new System.Drawing.Point(75, 21);
            this.pb_img.Name = "pb_img";
            this.pb_img.Size = new System.Drawing.Size(79, 83);
            this.pb_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_img.TabIndex = 2;
            this.pb_img.TabStop = false;
            // 
            // butt_img
            // 
            this.butt_img.Location = new System.Drawing.Point(33, 120);
            this.butt_img.Name = "butt_img";
            this.butt_img.Size = new System.Drawing.Size(156, 26);
            this.butt_img.TabIndex = 1;
            this.butt_img.Text = "Adauga o imagine";
            this.butt_img.UseVisualStyleBackColor = true;
            this.butt_img.Click += new System.EventHandler(this.butt_img_Click);
            // 
            // file_diag_img
            // 
            this.file_diag_img.Title = "Selecteaza o imagine";
            // 
            // label_prefix
            // 
            this.label_prefix.AutoSize = true;
            this.label_prefix.Location = new System.Drawing.Point(369, 197);
            this.label_prefix.Name = "label_prefix";
            this.label_prefix.Size = new System.Drawing.Size(32, 17);
            this.label_prefix.TabIndex = 14;
            this.label_prefix.Text = "+40";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(400, 193);
            this.textBox1.MaxLength = 9;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 22);
            this.textBox1.TabIndex = 15;
            // 
            // Creeaza_un_cont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 511);
            this.Controls.Add(this.gb_img);
            this.Controls.Add(this.butt_cancel);
            this.Controls.Add(this.butt_signin);
            this.Controls.Add(this.gb_det_pers);
            this.Controls.Add(this.gb_cont);
            this.Controls.Add(this.butt_iesire);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Creeaza_un_cont";
            this.Text = "Creeaza un cont";
            this.gb_cont.ResumeLayout(false);
            this.gb_cont.PerformLayout();
            this.gb_det_pers.ResumeLayout(false);
            this.gb_det_pers.PerformLayout();
            this.gb_img.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butt_iesire;
        private System.Windows.Forms.Label label_usr;
        private System.Windows.Forms.Label label_pwd;
        private System.Windows.Forms.GroupBox gb_cont;
        private System.Windows.Forms.Label label_pwd_conf;
        private System.Windows.Forms.GroupBox gb_det_pers;
        private System.Windows.Forms.Label label_nr_tel;
        private System.Windows.Forms.Label label_adresa;
        private System.Windows.Forms.Label label_nr_matricol;
        private System.Windows.Forms.Label label_unitate_inv;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_prenume;
        private System.Windows.Forms.Button butt_signin;
        private System.Windows.Forms.Button butt_cancel;
        private System.Windows.Forms.TextBox input_pwd_conf;
        private System.Windows.Forms.TextBox input_pwd;
        private System.Windows.Forms.TextBox input_usr;
        private System.Windows.Forms.GroupBox gb_img;
        private System.Windows.Forms.PictureBox pb_img;
        private System.Windows.Forms.Button butt_img;
        private System.Windows.Forms.TextBox input_email;
        private System.Windows.Forms.TextBox input_prenume;
        private System.Windows.Forms.TextBox input_nume;
        private System.Windows.Forms.OpenFileDialog file_diag_img;
        private System.Windows.Forms.TextBox input_adresa;
        private System.Windows.Forms.TextBox input_nr_matricol;
        private System.Windows.Forms.TextBox input_unitate_inv;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_prefix;
    }
}