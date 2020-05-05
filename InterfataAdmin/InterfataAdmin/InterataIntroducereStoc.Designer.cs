namespace InterfataAdmin
{
    partial class InterataIntroducereStoc
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
            this.buttonAdaugaStoc = new System.Windows.Forms.Button();
            this.buttonIesire = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAdaugaCarti = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAdaugaStoc
            // 
            this.buttonAdaugaStoc.Location = new System.Drawing.Point(12, 92);
            this.buttonAdaugaStoc.Name = "buttonAdaugaStoc";
            this.buttonAdaugaStoc.Size = new System.Drawing.Size(68, 25);
            this.buttonAdaugaStoc.TabIndex = 0;
            this.buttonAdaugaStoc.Text = "Adauga";
            this.buttonAdaugaStoc.UseVisualStyleBackColor = true;
            this.buttonAdaugaStoc.Click += new System.EventHandler(this.buttonAdaugaStoc_Click);
            // 
            // buttonIesire
            // 
            this.buttonIesire.Location = new System.Drawing.Point(156, 94);
            this.buttonIesire.Name = "buttonIesire";
            this.buttonIesire.Size = new System.Drawing.Size(75, 23);
            this.buttonIesire.TabIndex = 1;
            this.buttonIesire.Text = "Iesire";
            this.buttonIesire.UseVisualStyleBackColor = true;
            this.buttonIesire.Click += new System.EventHandler(this.buttonIesire_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Introduceti un numar de carti:";
            // 
            // textBoxAdaugaCarti
            // 
            this.textBoxAdaugaCarti.Location = new System.Drawing.Point(73, 56);
            this.textBoxAdaugaCarti.Name = "textBoxAdaugaCarti";
            this.textBoxAdaugaCarti.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdaugaCarti.TabIndex = 3;
            this.textBoxAdaugaCarti.Text = "1";
            this.textBoxAdaugaCarti.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InterataIntroducereStoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 126);
            this.Controls.Add(this.textBoxAdaugaCarti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonIesire);
            this.Controls.Add(this.buttonAdaugaStoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InterataIntroducereStoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InterataIntroducereStoc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdaugaStoc;
        private System.Windows.Forms.Button buttonIesire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAdaugaCarti;
    }
}