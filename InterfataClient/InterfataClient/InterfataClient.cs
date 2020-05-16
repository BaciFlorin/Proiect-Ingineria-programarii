using System;
using System.Windows.Forms;
using Entitati;
using Controlere;
using Comune;
using System.Collections.Generic;
using System.Drawing;

namespace InterfataClient
{
    public partial class InterfataUtilizator : Form, IClientView
    {
        private int _loggedUserId;
        private List<Carte> _carti;
        private List<Imprumut> _imprumuturi;

        private IClientController _clientController;

        public InterfataUtilizator(int idUser)
        {
           _loggedUserId = idUser;
            InitializeComponent();
            
        }

        public void SetController(IClientController clientController)
        {
            _clientController = clientController;
        }


        public void Start()
        {
            _clientController.ObtinePathPozaUser(_loggedUserId);
            _clientController.ObtineUsername(_loggedUserId);
            toolTipLogOut.SetToolTip(buttonLogOut, "LogOut");
            Application.EnableVisualStyles();
            Application.Run(this);
           

        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabControlBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearDetalii();

            if (tabControlBooks.SelectedIndex==0)
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
               _clientController.ObtineCarti(tipFiltru, filtru);
            }
            else
            {
                _clientController.ObtineImprumuturi(tipFiltru, filtru);
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
                Imprumut imprumut = _imprumuturi[index];
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
            int index = listBoxCartiImprumutate.SelectedIndex;
            _clientController.DetaliiImprumut(_imprumuturi[index].IdImprumut);
            
        }

        private void listBoxCartiDisponibile_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxCartiDisponibile.SelectedIndex;
            _clientController.DetaliiCarte(_carti[index]);
            
        }

        private void linkLabelUsername_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _clientController.DetaliiUser(_loggedUserId);
        }

        public void AfiseazaDetalii(string detalii)
        {
            richTextBoxDetails.Text = detalii;
        }
        public void AfiseazaDetaliiUtlizator(string detalii)
        {
            MessageBox.Show(detalii, "Informații despre utilizator");
        }

        public void AfiseazaImprumuturi()
        {
            System.Object[] items = new System.Object[_imprumuturi.Count];
            for (int i = 0; i < _imprumuturi.Count; ++i)
            {
                items[i] = _imprumuturi[i].IdCarte + " " + _imprumuturi[i].DataImprumut + " " +
                    _imprumuturi[i].DataRestituire + "\n";
            }

            listBoxCartiImprumutate.Items.Clear();
            listBoxCartiImprumutate.Items.AddRange(items);
        }
        public void AfiseazaCarti()
        {
            System.Object[] items = new System.Object[_carti.Count];
            for (int i = 0; i < _carti.Count; ++i)
            {
                items[i] = _carti[i].Id + ". " + _carti[i].Titlu + "-" + _carti[i].Autor + "\n";
            }

            listBoxCartiDisponibile.Items.Clear();
            listBoxCartiDisponibile.Items.AddRange(items);
        }

        public void SeteazaListaImprumuturi(List<Imprumut> imprumuturi)
        {
            _imprumuturi = imprumuturi;
        }
        public void SeteazaListaCarti(List<Carte> carti)
        {
            _carti = carti;
        }

        public void SeteazaPozaUser(string path)
        {
            //roundPictureBoxUser.Image = Image.FromFile(path);
        }
        public void SeteazaUsername(string username)
        {
            linkLabelUsername.Text = username;
        }

        public void ClearDetalii()
        {
            richTextBoxDetails.Clear();
        }
    }
}
