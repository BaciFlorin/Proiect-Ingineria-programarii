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
    public partial class Autentificare : Form
    {
        public Autentificare()
        {
            InitializeComponent();
        }

        private void but_login_Click(object sender, EventArgs e)
        {
            if (this == null || this.IsDisposed)
                return;
            else
                this.Show();
        }

        private void link_reset_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Reseteaza_parola reseteaza_parola = new Reseteaza_parola();
            this.Hide();
            reseteaza_parola.ShowDialog(this);
            this.Show();
        }

        private void link_cont_nou_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Creeaza_un_cont creeaza_cont = new Creeaza_un_cont();
            this.Hide();
            creeaza_cont.ShowDialog(this);
            // daca se poate iesi dintr-un form child, trebuie sa verific daca acesta este inca valid inainte sa il afisez
            if (this == null || this.IsDisposed) 
                return;
            else
                this.Show();
        }

        private void butt_iesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
