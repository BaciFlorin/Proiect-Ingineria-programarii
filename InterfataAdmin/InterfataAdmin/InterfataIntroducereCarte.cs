﻿using System;
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
    public partial class InterfataIntroducereCarte : Form
    {
        private Form _parent;
        public InterfataIntroducereCarte(Form parent)
        {
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

            // se fac niste verificari si daca acestea se trec se incearca introducerea in baza de date
            // daca nu se reuseste se afiseaza mesajul de eroare
            // daca se reuseste se paraseste interfata


            MessageBox.Show("Se fac smecherii ca se pune carte in baza de date!");

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