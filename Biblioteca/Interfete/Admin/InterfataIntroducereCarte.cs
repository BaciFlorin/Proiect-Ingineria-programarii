/**************************************************************************
 *                                                                        *
 *  File:        InterfataIntroducereCarte.cs                             *
 *  Copyright:   (c) 2020, Bacica Florin                                  *
 *  E-mail:      florin.bacica@student.tuiasi.ro                          *
 *  Description: Clasa care descriu felul cum se comporta interfata    *
 *               de introducere a unei carti la actiunea                  *
 *               utilizatorului.                                          *
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comune;

namespace InterfataAdmin
{
    public partial class InterfataIntroducereCarte : Form
    {
        private Form _parent;
        private IControllerAdmin _controller;

        private const int CP_NOCLOSE_BUTTON = 0x200;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        public InterfataIntroducereCarte(Form parent, IControllerAdmin controller)
        {
            _controller = controller;
            _parent = parent;
            InitializeComponent();
        }

        private void buttonCarteAdauga_Click(object sender, EventArgs e)
        {
            String titlu = textBoxCarteTitlu.Text;
            String autor = textBoxCarteAutor.Text;
            String IBBN = textBoxCarteIbbn.Text;
            String descriere = richTextBoxCarteDescriere.Text;
            String categotie = comboBoxCarteCategorie.Text;
            int stoc;

            // trebuie sa se verfice daca nu s-au intodus litere sau daca numarul e negativ
            try
            {
                stoc = int.Parse(textBoxCarteStoc.Text);
                if(stoc < 0)
                {
                    MessageBox.Show("Stocul nu poate fi negativ!");
                    return;
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("Introduceti un numar va rog!");
                return;
            }

            _controller.AdaugaCarteNoua(titlu, autor, IBBN, descriere, categotie, stoc);

            if(true)
            {
                _parent.Enabled = true;
                this.Close();
            }
        }

        private void buttonCarteAnuleaza_Click(object sender, EventArgs e)
        {
            _parent.Enabled = true;
            this.Close();
        }

        private void InterfataIntroducereCarte_FormClosing(object sender, FormClosingEventArgs e)
        {
            _parent.Enabled = true;
        }
    }
}
