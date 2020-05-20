/**************************************************************************
 *                                                                        *
 *  File:        InterfataIntroducereStoc.cs                              *
 *  Copyright:   (c) 2020, Bacica Florin                                  *
 *  E-mail:      florin.bacica@student.tuiasi.ro                          *
 *  Description: Clasa care descriu felul cum se comporta interfata    *
 *               de introducere a stocului la actiunea utilizatorului.    *
 *                                                                        *
 **************************************************************************/

using System;
using System.Windows.Forms;
using Comune;

namespace InterfataAdmin
{
    public partial class InterataIntroducereStoc : Form
    {
        private Form _parent;
        private String _carte;
        private IControllerAdmin _controller;

        public InterataIntroducereStoc(Form parent, String carte, IControllerAdmin controller)
        {
            _carte = carte;
            _parent = parent;
            _controller = controller;
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
                int id = int.Parse(_carte.Split(' ')[0]);
                _controller.AdaugaCartiInStoc(id,numarCarti);
                buttonIesire_Click(sender, e);
            }
            catch(FormatException)
            {
                MessageBox.Show("Adaugati numere in casuta va rog!");
            }
        }
    }
}
