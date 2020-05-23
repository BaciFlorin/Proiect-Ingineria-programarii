/**************************************************************************
 *                                                                        *
 *  File:        InterfataBibliotecar.cs                                  *
 *  Copyright:   (c) 2020, Bacica Florin                                  *
 *  E-mail:      florin.bacica@student.tuiasi.ro                          *
 *  Description: Clasa care controleaza felul cum se comporta          *
 *               interfata grafica a bibliotecarului.                     *
 *                                                                        *
 **************************************************************************/

using System;
using System.Drawing;
using System.Windows.Forms;
using Comune;

namespace Interfete
{
    public partial class InterfataBibliotecar : Form, IViewAdmin
    {
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

        /// <summary>
        /// Constructorul clasei
        /// </summary>
        public InterfataBibliotecar()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metoda care imi seteaza un anumit controller pentru interfata
        /// </summary>
        public void SetController(IControllerAdmin controller)
        {
            _controller = controller;
           
        }

        /// <summary>
        /// Pornirea aplicatiei
        /// </summary>
        public void Start()
        {
            _controller.Init();
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
                if (tab == 0)
                    textBoxCauta.Text = "Autor/Titlu/Gen";
                else if (tab == 1)
                    textBoxCauta.Text = "Autor/Titlu/Gen/User";
                else if (tab == 2)
                    textBoxCauta.Text = "Nume utilizator";
                textBoxCauta.ForeColor = SystemColors.InactiveCaption;
            }
        }

        private void buttonFiltruCauta_Click(object sender, EventArgs e)
        {
            // de completat cu insctructiuni care cauta in lista din tab-ul deschis obiecte in functie de ce e scris in casuta
            // text si in functie de radioButtonul selectat
            int tabSelected = tabControlInfo.SelectedIndex;
            string textDeCautat = textBoxCauta.Text;
            if (radioButtonFiltruAutor.Checked)
            {
                //filtrare dupa autor
                _controller.FiltreazaDupaAutor(tabSelected, textDeCautat);
            }
            else if (radioButtonFiltruGen.Checked)
            {
                //filtrare dupa gen
                _controller.FiltreazaDupaGen(tabSelected, textDeCautat);
            }
            else if (radioButtonFiltruNone.Checked)
            {
                //afisare continut neflirtat
                _controller.AfiseazaToate(tabSelected);
            }
            else if (radioButtonFiltruTitlu.Checked)
            {
                //afisare continut filtrat dupa titlu
                _controller.FiltreazaDupaTitlu(tabSelected, textDeCautat);
            }
            else
            {
                //filtrare dupa user
                _controller.FiltreazaDupaUser(tabSelected, textDeCautat);
            }

        }

        private void buttonCarteAdauga_Click(object sender, EventArgs e)
        {
            // la apasarea lui se va deschide un formular in care vor trebui introduse datele de adaugare a unei carti noi
            InterfataIntroducereCarte interfata = new InterfataIntroducereCarte(this, _controller);
            interfata.Show();
            this.Enabled = false;
        }

        private void buttonCarteSterge_Click(object sender, EventArgs e)
        {
            richTextBoxInformatii.Text = "";
            // la apasarea lui se va verifica daca este selectata o carte din lista si se va sterge
            if (listBoxCarti.SelectedIndex != -1)
            {
                //sterge carte
                String carte = listBoxCarti.SelectedItem.ToString();
                int id = int.Parse(carte.Split(' ')[0].Remove(0, 3));
                bool result = _controller.StergeCarte(id);
                if (result)
                {
                    richTextBoxInformatii.Text = "Carte stearsa cu succes!";
                }
                else
                {
                    richTextBoxInformatii.Text = "Probleme la stergera cartii!";
                }
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
            if (listBoxCarti.SelectedIndex != -1)
            {
                String carte = listBoxCarti.SelectedItem.ToString();
                InterataIntroducereStoc interata = new InterataIntroducereStoc(this, carte, _controller);
                interata.Show();
                this.Enabled = false;
            }
            else
            {
                MessageBox.Show("Va rugam selectati o carte!");
            }
            richTextBoxInformatii.Text = "";
        }

        private void buttonCerereAccepta_Click(object sender, EventArgs e)
        {
            // se verifica daca este selectata vreo cerere din lista
            // se va accepta cererea respectiva si se va sterge din lista
            richTextBoxInformatii.Text = "";
            int indice_selectat = listBoxCereri.SelectedIndex;
            if (indice_selectat != -1)
            {
                String cerere = listBoxCereri.SelectedItem.ToString();
                int id = int.Parse(cerere.Split(' ')[0].Remove(0, 3));
                bool result = _controller.AcceptaCerere(id);
                // se accepta cererea
                if (result)
                {
                    richTextBoxInformatii.Text = "Cerere acceptata cu succes!";
                }
                else
                {
                    richTextBoxInformatii.Text = "Probleme la procesarea cererii!";
                }
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
            richTextBoxInformatii.Text = "";
            int indice_selectat = listBoxCereri.SelectedIndex;
            if (indice_selectat != -1)
            {
                String cerere = listBoxCereri.SelectedItem.ToString();
                int id = int.Parse(cerere.Split(' ')[0].Remove(0, 3));
                bool result = _controller.RespingeCerere(id);
                // se respinge cererea
                if (result)
                {
                    richTextBoxInformatii.Text = "Cerere respinsa!";
                }
                else
                {
                    richTextBoxInformatii.Text = "Probleme la procesarea cererii!";
                }
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
                int id = int.Parse(cerere.Split(' ')[0].Remove(0, 3));
                _controller.InfoCerere(id);
            }
        }

        private void listBoxUtilizatori_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxUtilizatori.SelectedIndex != -1)
            {
                // se ia si se afiseaza in dreapta informatii despre utilizator
                String utilizator = listBoxUtilizatori.SelectedItem.ToString();
                int id = int.Parse(utilizator.Split(' ')[0].Remove(0, 3));
                _controller.InfoUtilizator(id);
            }
        }

