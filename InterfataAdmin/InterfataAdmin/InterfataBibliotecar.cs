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
    public partial class InterfataBibliotecar : Form
    {
        public InterfataBibliotecar()
        {
            InitializeComponent();
        }

        private void text_box_cautare_MouseClick(object sender, MouseEventArgs e)
        { 
            if (textBoxCauta.ForeColor == SystemColors.InactiveCaption)
            {
                textBoxCauta.Text = "";
                textBoxCauta.ForeColor = Color.Black;
            }
        }

        private void text_box_cautare_Leave(object sender, EventArgs e)
        {
            if (textBoxCauta.Text == "")
            {
                int tab = tabControlInfo.SelectedIndex;
                if(tab == 0)
                    textBoxCauta.Text = "Autor/Titlu/Gen";
                else if(tab == 1)
                    textBoxCauta.Text = "Autor/Titlu/Gen/User";
                else if(tab == 2)
                    textBoxCauta.Text = "Nume utilizator";
                textBoxCauta.ForeColor = SystemColors.InactiveCaption;
            }
        }

        private void buttonFiltruCauta_Click(object sender, EventArgs e)
        {
            // de completat cu insctructiuni care cauta in lista din tab-ul deschis obiecte in functie de ce e scris in casuta
            // text si in functie de radioButtonul selectat
            if(radioButtonFiltruAutor.Checked)
            {
                //filtrare dupa autor
            }
            else if(radioButtonFiltruGen.Checked)
            {
                //filtrare dupa gen
            }
            else if(radioButtonFiltruNone.Checked)
            {
                //afisare continut neflirtat
            }
            else if(radioButtonFiltruTitlu.Checked)
            {
                //afisare continut filtrat dupa titlu
            }
            else
            {
                //filtrare dupa user
            }
        }

        private void buttonCarteAdauga_Click(object sender, EventArgs e)
        {
            // la apasarea lui se va deschide un formular in care vor trebui introduse datele de adaugare a unei carti noi
            InterfataIntroducereCarte interfata = new InterfataIntroducereCarte(this);
            interfata.Show();
            this.Enabled = false;
        }

        private void buttonCarteSterge_Click(object sender, EventArgs e)
        {
            // la apasarea lui se va verifica daca este selectata o carte din lista si se va sterge
            if(listBoxCarti.SelectedIndex != -1)
            {
                //sterge carte
                String carte = listBoxCarti.SelectedItem.ToString();
                //...
            }
            else
            {
                MessageBox.Show("Va rugam selectati o carte!");
            }
        }

        private void buttonCarteStoc_Click(object sender, EventArgs e)
        {
            // la apasarea lui se va deschide o noua fereastra in care se va introduce numarul de carti
            // trebuie verificat daca este selectata vreo carte din lista
            if(listBoxCarti.SelectedIndex != -1)
            {
                String carte = listBoxCarti.SelectedItem.ToString();
                InterataIntroducereStoc interata = new InterataIntroducereStoc(this, carte);
                interata.Show();
                this.Enabled = false;
            }
            else
            {
                MessageBox.Show("Va rugam selectati o carte!");
            }
        }

        private void buttonCerereAccepta_Click(object sender, EventArgs e)
        {
            // se verifica daca este selectata vreo cerere din lista
            // se va accepta cererea respectiva si se va sterge din lista
            int indice_selectat = listBoxCereri.SelectedIndex;
            if (indice_selectat != -1)
            {
                String cerere = listBoxCereri.SelectedItem.ToString();

                // se accepta cererea
            }
            else
            {
                // nu este nici un element selectat
                MessageBox.Show("Va rugam selectati o cerere!");
            }
        }

        private void buttonCerereRespinge_Click(object sender, EventArgs e)
        {
            // se verifica daca este selectata o cerere din lista
            // se va respinge acea cerere si se va cere din lista
            int indice_selectat = listBoxCereri.SelectedIndex;
            if(indice_selectat != -1)
            {
                String cerere = listBoxCereri.SelectedItem.ToString();

                // se respinge cererea
            }
            else
            {
                // nu este nici un element selectat
                MessageBox.Show("Va rugam selectati o cerere!");
            }
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            // se va initializa o fereastra de log in a aplicatiei
            // initializarea ferestrei de log in
            this.Close();
        }

        private void buttonIesire_Click(object sender, EventArgs e)
        {
            // se va iesi din program
            Environment.Exit(0);
        }

        private void listBoxCereri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCereri.SelectedIndex != -1)
            {
                // se ia si se afiseaza in dreapta informatii despre cerere
                String cerere = listBoxCereri.SelectedItem.ToString();

                //afisare info la dreapta
                richTextBoxInformatii.Text = cerere;
            }
        }

        private void listBoxUtilizatori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxUtilizatori.SelectedIndex != -1)
            {
                // se ia si se afiseaza in dreapta informatii despre utilizator
                String utilizator = listBoxUtilizatori.SelectedItem.ToString();

                //afisare info
                richTextBoxInformatii.Text = utilizator;

            }
        }

        private void listBoxImprumuturi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxImprumuturi.SelectedIndex != -1)
            {
                // se ia si se afiseaza in chenarul din dreapta detalii despre imprumut
                String imprumut = listBoxImprumuturi.SelectedItem.ToString();

                // afisare informatie in dreapta
                richTextBoxInformatii.Text = imprumut;
            }
        }

        private void listBoxCarti_SelectedIndexChanged(object sender, EventArgs e)
        {
            // se ia si se afiseaza detalii despre carte selectata
            if (listBoxCarti.SelectedIndex != -1)
            {
                String carte = listBoxCarti.SelectedItem.ToString();

                //afisare informatii
                richTextBoxInformatii.Text = carte;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = tabControlInfo.SelectedIndex;
            groupBoxCarte.Enabled = false;
            groupBoxCerere.Enabled = false;
            groupBoxCautare.Enabled = true;

            radioButtonFiltruAutor.Enabled = true;
            radioButtonFiltruUser.Enabled = true;
            radioButtonFiltruGen.Enabled = true;
            radioButtonFiltruNone.Enabled = true;
            radioButtonFiltruTitlu.Enabled = true;


            if (index == 0)
            {
                radioButtonFiltruUser.Enabled = false;
                if(radioButtonFiltruUser.Checked)
                {
                    radioButtonFiltruNone.Checked = true;
                }
                textBoxCauta.Text = "Titlu/Autor/Gen";
                groupBoxCarte.Enabled = true;
            }
            else if(index == 1)
            {
                textBoxCauta.Text = "Titlu/Autor/Gen/User";
                if (!radioButtonFiltruUser.Enabled)
                    radioButtonFiltruUser.Enabled = true;
            }
            else if(index == 2)
            {
                textBoxCauta.Text = "Nume utilizator";
                radioButtonFiltruAutor.Enabled = false;
                radioButtonFiltruUser.Enabled = false;
                radioButtonFiltruGen.Enabled =false;
                radioButtonFiltruNone.Enabled = false;
                radioButtonFiltruTitlu.Enabled = false;
            }
            else if(index == 3)
            {
                groupBoxCautare.Enabled = false;
                groupBoxCerere.Enabled = true;
                textBoxCauta.Text = "";
            }
        }
    }
}
