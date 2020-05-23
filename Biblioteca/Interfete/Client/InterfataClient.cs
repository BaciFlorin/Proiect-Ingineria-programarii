/**************************************************************************
 *                                                                        *
 *  File:        InterfataClient.cs                                       *
 *  Copyright:   (c) 2020, Atomei Georgiana                               *
 *  E-mail:      georgiana.atomei@student.tuiasi.ro                       *
 *  Description: Interfata dispusa pentru utilizator                      *
 *                                                                        *
 **************************************************************************/

using System;
using System.Windows.Forms;
using Entitati;
using Comune;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace InterfataClient
{
    public partial class InterfataUtilizator : Form, IClientView
    {
        private int _loggedUserId;
        private List<Carte> _carti;
        private List<Imprumut> _imprumuturi;

        /// <summary>
        /// Referinta catre controller
        /// </summary>
        private IClientController _clientController;

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

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="idUser"></param>
        public InterfataUtilizator(int idUser)
        {
            _loggedUserId = idUser;
            InitializeComponent();

        }

        /// <summary>
        /// Setarea referintei catre controllerul interfetei
        /// </summary>
        /// <param name="clientController"></param>
        public void SetController(IClientController clientController)
        {
            _clientController = clientController;
        }

        /// <summary>
        /// Initializare si pornire interafata client
        /// </summary>
        public void Start()
        {
            
            _clientController.ObtinePathPozaUser(_loggedUserId);
            _clientController.ObtineUsername(_loggedUserId);
            toolTipLogOut.SetToolTip(buttonLogOut, "LogOut");
            
            _clientController.Init();

        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void tabControlBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearDetalii();

            if (tabControlBooks.SelectedIndex==0)
            {
                buttonReturn.Enabled = false;
                buttonBorrow.Enabled = true;
                _clientController.ObtineCarti(TipFiltru.None, "");
            }
            else
            {
                buttonReturn.Enabled = true;
                buttonBorrow.Enabled = false;
                _clientController.ObtineImprumuturi(TipFiltru.None, "");
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
            var result = MessageBox.Show("Sunteti sigur ca vreti sa va delogati?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();

            }
        }

        private void listBoxCartiImprumutate_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxCartiImprumutate.SelectedIndex;
            if (index >= 0 && index < _imprumuturi.Count)
            {
                _clientController.DetaliiImprumut(_imprumuturi[index].IdImprumut);
            }
        }

        private void listBoxCartiDisponibile_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxCartiDisponibile.SelectedIndex;
            if (index >= 0 && index < _carti.Count)
            {
                _clientController.DetaliiCarte(_carti[index]);
            }
            
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

        /// <summary>
        /// Afisarea listei cartilor imprumutate
        /// </summary>
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

        /// <summary>
        /// Afisarea listei cartilor
        /// </summary>
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

        /// <summary>
        /// Afisarea pozei utilizatorului logat
        /// </summary>
        /// <param name="path"></param>
        public void SeteazaPozaUser(string path)
        {
            if (path != "")
            {
                string imagesPath = Directory.GetCurrentDirectory() + @"\images\" + Path.GetFileName(path);

                roundPictureBoxUser.Image = Image.FromFile(imagesPath);
            }
        }

        /// <summary>
        /// Setarea username-ului
        /// </summary>
        /// <param name="username"></param>
        public void SeteazaUsername(string username)
        {
            linkLabelUsername.Text = username;
        }

        public void ClearDetalii()
        {
            richTextBoxDetails.Clear();
        }

        /// <summary>
        /// Afisarea unui mesaj setat in controller
        /// </summary>
        /// <param name="msg"></param>
        public void AfiseazaMesaj(string msg)
        {
            MessageBox.Show(msg, "Info");
        }
    }
}
