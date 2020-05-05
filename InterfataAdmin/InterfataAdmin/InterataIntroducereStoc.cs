using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfataAdmin
{
    public partial class InterataIntroducereStoc : Form
    {
        private Form _parent;
        private String _carte;

        public InterataIntroducereStoc(Form parent, String carte)
        {
            _carte = carte;
            _parent = parent;
            InitializeComponent();
        }

        private void buttonIesire_Click(object sender, EventArgs e)
        {
            _parent.Enabled = true;
            this.Close();
        }

        private void buttonAdaugaStoc_Click(object sender, EventArgs e)
        {
            int numarCarti;
            try
            {
                numarCarti = int.Parse(textBoxAdaugaCarti.Text);
                //adaugare numar de cart in baza de date
                buttonIesire_Click(sender, e);
            }
            catch(FormatException)
            {
                MessageBox.Show("Adaugati numere in casuta va rog!");
            }
        }
    }
}
