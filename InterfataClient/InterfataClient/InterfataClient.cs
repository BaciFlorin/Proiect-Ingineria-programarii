using System;
using System.Windows.Forms;
using Entitati;
using Controllers;
using System.Collections.Generic;

namespace InterfataClient
{
    public partial class InterfataUtilizator : Form
    {
        private int _loggedUserId;
        private List<Carte> _carti;
        private List<Imprumut> _cartiImprumutate;

        private ClientController _clientController = new ClientController();

        public InterfataUtilizator(/*int idUser*/)
        {
            //_loggedUserId = idUser;
            InitializeComponent();
            toolTipLogOut.SetToolTip(buttonLogOut, "LogOut");
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //log out
            this.Close();
        }

        private void tabControlBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControlBooks.SelectedIndex==0)
            {
                buttonReturn.Enabled = false;
                buttonBorrow.Enabled = true;
            }
            else
            {
                buttonReturn.Enabled = true;
                buttonBorrow.Enabled = false;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            TipFiltru tipFiltru;
            string filtru;
            if (radioBttnAuthor.Checked)
            {
                filtru = textBoxSearch.Text;
                tipFiltru = TipFiltru.Autor;
            }
            else if (radioBttnTitle.Checked)
            {
                filtru = textBoxSearch.Text;
                tipFiltru = TipFiltru.Titlu;
            }
            else if (radioBttnGender.Checked)
            {
                filtru = textBoxSearch.Text;
                tipFiltru = TipFiltru.Categorie;
            }
            else
            {
                tipFiltru = TipFiltru.None;
                filtru = "";
            }
            if (tabControlBooks.SelectedIndex == 0)
            {
                _carti = _clientController.ObtineCarti(tipFiltru, filtru);

                System.Object[] items = new System.Object[_carti.Count];
                for (int i = 0; i < _carti.Count; ++i)
                {
                    items[i] = _carti[i].Id + ". " + _carti[i].Titlu + "-" + _carti[i].Autor + "\n";
                }

                listBoxCartiDisponibile.Items.Clear();
                listBoxCartiDisponibile.Items.AddRange(items);
            }
            else
            {
                _cartiImprumutate = _clientController.ObtineImprumuturi(tipFiltru, filtru);
                System.Object[] items = new System.Object[_cartiImprumutate.Count];
                for (int i = 0; i < _cartiImprumutate.Count; ++i)
                {
                    items[i] = _cartiImprumutate[i].IdCarte + " " + _cartiImprumutate[i].DataImprumut + " " +
                        _cartiImprumutate[i].DataRestituire + "\n";
                }

                listBoxCartiImprumutate.Items.Clear();
                listBoxCartiImprumutate.Items.AddRange(items);
            }

        }
            
       
        private void buttonBorrow_Click(object sender, EventArgs e)
        {
            if (listBoxCartiDisponibile.Items.Count > 0)
            {
                int index = listBoxCartiDisponibile.SelectedIndex;
                Carte carte = _carti[index];
                _clientController.AdaugaImprumut(carte, _loggedUserId);
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            if (listBoxCartiImprumutate.Items.Count > 0)
            {
                int index = listBoxCartiImprumutate.SelectedIndex;
                Imprumut imprumut = _cartiImprumutate[index];
                _clientController.ReturneazaCarte(imprumut);
            }
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to logout?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //log out
                //open login ui
                this.Close();
            }
        }

        private void listBoxCartiImprumutate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCartiImprumutate.Items.Count > 0)
            {
                int index = listBoxCartiImprumutate.SelectedIndex;

                richTextBoxDetails.Text = _clientController.DetaliiImprumut(_cartiImprumutate[index].IdImprumut);
            }
        }

        private void listBoxCartiDisponibile_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCartiDisponibile.Items.Count > 0)
            {
                int index = listBoxCartiDisponibile.SelectedIndex;
                String bookInfo = _clientController.DetaliiCarte(_carti[index]);
                richTextBoxDetails.Text = bookInfo;
            }
        }

        private void linkLabelUsername_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //to do
            //afisare intr-o noua fereastra a informatiilor utilizatorului

            //preluare informatii si depundere in userInfo
            String userInfo = "Info";
            MessageBox.Show(userInfo, "Informații despre utilizator");
        }
    }
}