        private void listBoxImprumuturi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxImprumuturi.SelectedIndex != -1)
            {
                // se ia si se afiseaza in chenarul din dreapta detalii despre imprumut
                String imprumut = listBoxImprumuturi.SelectedItem.ToString();
                int id = int.Parse(imprumut.Split(' ')[0].Remove(0, 3));
                _controller.InfoImprumut(id);
            }
        }

        private void listBoxCarti_SelectedIndexChanged(object sender, EventArgs e)
        {
            // se ia si se afiseaza detalii despre carte selectata
            if (listBoxCarti.SelectedIndex != -1)
            {
                String carte = listBoxCarti.SelectedItem.ToString();
                int id = int.Parse(carte.Split(' ')[0].Remove(0, 3));
                _controller.InfoCarte(id);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBoxInformatii.Text = "";
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
                if (radioButtonFiltruUser.Checked)
                {
                    radioButtonFiltruNone.Checked = true;
                }
                textBoxCauta.Text = "Titlu/Autor/Gen";
                textBoxCauta.ForeColor = SystemColors.InactiveCaption;
                groupBoxCarte.Enabled = true;
            }
            else if (index == 1)
            {
                textBoxCauta.Text = "Titlu/Autor/Gen/User";
                textBoxCauta.ForeColor = SystemColors.InactiveCaption;
                if (!radioButtonFiltruUser.Enabled)
                    radioButtonFiltruUser.Enabled = true;
            }
            else if (index == 2)
            {
                textBoxCauta.Text = "Nume utilizator";
                textBoxCauta.ForeColor = SystemColors.InactiveCaption;
                radioButtonFiltruAutor.Enabled = false;
                radioButtonFiltruUser.Enabled = false;
                radioButtonFiltruGen.Enabled = false;
                radioButtonFiltruNone.Enabled = false;
                radioButtonFiltruTitlu.Enabled = false;
            }
            else if (index == 3)
            {
                groupBoxCautare.Enabled = false;
                groupBoxCerere.Enabled = true;
                textBoxCauta.Text = "";
            }
        }

        /// <summary>
        /// Metoda care imi adauga un item nou in lista de imprumuturi de pe ecran
        /// </summary>
        public void PuneImprumutInLista(string imprumut)
        {
            listBoxImprumuturi.Items.Add(imprumut);
        }

        /// <summary>
        /// Metoda care imi pune un utilizator nou in lista de utilizatori de pe ecran
        /// </summary>
        public void PuneUtilizatorInLista(string utilizator)
        {
            listBoxUtilizatori.Items.Add(utilizator);
        }

        /// <summary>
        /// Metoda care imi pune o cerere noua in lista de cereri de pe ecran
        /// </summary>
        public void PuneCerereInLista(string cerere)
        {
            listBoxCereri.Items.Add(cerere);
        }

        /// <summary>
        /// Metoda care imi puneo o carte noua in lista de carti de pe ecran
        /// </summary>
        public void PuneCarteInLista(string carte)
        {
            listBoxCarti.Items.Add(carte);
        }

        /// <summary>
        /// Afiseaza un anumit text pe interfata
        /// </summary>
        public void Afiseaza(string text)
        {
            richTextBoxInformatii.Text = text;
        }

        /// <summary>
        /// Goleste lista de imprumuturi de pe ecran
        /// </summary>
        public void CurataListaImprumut()
        {
            listBoxImprumuturi.Items.Clear();
        }

        /// <summary>
        /// Goleste lista de utilizatori de pe ecran
        /// </summary>
        public void CurataListaUtilizatori()
        {
            listBoxUtilizatori.Items.Clear();
        }

        /// <summary>
        /// Goleste lista de cereri de pe ecran
        /// </summary>
        public void CurataListaCereri()
        {
            listBoxCereri.Items.Clear();
        }

        /// <summary>
        /// Goleste lista de carti de pe ecran
        /// </summary>
        public void CurataListaCarti()
        {
            listBoxCarti.Items.Clear();
        }
    }
}
