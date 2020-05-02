namespace InterfataAdmin
{
    partial class InterfataBibliotecar
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
            this.labelAdministrator = new System.Windows.Forms.Label();
            this.groupBoxProfil = new System.Windows.Forms.GroupBox();
            this.roundPictureBoxPozaProfil = new WindowsFormsApplication27.RoundPictureBox();
            this.groupBoxCautare = new System.Windows.Forms.GroupBox();
            this.radioButtonFiltruTitlu = new System.Windows.Forms.RadioButton();
            this.radioButtonFiltruAutor = new System.Windows.Forms.RadioButton();
            this.radioButtonFiltruNone = new System.Windows.Forms.RadioButton();
            this.radioButtonFiltruGen = new System.Windows.Forms.RadioButton();
            this.radioButtonFiltruUser = new System.Windows.Forms.RadioButton();
            this.buttonFiltruCauta = new System.Windows.Forms.Button();
            this.labelFiltru = new System.Windows.Forms.Label();
            this.textBoxCauta = new System.Windows.Forms.TextBox();
            this.labelCauta = new System.Windows.Forms.Label();
            this.tabControlInfo = new System.Windows.Forms.TabControl();
            this.tabPageCarti = new System.Windows.Forms.TabPage();
            this.listBoxCarti = new System.Windows.Forms.ListBox();
            this.tabPageImprumuturi = new System.Windows.Forms.TabPage();
            this.listBoxImprumuturi = new System.Windows.Forms.ListBox();
            this.tabPageUtilizatori = new System.Windows.Forms.TabPage();
            this.listBoxUtilizatori = new System.Windows.Forms.ListBox();
            this.tabPageCereri = new System.Windows.Forms.TabPage();
            this.listBoxCereri = new System.Windows.Forms.ListBox();
            this.groupBoxInformatii = new System.Windows.Forms.GroupBox();
            this.richTextBoxInformatii = new System.Windows.Forms.RichTextBox();
            this.groupBoxCarte = new System.Windows.Forms.GroupBox();
            this.buttonCarteStoc = new System.Windows.Forms.Button();
            this.buttonCarteStergere = new System.Windows.Forms.Button();
            this.buttonCarteAdauga = new System.Windows.Forms.Button();
            this.groupBoxCerere = new System.Windows.Forms.GroupBox();
            this.buttonCerereRespinge = new System.Windows.Forms.Button();
            this.buttonCerereAccepta = new System.Windows.Forms.Button();
            this.buttonIesire = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.groupBoxProfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBoxPozaProfil)).BeginInit();
            this.groupBoxCautare.SuspendLayout();
            this.tabControlInfo.SuspendLayout();
            this.tabPageCarti.SuspendLayout();
            this.tabPageImprumuturi.SuspendLayout();
            this.tabPageUtilizatori.SuspendLayout();
            this.tabPageCereri.SuspendLayout();
            this.groupBoxInformatii.SuspendLayout();
            this.groupBoxCarte.SuspendLayout();
            this.groupBoxCerere.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAdministrator
            // 
            this.labelAdministrator.AutoSize = true;
            this.labelAdministrator.Location = new System.Drawing.Point(64, 30);
            this.labelAdministrator.Name = "labelAdministrator";
            this.labelAdministrator.Size = new System.Drawing.Size(67, 13);
            this.labelAdministrator.TabIndex = 1;
            this.labelAdministrator.Text = "Administrator";
            // 
            // groupBoxProfil
            // 
            this.groupBoxProfil.Controls.Add(this.roundPictureBoxPozaProfil);
            this.groupBoxProfil.Controls.Add(this.labelAdministrator);
            this.groupBoxProfil.Location = new System.Drawing.Point(481, 12);
            this.groupBoxProfil.Name = "groupBoxProfil";
            this.groupBoxProfil.Size = new System.Drawing.Size(141, 71);
            this.groupBoxProfil.TabIndex = 2;
            this.groupBoxProfil.TabStop = false;
            // 
            // roundPictureBoxPozaProfil
            // 
            this.roundPictureBoxPozaProfil.Image = global::InterfataAdmin.Properties.Resources._default;
            this.roundPictureBoxPozaProfil.Location = new System.Drawing.Point(6, 15);
            this.roundPictureBoxPozaProfil.Name = "roundPictureBoxPozaProfil";
            this.roundPictureBoxPozaProfil.Size = new System.Drawing.Size(52, 50);
            this.roundPictureBoxPozaProfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.roundPictureBoxPozaProfil.TabIndex = 3;
            this.roundPictureBoxPozaProfil.TabStop = false;
            // 
            // groupBoxCautare
            // 
            this.groupBoxCautare.Controls.Add(this.radioButtonFiltruTitlu);
            this.groupBoxCautare.Controls.Add(this.radioButtonFiltruAutor);
            this.groupBoxCautare.Controls.Add(this.radioButtonFiltruNone);
            this.groupBoxCautare.Controls.Add(this.radioButtonFiltruGen);
            this.groupBoxCautare.Controls.Add(this.radioButtonFiltruUser);
            this.groupBoxCautare.Controls.Add(this.buttonFiltruCauta);
            this.groupBoxCautare.Controls.Add(this.labelFiltru);
            this.groupBoxCautare.Controls.Add(this.textBoxCauta);
            this.groupBoxCautare.Controls.Add(this.labelCauta);
            this.groupBoxCautare.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCautare.Name = "groupBoxCautare";
            this.groupBoxCautare.Size = new System.Drawing.Size(463, 71);
            this.groupBoxCautare.TabIndex = 3;
            this.groupBoxCautare.TabStop = false;
            // 
            // radioButtonFiltruTitlu
            // 
            this.radioButtonFiltruTitlu.AutoSize = true;
            this.radioButtonFiltruTitlu.Location = new System.Drawing.Point(173, 41);
            this.radioButtonFiltruTitlu.Name = "radioButtonFiltruTitlu";
            this.radioButtonFiltruTitlu.Size = new System.Drawing.Size(45, 17);
            this.radioButtonFiltruTitlu.TabIndex = 4;
            this.radioButtonFiltruTitlu.TabStop = true;
            this.radioButtonFiltruTitlu.Text = "Titlu";
            this.radioButtonFiltruTitlu.UseVisualStyleBackColor = true;
            // 
            // radioButtonFiltruAutor
            // 
            this.radioButtonFiltruAutor.AutoSize = true;
            this.radioButtonFiltruAutor.Location = new System.Drawing.Point(117, 41);
            this.radioButtonFiltruAutor.Name = "radioButtonFiltruAutor";
            this.radioButtonFiltruAutor.Size = new System.Drawing.Size(50, 17);
            this.radioButtonFiltruAutor.TabIndex = 3;
            this.radioButtonFiltruAutor.TabStop = true;
            this.radioButtonFiltruAutor.Text = "Autor";
            this.radioButtonFiltruAutor.UseVisualStyleBackColor = true;
            // 
            // radioButtonFiltruNone
            // 
            this.radioButtonFiltruNone.AutoSize = true;
            this.radioButtonFiltruNone.Location = new System.Drawing.Point(60, 41);
            this.radioButtonFiltruNone.Name = "radioButtonFiltruNone";
            this.radioButtonFiltruNone.Size = new System.Drawing.Size(51, 17);
            this.radioButtonFiltruNone.TabIndex = 2;
            this.radioButtonFiltruNone.TabStop = true;
            this.radioButtonFiltruNone.Text = "None";
            this.radioButtonFiltruNone.UseVisualStyleBackColor = true;
            // 
            // radioButtonFiltruGen
            // 
            this.radioButtonFiltruGen.AutoSize = true;
            this.radioButtonFiltruGen.Location = new System.Drawing.Point(277, 41);
            this.radioButtonFiltruGen.Name = "radioButtonFiltruGen";
            this.radioButtonFiltruGen.Size = new System.Drawing.Size(45, 17);
            this.radioButtonFiltruGen.TabIndex = 5;
            this.radioButtonFiltruGen.TabStop = true;
            this.radioButtonFiltruGen.Text = "Gen";
            this.radioButtonFiltruGen.UseVisualStyleBackColor = true;
            // 
            // radioButtonFiltruUser
            // 
            this.radioButtonFiltruUser.AutoSize = true;
            this.radioButtonFiltruUser.Location = new System.Drawing.Point(224, 41);
            this.radioButtonFiltruUser.Name = "radioButtonFiltruUser";
            this.radioButtonFiltruUser.Size = new System.Drawing.Size(47, 17);
            this.radioButtonFiltruUser.TabIndex = 6;
            this.radioButtonFiltruUser.TabStop = true;
            this.radioButtonFiltruUser.Text = "User";
            this.radioButtonFiltruUser.UseVisualStyleBackColor = true;
            // 
            // buttonFiltruCauta
            // 
            this.buttonFiltruCauta.Location = new System.Drawing.Point(366, 13);
            this.buttonFiltruCauta.Name = "buttonFiltruCauta";
            this.buttonFiltruCauta.Size = new System.Drawing.Size(75, 23);
            this.buttonFiltruCauta.TabIndex = 5;
            this.buttonFiltruCauta.Text = "Cauta";
            this.buttonFiltruCauta.UseVisualStyleBackColor = true;
            this.buttonFiltruCauta.Click += new System.EventHandler(this.buttonFiltruCauta_Click);
            // 
            // labelFiltru
            // 
            this.labelFiltru.AutoSize = true;
            this.labelFiltru.Location = new System.Drawing.Point(22, 43);
            this.labelFiltru.Name = "labelFiltru";
            this.labelFiltru.Size = new System.Drawing.Size(32, 13);
            this.labelFiltru.TabIndex = 3;
            this.labelFiltru.Text = "Filtru:";
            // 
            // textBoxCauta
            // 
            this.textBoxCauta.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBoxCauta.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxCauta.Location = new System.Drawing.Point(60, 15);
            this.textBoxCauta.Name = "textBoxCauta";
            this.textBoxCauta.Size = new System.Drawing.Size(285, 20);
            this.textBoxCauta.TabIndex = 1;
            this.textBoxCauta.TabStop = false;
            this.textBoxCauta.Text = "Autor/Titlu/Gen/User";
            this.textBoxCauta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.text_box_cautare_MouseClick);
            this.textBoxCauta.Leave += new System.EventHandler(this.text_box_cautare_Leave);
            // 
            // labelCauta
            // 
            this.labelCauta.AutoSize = true;
            this.labelCauta.Location = new System.Drawing.Point(16, 18);
            this.labelCauta.Name = "labelCauta";
            this.labelCauta.Size = new System.Drawing.Size(38, 13);
            this.labelCauta.TabIndex = 0;
            this.labelCauta.Text = "Cauta:";
            // 
            // tabControlInfo
            // 
            this.tabControlInfo.Controls.Add(this.tabPageCarti);
            this.tabControlInfo.Controls.Add(this.tabPageImprumuturi);
            this.tabControlInfo.Controls.Add(this.tabPageUtilizatori);
            this.tabControlInfo.Controls.Add(this.tabPageCereri);
            this.tabControlInfo.Location = new System.Drawing.Point(12, 89);
            this.tabControlInfo.Name = "tabControlInfo";
            this.tabControlInfo.SelectedIndex = 0;
            this.tabControlInfo.Size = new System.Drawing.Size(310, 330);
            this.tabControlInfo.TabIndex = 4;
            this.tabControlInfo.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageCarti
            // 
            this.tabPageCarti.Controls.Add(this.listBoxCarti);
            this.tabPageCarti.Location = new System.Drawing.Point(4, 22);
            this.tabPageCarti.Name = "tabPageCarti";
            this.tabPageCarti.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCarti.Size = new System.Drawing.Size(302, 304);
            this.tabPageCarti.TabIndex = 0;
            this.tabPageCarti.Text = "Carti";
            this.tabPageCarti.UseVisualStyleBackColor = true;
            // 
            // listBoxCarti
            // 
            this.listBoxCarti.FormattingEnabled = true;
            this.listBoxCarti.Items.AddRange(new object[] {
            "*carti*"});
            this.listBoxCarti.Location = new System.Drawing.Point(0, 0);
            this.listBoxCarti.Margin = new System.Windows.Forms.Padding(0);
            this.listBoxCarti.Name = "listBoxCarti";
            this.listBoxCarti.Size = new System.Drawing.Size(302, 303);
            this.listBoxCarti.TabIndex = 0;
            this.listBoxCarti.SelectedIndexChanged += new System.EventHandler(this.listBoxCarti_SelectedIndexChanged);
            // 
            // tabPageImprumuturi
            // 
            this.tabPageImprumuturi.Controls.Add(this.listBoxImprumuturi);
            this.tabPageImprumuturi.Location = new System.Drawing.Point(4, 22);
            this.tabPageImprumuturi.Name = "tabPageImprumuturi";
            this.tabPageImprumuturi.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageImprumuturi.Size = new System.Drawing.Size(302, 304);
            this.tabPageImprumuturi.TabIndex = 1;
            this.tabPageImprumuturi.Text = "Imprumuturi";
            this.tabPageImprumuturi.UseVisualStyleBackColor = true;
            // 
            // listBoxImprumuturi
            // 
            this.listBoxImprumuturi.FormattingEnabled = true;
            this.listBoxImprumuturi.Items.AddRange(new object[] {
            "*imprumuturi*"});
            this.listBoxImprumuturi.Location = new System.Drawing.Point(0, 0);
            this.listBoxImprumuturi.Name = "listBoxImprumuturi";
            this.listBoxImprumuturi.Size = new System.Drawing.Size(302, 303);
            this.listBoxImprumuturi.TabIndex = 0;
            this.listBoxImprumuturi.SelectedIndexChanged += new System.EventHandler(this.listBoxImprumuturi_SelectedIndexChanged);
            // 
            // tabPageUtilizatori
            // 
            this.tabPageUtilizatori.Controls.Add(this.listBoxUtilizatori);
            this.tabPageUtilizatori.Location = new System.Drawing.Point(4, 22);
            this.tabPageUtilizatori.Name = "tabPageUtilizatori";
            this.tabPageUtilizatori.Size = new System.Drawing.Size(302, 304);
            this.tabPageUtilizatori.TabIndex = 2;
            this.tabPageUtilizatori.Text = "Utilizatori";
            this.tabPageUtilizatori.UseVisualStyleBackColor = true;
            // 
            // listBoxUtilizatori
            // 
            this.listBoxUtilizatori.FormattingEnabled = true;
            this.listBoxUtilizatori.Items.AddRange(new object[] {
            "*utlizatori*"});
            this.listBoxUtilizatori.Location = new System.Drawing.Point(0, 0);
            this.listBoxUtilizatori.Name = "listBoxUtilizatori";
            this.listBoxUtilizatori.Size = new System.Drawing.Size(302, 303);
            this.listBoxUtilizatori.TabIndex = 0;
            this.listBoxUtilizatori.SelectedIndexChanged += new System.EventHandler(this.listBoxUtilizatori_SelectedIndexChanged);
            // 
            // tabPageCereri
            // 
            this.tabPageCereri.Controls.Add(this.listBoxCereri);
            this.tabPageCereri.Location = new System.Drawing.Point(4, 22);
            this.tabPageCereri.Name = "tabPageCereri";
            this.tabPageCereri.Size = new System.Drawing.Size(302, 304);
            this.tabPageCereri.TabIndex = 3;
            this.tabPageCereri.Text = "Cereri";
            this.tabPageCereri.UseVisualStyleBackColor = true;
            // 
            // listBoxCereri
            // 
            this.listBoxCereri.FormattingEnabled = true;
            this.listBoxCereri.Items.AddRange(new object[] {
            "*cereri*"});
            this.listBoxCereri.Location = new System.Drawing.Point(0, 0);
            this.listBoxCereri.Name = "listBoxCereri";
            this.listBoxCereri.Size = new System.Drawing.Size(302, 303);
            this.listBoxCereri.TabIndex = 0;
            this.listBoxCereri.SelectedIndexChanged += new System.EventHandler(this.listBoxCereri_SelectedIndexChanged);
            // 
            // groupBoxInformatii
            // 
            this.groupBoxInformatii.Controls.Add(this.richTextBoxInformatii);
            this.groupBoxInformatii.Location = new System.Drawing.Point(328, 89);
            this.groupBoxInformatii.Name = "groupBoxInformatii";
            this.groupBoxInformatii.Size = new System.Drawing.Size(294, 330);
            this.groupBoxInformatii.TabIndex = 5;
            this.groupBoxInformatii.TabStop = false;
            this.groupBoxInformatii.Text = "Informatii:";
            // 
            // richTextBoxInformatii
            // 
            this.richTextBoxInformatii.Enabled = false;
            this.richTextBoxInformatii.Location = new System.Drawing.Point(6, 19);
            this.richTextBoxInformatii.Name = "richTextBoxInformatii";
            this.richTextBoxInformatii.ReadOnly = true;
            this.richTextBoxInformatii.Size = new System.Drawing.Size(278, 305);
            this.richTextBoxInformatii.TabIndex = 0;
            this.richTextBoxInformatii.Text = "";
            // 
            // groupBoxCarte
            // 
            this.groupBoxCarte.Controls.Add(this.buttonCarteStoc);
            this.groupBoxCarte.Controls.Add(this.buttonCarteStergere);
            this.groupBoxCarte.Controls.Add(this.buttonCarteAdauga);
            this.groupBoxCarte.Location = new System.Drawing.Point(16, 425);
            this.groupBoxCarte.Name = "groupBoxCarte";
            this.groupBoxCarte.Size = new System.Drawing.Size(254, 55);
            this.groupBoxCarte.TabIndex = 6;
            this.groupBoxCarte.TabStop = false;
            this.groupBoxCarte.Text = "Carte";
            // 
            // buttonCarteStoc
            // 
            this.buttonCarteStoc.Location = new System.Drawing.Point(170, 18);
            this.buttonCarteStoc.Name = "buttonCarteStoc";
            this.buttonCarteStoc.Size = new System.Drawing.Size(75, 23);
            this.buttonCarteStoc.TabIndex = 2;
            this.buttonCarteStoc.Text = "Adauga stoc";
            this.buttonCarteStoc.UseVisualStyleBackColor = true;
            this.buttonCarteStoc.Click += new System.EventHandler(this.buttonCarteStoc_Click);
            // 
            // buttonCarteStergere
            // 
            this.buttonCarteStergere.Location = new System.Drawing.Point(88, 18);
            this.buttonCarteStergere.Name = "buttonCarteStergere";
            this.buttonCarteStergere.Size = new System.Drawing.Size(75, 23);
            this.buttonCarteStergere.TabIndex = 1;
            this.buttonCarteStergere.Text = "Sterge";
            this.buttonCarteStergere.UseVisualStyleBackColor = true;
            this.buttonCarteStergere.Click += new System.EventHandler(this.buttonCarteSterge_Click);
            // 
            // buttonCarteAdauga
            // 
            this.buttonCarteAdauga.Location = new System.Drawing.Point(6, 19);
            this.buttonCarteAdauga.Name = "buttonCarteAdauga";
            this.buttonCarteAdauga.Size = new System.Drawing.Size(75, 23);
            this.buttonCarteAdauga.TabIndex = 0;
            this.buttonCarteAdauga.Text = "Adauga";
            this.buttonCarteAdauga.UseVisualStyleBackColor = true;
            this.buttonCarteAdauga.Click += new System.EventHandler(this.buttonCarteAdauga_Click);
            // 
            // groupBoxCerere
            // 
            this.groupBoxCerere.Controls.Add(this.buttonCerereRespinge);
            this.groupBoxCerere.Controls.Add(this.buttonCerereAccepta);
            this.groupBoxCerere.Enabled = false;
            this.groupBoxCerere.Location = new System.Drawing.Point(276, 425);
            this.groupBoxCerere.Name = "groupBoxCerere";
            this.groupBoxCerere.Size = new System.Drawing.Size(186, 55);
            this.groupBoxCerere.TabIndex = 7;
            this.groupBoxCerere.TabStop = false;
            this.groupBoxCerere.Text = "Cerere";
            // 
            // buttonCerereRespinge
            // 
            this.buttonCerereRespinge.Location = new System.Drawing.Point(105, 18);
            this.buttonCerereRespinge.Name = "buttonCerereRespinge";
            this.buttonCerereRespinge.Size = new System.Drawing.Size(75, 23);
            this.buttonCerereRespinge.TabIndex = 1;
            this.buttonCerereRespinge.Text = "Respinge";
            this.buttonCerereRespinge.UseVisualStyleBackColor = true;
            this.buttonCerereRespinge.Click += new System.EventHandler(this.buttonCerereRespinge_Click);
            // 
            // buttonCerereAccepta
            // 
            this.buttonCerereAccepta.Location = new System.Drawing.Point(7, 18);
            this.buttonCerereAccepta.Name = "buttonCerereAccepta";
            this.buttonCerereAccepta.Size = new System.Drawing.Size(75, 23);
            this.buttonCerereAccepta.TabIndex = 0;
            this.buttonCerereAccepta.Text = "Accepta";
            this.buttonCerereAccepta.UseVisualStyleBackColor = true;
            this.buttonCerereAccepta.Click += new System.EventHandler(this.buttonCerereAccepta_Click);
            // 
            // buttonIesire
            // 
            this.buttonIesire.Location = new System.Drawing.Point(558, 443);
            this.buttonIesire.Name = "buttonIesire";
            this.buttonIesire.Size = new System.Drawing.Size(75, 23);
            this.buttonIesire.TabIndex = 8;
            this.buttonIesire.Text = "Valea! :)";
            this.buttonIesire.UseVisualStyleBackColor = true;
            this.buttonIesire.Click += new System.EventHandler(this.buttonIesire_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(468, 443);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(75, 23);
            this.buttonLogOut.TabIndex = 9;
            this.buttonLogOut.Text = "Log out";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // InterfataBibliotecar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 489);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonIesire);
            this.Controls.Add(this.groupBoxCerere);
            this.Controls.Add(this.groupBoxCarte);
            this.Controls.Add(this.groupBoxInformatii);
            this.Controls.Add(this.tabControlInfo);
            this.Controls.Add(this.groupBoxCautare);
            this.Controls.Add(this.groupBoxProfil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InterfataBibliotecar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interfata Admin";
            this.groupBoxProfil.ResumeLayout(false);
            this.groupBoxProfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundPictureBoxPozaProfil)).EndInit();
            this.groupBoxCautare.ResumeLayout(false);
            this.groupBoxCautare.PerformLayout();
            this.tabControlInfo.ResumeLayout(false);
            this.tabPageCarti.ResumeLayout(false);
            this.tabPageImprumuturi.ResumeLayout(false);
            this.tabPageUtilizatori.ResumeLayout(false);
            this.tabPageCereri.ResumeLayout(false);
            this.groupBoxInformatii.ResumeLayout(false);
            this.groupBoxCarte.ResumeLayout(false);
            this.groupBoxCerere.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelAdministrator;
        private System.Windows.Forms.GroupBox groupBoxProfil;
        private WindowsFormsApplication27.RoundPictureBox roundPictureBoxPozaProfil;
        private System.Windows.Forms.GroupBox groupBoxCautare;
        private System.Windows.Forms.Label labelCauta;
        private System.Windows.Forms.TextBox textBoxCauta;
        private System.Windows.Forms.RadioButton radioButtonFiltruNone;
        private System.Windows.Forms.Label labelFiltru;
        private System.Windows.Forms.RadioButton radioButtonFiltruTitlu;
        private System.Windows.Forms.RadioButton radioButtonFiltruAutor;
        private System.Windows.Forms.Button buttonFiltruCauta;
        private System.Windows.Forms.RadioButton radioButtonFiltruUser;
        private System.Windows.Forms.RadioButton radioButtonFiltruGen;
        private System.Windows.Forms.TabControl tabControlInfo;
        private System.Windows.Forms.TabPage tabPageImprumuturi;
        private System.Windows.Forms.GroupBox groupBoxInformatii;
        private System.Windows.Forms.RichTextBox richTextBoxInformatii;
        private System.Windows.Forms.TabPage tabPageUtilizatori;
        private System.Windows.Forms.TabPage tabPageCereri;
        private System.Windows.Forms.GroupBox groupBoxCarte;
        private System.Windows.Forms.Button buttonCarteStoc;
        private System.Windows.Forms.Button buttonCarteStergere;
        private System.Windows.Forms.Button buttonCarteAdauga;
        private System.Windows.Forms.GroupBox groupBoxCerere;
        private System.Windows.Forms.Button buttonCerereRespinge;
        private System.Windows.Forms.Button buttonCerereAccepta;
        private System.Windows.Forms.Button buttonIesire;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.TabPage tabPageCarti;
        private System.Windows.Forms.ListBox listBoxCarti;
        private System.Windows.Forms.ListBox listBoxImprumuturi;
        private System.Windows.Forms.ListBox listBoxUtilizatori;
        private System.Windows.Forms.ListBox listBoxCereri;
    }
}

