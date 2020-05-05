namespace Inregistrare
{
    partial class Reseteaza_parola
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
            this.butt_reset = new System.Windows.Forms.Button();
            this.butt_cancel = new System.Windows.Forms.Button();
            this.label_usr = new System.Windows.Forms.Label();
            this.label_new_pwd = new System.Windows.Forms.Label();
            this.label_new_pwd_conf = new System.Windows.Forms.Label();
            this.input_usr = new System.Windows.Forms.TextBox();
            this.input_new_pwd = new System.Windows.Forms.TextBox();
            this.input_new_pwd_conf = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // butt_reset
            // 
            this.butt_reset.Location = new System.Drawing.Point(47, 134);
            this.butt_reset.Name = "butt_reset";
            this.butt_reset.Size = new System.Drawing.Size(111, 23);
            this.butt_reset.TabIndex = 0;
            this.butt_reset.Text = "Reseteaza parola";
            this.butt_reset.UseVisualStyleBackColor = true;
            this.butt_reset.Click += new System.EventHandler(this.butt_reset_Click);
            // 
            // butt_cancel
            // 
            this.butt_cancel.Location = new System.Drawing.Point(175, 134);
            this.butt_cancel.Name = "butt_cancel";
            this.butt_cancel.Size = new System.Drawing.Size(80, 23);
            this.butt_cancel.TabIndex = 1;
            this.butt_cancel.Text = "Renunta";
            this.butt_cancel.UseVisualStyleBackColor = true;
            this.butt_cancel.Click += new System.EventHandler(this.butt_cancel_Click);
            // 
            // label_usr
            // 
            this.label_usr.AutoSize = true;
            this.label_usr.Location = new System.Drawing.Point(32, 30);
            this.label_usr.Name = "label_usr";
            this.label_usr.Size = new System.Drawing.Size(79, 13);
            this.label_usr.TabIndex = 2;
            this.label_usr.Text = "Nume utilizator:";
            // 
            // label_new_pwd
            // 
            this.label_new_pwd.AutoSize = true;
            this.label_new_pwd.Location = new System.Drawing.Point(32, 63);
            this.label_new_pwd.Name = "label_new_pwd";
            this.label_new_pwd.Size = new System.Drawing.Size(67, 13);
            this.label_new_pwd.TabIndex = 3;
            this.label_new_pwd.Text = "Parola noua:";
            // 
            // label_new_pwd_conf
            // 
            this.label_new_pwd_conf.AutoSize = true;
            this.label_new_pwd_conf.Location = new System.Drawing.Point(32, 95);
            this.label_new_pwd_conf.Name = "label_new_pwd_conf";
            this.label_new_pwd_conf.Size = new System.Drawing.Size(83, 13);
            this.label_new_pwd_conf.TabIndex = 4;
            this.label_new_pwd_conf.Text = "Confirma parola:";
            // 
            // input_usr
            // 
            this.input_usr.Location = new System.Drawing.Point(135, 27);
            this.input_usr.MaxLength = 256;
            this.input_usr.Name = "input_usr";
            this.input_usr.Size = new System.Drawing.Size(130, 20);
            this.input_usr.TabIndex = 5;
            // 
            // input_new_pwd
            // 
            this.input_new_pwd.Location = new System.Drawing.Point(135, 60);
            this.input_new_pwd.MaxLength = 64;
            this.input_new_pwd.Name = "input_new_pwd";
            this.input_new_pwd.PasswordChar = '♥';
            this.input_new_pwd.Size = new System.Drawing.Size(130, 20);
            this.input_new_pwd.TabIndex = 6;
            // 
            // input_new_pwd_conf
            // 
            this.input_new_pwd_conf.Location = new System.Drawing.Point(135, 92);
            this.input_new_pwd_conf.MaxLength = 64;
            this.input_new_pwd_conf.Name = "input_new_pwd_conf";
            this.input_new_pwd_conf.PasswordChar = '♥';
            this.input_new_pwd_conf.Size = new System.Drawing.Size(130, 20);
            this.input_new_pwd_conf.TabIndex = 7;
            // 
            // Reseteaza_parola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 179);
            this.Controls.Add(this.input_new_pwd_conf);
            this.Controls.Add(this.input_new_pwd);
            this.Controls.Add(this.input_usr);
            this.Controls.Add(this.label_new_pwd_conf);
            this.Controls.Add(this.label_new_pwd);
            this.Controls.Add(this.label_usr);
            this.Controls.Add(this.butt_cancel);
            this.Controls.Add(this.butt_reset);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Reseteaza_parola";
            this.Text = "Reseteaza parola";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butt_reset;
        private System.Windows.Forms.Button butt_cancel;
        private System.Windows.Forms.Label label_usr;
        private System.Windows.Forms.Label label_new_pwd;
        private System.Windows.Forms.Label label_new_pwd_conf;
        private System.Windows.Forms.TextBox input_usr;
        private System.Windows.Forms.TextBox input_new_pwd;
        private System.Windows.Forms.TextBox input_new_pwd_conf;
    }
}