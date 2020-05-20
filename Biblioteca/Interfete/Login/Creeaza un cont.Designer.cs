namespace Login
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
            this.input_email = new System.Windows.Forms.TextBox();
            this.label_email = new System.Windows.Forms.Label();
            this.input_telefon = new System.Windows.Forms.TextBox();
            this.label_prefix = new System.Windows.Forms.Label();
            this.input_adresa = new System.Windows.Forms.TextBox();
            this.input_prenume = new System.Windows.Forms.TextBox();
            this.input_nume = new System.Windows.Forms.TextBox();
            this.label_nr_tel = new System.Windows.Forms.Label();
            this.label_adresa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_prenume = new System.Windows.Forms.Label();
            this.butt_signin = new System.Windows.Forms.Button();
            this.butt_cancel = new System.Windows.Forms.Button();
            this.gb_img = new System.Windows.Forms.GroupBox();
            this.butt_img = new System.Windows.Forms.Button();
            this.file_diag_img = new System.Windows.Forms.OpenFileDialog();
            this.label_eroare = new System.Windows.Forms.Label();
            this.butt_reseteaza = new System.Windows.Forms.Button();
            this.pb_img = new WindowsFormsApplication27.RoundPictureBox();
            this.gb_cont.SuspendLayout();
            this.gb_det_pers.SuspendLayout();
            this.gb_img.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_img)).BeginInit();
            this.SuspendLayout();
            // 
            // butt_iesire
            // 
            this.butt_iesire.Location = new System.Drawing.Point(495, 437);
            this.butt_iesire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butt_iesire.Name = "butt_iesire";
            this.butt_iesire.Size = new System.Drawing.Size(85, 26);
            this.butt_iesire.TabIndex = 0;
            this.butt_iesire.Text = "Iesire";
            this.butt_iesire.UseVisualStyleBackColor = true;
            this.butt_iesire.Click += new System.EventHandler(this.butt_iesire_Click);
            // 
            // label_usr
            // 
            this.label_usr.AutoSize = true;
            this.label_usr.Location = new System.Drawing.Point(19, 31);
            this.label_usr.Name = "label_usr";
            this.label_usr.Size = new System.Drawing.Size(115, 17);
            this.label_usr.TabIndex = 1;
            this.label_usr.Text = "Nume utilizator: *";
            // 
            // label_pwd
            // 
            this.label_pwd.AutoSize = true;
            this.label_pwd.Location = new System.Drawing.Point(19, 75);
            this.label_pwd.Name = "label_pwd";
            this.label_pwd.Size = new System.Drawing.Size(62, 17);
            this.label_pwd.TabIndex = 2;
            this.label_pwd.Text = "Parola: *";
            // 
            // gb_cont
            // 
            this.gb_cont.Controls.Add(this.input_pwd_conf);
            this.gb_cont.Controls.Add(this.input_pwd);
            this.gb_cont.Controls.Add(this.input_usr);
            this.gb_cont.Controls.Add(this.label_pwd_conf);
            this.gb_cont.Controls.Add(this.label_usr);
            this.gb_cont.Controls.Add(this.label_pwd);
            this.gb_cont.Location = new System.Drawing.Point(27, 22);
            this.gb_cont.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_cont.Name = "gb_cont";
            this.gb_cont.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_cont.Size = new System.Drawing.Size(331, 166);
            this.gb_cont.TabIndex = 3;
            this.gb_cont.TabStop = false;
            this.gb_cont.Text = "Detalii cont";
            // 
            // input_pwd_conf
            // 
            this.input_pwd_conf.Location = new System.Drawing.Point(149, 116);
            this.input_pwd_conf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.input_pwd_conf.MaxLength = 64;
            this.input_pwd_conf.Name = "input_pwd_conf";
            this.input_pwd_conf.PasswordChar = '♥';
            this.input_pwd_conf.Size = new System.Drawing.Size(151, 22);
            this.input_pwd_conf.TabIndex = 6;
            // 
            // input_pwd
            // 
            this.input_pwd.Location = new System.Drawing.Point(149, 71);
            this.input_pwd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.input_pwd.MaxLength = 64;
            this.input_pwd.Name = "input_pwd";
            this.input_pwd.PasswordChar = '♥';
            this.input_pwd.Size = new System.Drawing.Size(151, 22);
            this.input_pwd.TabIndex = 5;
            // 
            // input_usr
            // 
            this.input_usr.Location = new System.Drawing.Point(149, 28);
            this.input_usr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.label_pwd_conf.Size = new System.Drawing.Size(134, 17);
            this.label_pwd_conf.TabIndex = 3;
            this.label_pwd_conf.Text = "Confirmare parola: *";
            // 
            // gb_det_pers
            // 
            this.gb_det_pers.Controls.Add(this.input_email);
            this.gb_det_pers.Controls.Add(this.label_email);
            this.gb_det_pers.Controls.Add(this.input_telefon);
            this.gb_det_pers.Controls.Add(this.label_prefix);
            this.gb_det_pers.Controls.Add(this.input_adresa);
            this.gb_det_pers.Controls.Add(this.input_prenume);
            this.gb_det_pers.Controls.Add(this.input_nume);
            this.gb_det_pers.Controls.Add(this.label_nr_tel);
            this.gb_det_pers.Controls.Add(this.label_adresa);
            this.gb_det_pers.Controls.Add(this.label2);
            this.gb_det_pers.Controls.Add(this.label_prenume);
            this.gb_det_pers.Location = new System.Drawing.Point(27, 206);
            this.gb_det_pers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_det_pers.Name = "gb_det_pers";
            this.gb_det_pers.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_det_pers.Size = new System.Drawing.Size(568, 181);
            this.gb_det_pers.TabIndex = 4;
            this.gb_det_pers.TabStop = false;
            this.gb_det_pers.Text = "Detalii personale";
            // 
            // input_email
            // 
            this.input_email.Location = new System.Drawing.Point(373, 59);
            this.input_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.input_email.MaxLength = 128;
            this.input_email.Name = "input_email";
            this.input_email.Size = new System.Drawing.Size(164, 22);
            this.input_email.TabIndex = 17;
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Location = new System.Drawing.Point(369, 28);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(60, 17);
            this.label_email.TabIndex = 16;
            this.label_email.Text = "E-mail: *";
            // 
            // input_telefon
            // 
            this.input_telefon.Location = new System.Drawing.Point(404, 124);
            this.input_telefon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.input_telefon.MaxLength = 9;
            this.input_telefon.Name = "input_telefon";
            this.input_telefon.Size = new System.Drawing.Size(121, 22);
            this.input_telefon.TabIndex = 15;
            // 
            // label_prefix
            // 
            this.label_prefix.AutoSize = true;
            this.label_prefix.Location = new System.Drawing.Point(373, 128);
            this.label_prefix.Name = "label_prefix";
            this.label_prefix.Size = new System.Drawing.Size(32, 17);
            this.label_prefix.TabIndex = 14;
            this.label_prefix.Text = "+40";
            // 
            // input_adresa
            // 
            this.input_adresa.Location = new System.Drawing.Point(23, 124);
            this.input_adresa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.input_adresa.MaxLength = 512;
            this.input_adresa.Name = "input_adresa";
            this.input_adresa.Size = new System.Drawing.Size(303, 22);
            this.input_adresa.TabIndex = 13;
            // 
            // input_prenume
            // 
            this.input_prenume.Location = new System.Drawing.Point(195, 59);
            this.input_prenume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.input_prenume.MaxLength = 128;
            this.input_prenume.Name = "input_prenume";
            this.input_prenume.Size = new System.Drawing.Size(151, 22);
            this.input_prenume.TabIndex = 9;
            // 
            // input_nume
            // 
            this.input_nume.Location = new System.Drawing.Point(23, 59);
            this.input_nume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.input_nume.MaxLength = 64;
            this.input_nume.Name = "input_nume";
            this.input_nume.Size = new System.Drawing.Size(151, 22);
            this.input_nume.TabIndex = 8;
            // 
            // label_nr_tel
            // 
            this.label_nr_tel.AutoSize = true;
            this.label_nr_tel.Location = new System.Drawing.Point(373, 98);
            this.label_nr_tel.Name = "label_nr_tel";
            this.label_nr_tel.Size = new System.Drawing.Size(121, 17);
            this.label_nr_tel.TabIndex = 7;
            this.label_nr_tel.Text = "Numar de telefon:";
            // 
            // label_adresa
            // 
            this.label_adresa.AutoSize = true;
            this.label_adresa.Location = new System.Drawing.Point(20, 98);
            this.label_adresa.Name = "label_adresa";
            this.label_adresa.Size = new System.Drawing.Size(57, 17);
            this.label_adresa.TabIndex = 6;
            this.label_adresa.Text = "Adresa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nume: *";
            // 
            // label_prenume
            // 
            this.label_prenume.AutoSize = true;
            this.label_prenume.Location = new System.Drawing.Point(191, 28);
            this.label_prenume.Name = "label_prenume";
            this.label_prenume.Size = new System.Drawing.Size(78, 17);
            this.label_prenume.TabIndex = 2;
            this.label_prenume.Text = "Prenume: *";
            // 
            // butt_signin
            // 
            this.butt_signin.Location = new System.Drawing.Point(321, 437);
            this.butt_signin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.butt_signin.Name = "butt_signin";
            this.butt_signin.Size = new System.Drawing.Size(123, 26);
            this.butt_signin.TabIndex = 5;
            this.butt_signin.Text = "Inregistreaza-te";
            this.butt_signin.UseVisualStyleBackColor = true;
            this.butt_signin.Click += new System.EventHandler(this.butt_signin_Click);
            // 
            // butt_cancel
            // 
            this.butt_cancel.Location = new System.Drawing.Point(49, 437);
            this.butt_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.gb_img.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_img.Name = "gb_img";
            this.gb_img.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_img.Size = new System.Drawing.Size(217, 166);
            this.gb_img.TabIndex = 7;
            this.gb_img.TabStop = false;
            this.gb_img.Text = "Imagine";
            // 
            // butt_img
            // 
            this.butt_img.Location = new System.Drawing.Point(33, 121);
            this.butt_img.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            // label_eroare
            // 
            this.label_eroare.AutoSize = true;
            this.label_eroare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_eroare.Location = new System.Drawing.Point(35, 407);
            this.label_eroare.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_eroare.Name = "label_eroare";
            this.label_eroare.Size = new System.Drawing.Size(254, 17);
            this.label_eroare.TabIndex = 8;
            this.label_eroare.Text = "Campurile marcate cu * sunt obligatorii.";
            // 
            // butt_reseteaza
            // 
            this.butt_reseteaza.Location = new System.Drawing.Point(180, 437);
            this.butt_reseteaza.Margin = new System.Windows.Forms.Padding(4);
            this.butt_reseteaza.Name = "butt_reseteaza";
            this.butt_reseteaza.Size = new System.Drawing.Size(99, 26);
            this.butt_reseteaza.TabIndex = 9;
            this.butt_reseteaza.Text = "Reseteaza";
            this.butt_reseteaza.UseVisualStyleBackColor = true;
            this.butt_reseteaza.Click += new System.EventHandler(this.butt_reseteaza_Click);
            // 
            // pb_img
            // 
            this.pb_img.Image = global::InterfataAdmin.Properties.Resources.user1;
            this.pb_img.InitialImage = null;
            this.pb_img.Location = new System.Drawing.Point(55, 20);
            this.pb_img.Name = "pb_img";
            this.pb_img.Size = new System.Drawing.Size(100, 85);
            this.pb_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_img.TabIndex = 3;
            this.pb_img.TabStop = false;
            // 
            // Creeaza_un_cont
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 486);
            this.Controls.Add(this.butt_reseteaza);
            this.Controls.Add(this.label_eroare);
            this.Controls.Add(this.gb_img);
            this.Controls.Add(this.butt_cancel);
            this.Controls.Add(this.butt_signin);
            this.Controls.Add(this.gb_det_pers);
            this.Controls.Add(this.gb_cont);
            this.Controls.Add(this.butt_iesire);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Creeaza_un_cont";
            this.Text = "Creeaza un cont";
            this.gb_cont.ResumeLayout(false);
            this.gb_cont.PerformLayout();
            this.gb_det_pers.ResumeLayout(false);
            this.gb_det_pers.PerformLayout();
            this.gb_img.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_prenume;
        private System.Windows.Forms.Button butt_signin;
        private System.Windows.Forms.Button butt_cancel;
        private System.Windows.Forms.TextBox input_pwd_conf;
        private System.Windows.Forms.TextBox input_pwd;
        private System.Windows.Forms.TextBox input_usr;
        private System.Windows.Forms.GroupBox gb_img;
        private System.Windows.Forms.Button butt_img;
        private System.Windows.Forms.TextBox input_prenume;
        private System.Windows.Forms.TextBox input_nume;
        private System.Windows.Forms.OpenFileDialog file_diag_img;
        private System.Windows.Forms.TextBox input_adresa;
        private System.Windows.Forms.TextBox input_telefon;
        private System.Windows.Forms.Label label_prefix;
        private System.Windows.Forms.Label label_eroare;
        private System.Windows.Forms.Button butt_reseteaza;
        private System.Windows.Forms.TextBox input_email;
        private System.Windows.Forms.Label label_email;
        private WindowsFormsApplication27.RoundPictureBox pb_img;
    }
}