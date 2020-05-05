namespace Inregistrare
{
    partial class Autentificare
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
            this.label_usr = new System.Windows.Forms.Label();
            this.butt_login = new System.Windows.Forms.Button();
            this.label_pwd = new System.Windows.Forms.Label();
            this.input_usr = new System.Windows.Forms.TextBox();
            this.input_pwd = new System.Windows.Forms.TextBox();
            this.link_reset = new System.Windows.Forms.LinkLabel();
            this.link_cont_nou = new System.Windows.Forms.LinkLabel();
            this.label_cont_nou = new System.Windows.Forms.Label();
            this.butt_iesire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_usr
            // 
            this.label_usr.AutoSize = true;
            this.label_usr.Location = new System.Drawing.Point(38, 25);
            this.label_usr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_usr.Name = "label_usr";
            this.label_usr.Size = new System.Drawing.Size(79, 13);
            this.label_usr.TabIndex = 0;
            this.label_usr.Text = "Nume utilizator:";
            // 
            // butt_login
            // 
            this.butt_login.Location = new System.Drawing.Point(23, 128);
            this.butt_login.Margin = new System.Windows.Forms.Padding(2);
            this.butt_login.Name = "butt_login";
            this.butt_login.Size = new System.Drawing.Size(83, 22);
            this.butt_login.TabIndex = 1;
            this.butt_login.Text = "Autentifica-te";
            this.butt_login.UseVisualStyleBackColor = true;
            this.butt_login.Click += new System.EventHandler(this.but_login_Click);
            // 
            // label_pwd
            // 
            this.label_pwd.AutoSize = true;
            this.label_pwd.Location = new System.Drawing.Point(38, 60);
            this.label_pwd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_pwd.Name = "label_pwd";
            this.label_pwd.Size = new System.Drawing.Size(40, 13);
            this.label_pwd.TabIndex = 2;
            this.label_pwd.Text = "Parola:";
            // 
            // input_usr
            // 
            this.input_usr.Location = new System.Drawing.Point(124, 22);
            this.input_usr.Margin = new System.Windows.Forms.Padding(2);
            this.input_usr.MaxLength = 256;
            this.input_usr.Name = "input_usr";
            this.input_usr.Size = new System.Drawing.Size(137, 20);
            this.input_usr.TabIndex = 3;
            // 
            // input_pwd
            // 
            this.input_pwd.Location = new System.Drawing.Point(124, 57);
            this.input_pwd.Margin = new System.Windows.Forms.Padding(2);
            this.input_pwd.MaxLength = 64;
            this.input_pwd.Name = "input_pwd";
            this.input_pwd.PasswordChar = '♥';
            this.input_pwd.Size = new System.Drawing.Size(137, 20);
            this.input_pwd.TabIndex = 4;
            // 
            // link_reset
            // 
            this.link_reset.AutoSize = true;
            this.link_reset.Location = new System.Drawing.Point(113, 92);
            this.link_reset.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.link_reset.Name = "link_reset";
            this.link_reset.Size = new System.Drawing.Size(77, 13);
            this.link_reset.TabIndex = 5;
            this.link_reset.TabStop = true;
            this.link_reset.Text = "Am uitat parola";
            this.link_reset.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_reset_LinkClicked);
            // 
            // link_cont_nou
            // 
            this.link_cont_nou.AutoSize = true;
            this.link_cont_nou.Location = new System.Drawing.Point(132, 133);
            this.link_cont_nou.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.link_cont_nou.Name = "link_cont_nou";
            this.link_cont_nou.Size = new System.Drawing.Size(81, 13);
            this.link_cont_nou.TabIndex = 6;
            this.link_cont_nou.TabStop = true;
            this.link_cont_nou.Text = "creeza un cont.";
            this.link_cont_nou.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_cont_nou_LinkClicked);
            // 
            // label_cont_nou
            // 
            this.label_cont_nou.AutoSize = true;
            this.label_cont_nou.Location = new System.Drawing.Point(110, 133);
            this.label_cont_nou.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_cont_nou.Name = "label_cont_nou";
            this.label_cont_nou.Size = new System.Drawing.Size(24, 13);
            this.label_cont_nou.TabIndex = 7;
            this.label_cont_nou.Text = "sau";
            // 
            // butt_iesire
            // 
            this.butt_iesire.Location = new System.Drawing.Point(223, 128);
            this.butt_iesire.Margin = new System.Windows.Forms.Padding(2);
            this.butt_iesire.Name = "butt_iesire";
            this.butt_iesire.Size = new System.Drawing.Size(64, 22);
            this.butt_iesire.TabIndex = 8;
            this.butt_iesire.Text = "Valea! :)";
            this.butt_iesire.UseVisualStyleBackColor = true;
            this.butt_iesire.Click += new System.EventHandler(this.butt_iesire_Click);
            // 
            // Autentificare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 167);
            this.Controls.Add(this.butt_iesire);
            this.Controls.Add(this.label_cont_nou);
            this.Controls.Add(this.link_cont_nou);
            this.Controls.Add(this.link_reset);
            this.Controls.Add(this.input_pwd);
            this.Controls.Add(this.input_usr);
            this.Controls.Add(this.label_pwd);
            this.Controls.Add(this.butt_login);
            this.Controls.Add(this.label_usr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Autentificare";
            this.Text = "Autentificare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_usr;
        private System.Windows.Forms.Button butt_login;
        private System.Windows.Forms.Label label_pwd;
        private System.Windows.Forms.TextBox input_usr;
        private System.Windows.Forms.TextBox input_pwd;
        private System.Windows.Forms.LinkLabel link_reset;
        private System.Windows.Forms.LinkLabel link_cont_nou;
        private System.Windows.Forms.Label label_cont_nou;
        private System.Windows.Forms.Button butt_iesire;
    }
}

