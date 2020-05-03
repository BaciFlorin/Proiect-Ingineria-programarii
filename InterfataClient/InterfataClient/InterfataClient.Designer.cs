namespace InterfataClient
{
    partial class InterfataUtilizator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfataUtilizator));
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelFilter = new System.Windows.Forms.Label();
            this.radioBttnGender = new System.Windows.Forms.RadioButton();
            this.radioBttnTitle = new System.Windows.Forms.RadioButton();
            this.radioBttnAuthor = new System.Windows.Forms.RadioButton();
            this.radioBttnNone = new System.Windows.Forms.RadioButton();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.richTextBoxDetails = new System.Windows.Forms.RichTextBox();
            this.tabControlBooks = new System.Windows.Forms.TabControl();
            this.CartiDisponibile = new System.Windows.Forms.TabPage();
            this.listBoxCartiDisponibile = new System.Windows.Forms.ListBox();
            this.CartiImprumutate = new System.Windows.Forms.TabPage();
            this.listBoxCartiImprumutate = new System.Windows.Forms.ListBox();
            this.buttonBorrow = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.roundPictureBoxUser = new InterfataClient.RoundPictureBox();
            this.toolTipLogOut = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxSearch.SuspendLayout();
            this.groupBoxDetails.SuspendLayout();
            this.tabControlBooks.SuspendLayout();
            this.CartiDisponibile.SuspendLayout();
            this.CartiImprumutate.SuspendLayout();
            this.groupBoxUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBoxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(784, 638);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(121, 41);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Iesire";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(71, 16);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(346, 22);
            this.textBoxSearch.TabIndex = 1;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(442, 16);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(99, 32);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Cautare";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilter.Location = new System.Drawing.Point(6, 60);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(52, 20);
            this.labelFilter.TabIndex = 3;
            this.labelFilter.Text = "Filtru:";
            // 
            // radioBttnGender
            // 
            this.radioBttnGender.AutoSize = true;
            this.radioBttnGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBttnGender.Location = new System.Drawing.Point(346, 61);
            this.radioBttnGender.Name = "radioBttnGender";
            this.radioBttnGender.Size = new System.Drawing.Size(57, 22);
            this.radioBttnGender.TabIndex = 3;
            this.radioBttnGender.Text = "Gen";
            this.radioBttnGender.UseVisualStyleBackColor = true;
            // 
            // radioBttnTitle
            // 
            this.radioBttnTitle.AutoSize = true;
            this.radioBttnTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBttnTitle.Location = new System.Drawing.Point(256, 61);
            this.radioBttnTitle.Name = "radioBttnTitle";
            this.radioBttnTitle.Size = new System.Drawing.Size(56, 22);
            this.radioBttnTitle.TabIndex = 2;
            this.radioBttnTitle.Text = "Titlu";
            this.radioBttnTitle.UseVisualStyleBackColor = true;
            // 
            // radioBttnAuthor
            // 
            this.radioBttnAuthor.AutoSize = true;
            this.radioBttnAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBttnAuthor.Location = new System.Drawing.Point(166, 60);
            this.radioBttnAuthor.Name = "radioBttnAuthor";
            this.radioBttnAuthor.Size = new System.Drawing.Size(64, 22);
            this.radioBttnAuthor.TabIndex = 1;
            this.radioBttnAuthor.Text = "Autor";
            this.radioBttnAuthor.UseVisualStyleBackColor = true;
            // 
            // radioBttnNone
            // 
            this.radioBttnNone.AutoSize = true;
            this.radioBttnNone.Checked = true;
            this.radioBttnNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBttnNone.Location = new System.Drawing.Point(71, 59);
            this.radioBttnNone.Name = "radioBttnNone";
            this.radioBttnNone.Size = new System.Drawing.Size(65, 22);
            this.radioBttnNone.TabIndex = 0;
            this.radioBttnNone.TabStop = true;
            this.radioBttnNone.Text = "None";
            this.radioBttnNone.UseVisualStyleBackColor = true;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.labelSearch);
            this.groupBoxSearch.Controls.Add(this.radioBttnGender);
            this.groupBoxSearch.Controls.Add(this.radioBttnTitle);
            this.groupBoxSearch.Controls.Add(this.radioBttnAuthor);
            this.groupBoxSearch.Controls.Add(this.radioBttnNone);
            this.groupBoxSearch.Controls.Add(this.textBoxSearch);
            this.groupBoxSearch.Controls.Add(this.buttonSearch);
            this.groupBoxSearch.Controls.Add(this.labelFilter);
            this.groupBoxSearch.Location = new System.Drawing.Point(22, 24);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(551, 102);
            this.groupBoxSearch.TabIndex = 4;
            this.groupBoxSearch.TabStop = false;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(6, 18);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(58, 20);
            this.labelSearch.TabIndex = 5;
            this.labelSearch.Text = "Cauta:";
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Controls.Add(this.richTextBoxDetails);
            this.groupBoxDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDetails.Location = new System.Drawing.Point(547, 166);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(401, 455);
            this.groupBoxDetails.TabIndex = 5;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Detalii Carte:";
            // 
            // richTextBoxDetails
            // 
            this.richTextBoxDetails.Location = new System.Drawing.Point(17, 24);
            this.richTextBoxDetails.Name = "richTextBoxDetails";
            this.richTextBoxDetails.Size = new System.Drawing.Size(367, 413);
            this.richTextBoxDetails.TabIndex = 0;
            this.richTextBoxDetails.Text = "";
            // 
            // tabControlBooks
            // 
            this.tabControlBooks.Controls.Add(this.CartiDisponibile);
            this.tabControlBooks.Controls.Add(this.CartiImprumutate);
            this.tabControlBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlBooks.Location = new System.Drawing.Point(32, 144);
            this.tabControlBooks.Name = "tabControlBooks";
            this.tabControlBooks.SelectedIndex = 0;
            this.tabControlBooks.Size = new System.Drawing.Size(417, 477);
            this.tabControlBooks.TabIndex = 6;
            this.tabControlBooks.SelectedIndexChanged += new System.EventHandler(this.tabControlBooks_SelectedIndexChanged);
            // 
            // CartiDisponibile
            // 
            this.CartiDisponibile.Controls.Add(this.listBoxCartiDisponibile);
            this.CartiDisponibile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartiDisponibile.Location = new System.Drawing.Point(4, 27);
            this.CartiDisponibile.Name = "CartiDisponibile";
            this.CartiDisponibile.Padding = new System.Windows.Forms.Padding(3);
            this.CartiDisponibile.Size = new System.Drawing.Size(409, 446);
            this.CartiDisponibile.TabIndex = 0;
            this.CartiDisponibile.Text = "Carti Disponibile";
            this.CartiDisponibile.UseVisualStyleBackColor = true;
            // 
            // listBoxCartiDisponibile
            // 
            this.listBoxCartiDisponibile.FormattingEnabled = true;
            this.listBoxCartiDisponibile.ItemHeight = 18;
            this.listBoxCartiDisponibile.Location = new System.Drawing.Point(-24, -34);
            this.listBoxCartiDisponibile.Name = "listBoxCartiDisponibile";
            this.listBoxCartiDisponibile.Size = new System.Drawing.Size(437, 490);
            this.listBoxCartiDisponibile.TabIndex = 0;
            this.listBoxCartiDisponibile.SelectedIndexChanged += new System.EventHandler(this.listBoxCartiDisponibile_SelectedIndexChanged);
            // 
            // CartiImprumutate
            // 
            this.CartiImprumutate.Controls.Add(this.listBoxCartiImprumutate);
            this.CartiImprumutate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartiImprumutate.Location = new System.Drawing.Point(4, 27);
            this.CartiImprumutate.Name = "CartiImprumutate";
            this.CartiImprumutate.Padding = new System.Windows.Forms.Padding(3);
            this.CartiImprumutate.Size = new System.Drawing.Size(409, 446);
            this.CartiImprumutate.TabIndex = 1;
            this.CartiImprumutate.Text = "Carti Imprumutate";
            this.CartiImprumutate.UseVisualStyleBackColor = true;
            // 
            // listBoxCartiImprumutate
            // 
            this.listBoxCartiImprumutate.FormattingEnabled = true;
            this.listBoxCartiImprumutate.ItemHeight = 18;
            this.listBoxCartiImprumutate.Location = new System.Drawing.Point(-4, -15);
            this.listBoxCartiImprumutate.Name = "listBoxCartiImprumutate";
            this.listBoxCartiImprumutate.Size = new System.Drawing.Size(427, 472);
            this.listBoxCartiImprumutate.TabIndex = 0;
            this.listBoxCartiImprumutate.SelectedIndexChanged += new System.EventHandler(this.listBoxCartiImprumutate_SelectedIndexChanged);
            // 
            // buttonBorrow
            // 
            this.buttonBorrow.Location = new System.Drawing.Point(32, 639);
            this.buttonBorrow.Name = "buttonBorrow";
            this.buttonBorrow.Size = new System.Drawing.Size(126, 41);
            this.buttonBorrow.TabIndex = 8;
            this.buttonBorrow.Text = "Imprumuta";
            this.buttonBorrow.UseVisualStyleBackColor = true;
            this.buttonBorrow.Click += new System.EventHandler(this.buttonBorrow_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Enabled = false;
            this.buttonReturn.Location = new System.Drawing.Point(326, 641);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(119, 41);
            this.buttonReturn.TabIndex = 9;
            this.buttonReturn.Text = "Restituie";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.Controls.Add(this.textBoxUsername);
            this.groupBoxUser.Controls.Add(this.buttonLogOut);
            this.groupBoxUser.Controls.Add(this.roundPictureBoxUser);
            this.groupBoxUser.Location = new System.Drawing.Point(629, 24);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Size = new System.Drawing.Size(285, 102);
            this.groupBoxUser.TabIndex = 7;
            this.groupBoxUser.TabStop = false;
            this.groupBoxUser.Text = "User";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(75, 39);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.ReadOnly = true;
            this.textBoxUsername.Size = new System.Drawing.Size(151, 22);
            this.textBoxUsername.TabIndex = 2;
            this.textBoxUsername.Text = "Username";
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Image = ((System.Drawing.Image)(resources.GetObject("buttonLogOut.Image")));
            this.buttonLogOut.Location = new System.Drawing.Point(232, 31);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(47, 39);
            this.buttonLogOut.TabIndex = 1;
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // roundPictureBoxUser
            // 
            this.roundPictureBoxUser.Image = ((System.Drawing.Image)(resources.GetObject("roundPictureBoxUser.Image")));
            this.roundPictureBoxUser.Location = new System.Drawing.Point(7, 22);
            this.roundPictureBoxUser.Name = "roundPictureBoxUser";
            this.roundPictureBoxUser.Size = new System.Drawing.Size(62, 60);
            this.roundPictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundPictureBoxUser.TabIndex = 0;
            this.roundPictureBoxUser.TabStop = false;
            // 
            // toolTipLogOut
            // 
            this.toolTipLogOut.Tag = "LogOut";
            // 
            // InterfataUtilizator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 707);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonBorrow);
            this.Controls.Add(this.groupBoxUser);
            this.Controls.Add(this.tabControlBooks);
            this.Controls.Add(this.groupBoxDetails);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.buttonExit);
            this.Name = "InterfataUtilizator";
            this.Text = "Interfata Utilizator";
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.groupBoxDetails.ResumeLayout(false);
            this.tabControlBooks.ResumeLayout(false);
            this.CartiDisponibile.ResumeLayout(false);
            this.CartiImprumutate.ResumeLayout(false);
            this.groupBoxUser.ResumeLayout(false);
            this.groupBoxUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBoxUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.RadioButton radioBttnGender;
        private System.Windows.Forms.RadioButton radioBttnTitle;
        private System.Windows.Forms.RadioButton radioBttnAuthor;
        private System.Windows.Forms.RadioButton radioBttnNone;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.TabControl tabControlBooks;
        private System.Windows.Forms.TabPage CartiDisponibile;
        private System.Windows.Forms.TabPage CartiImprumutate;
        private System.Windows.Forms.Button buttonBorrow;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.GroupBox groupBoxUser;
        private RoundPictureBox roundPictureBoxUser;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.ToolTip toolTipLogOut;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.ListBox listBoxCartiDisponibile;
        private System.Windows.Forms.ListBox listBoxCartiImprumutate;
        private System.Windows.Forms.RichTextBox richTextBoxDetails;
    }
}

