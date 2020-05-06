using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfataClient
{
    public partial class InterfataUtilizator : Form
    {
     
        public InterfataUtilizator()
        {
            InitializeComponent();
            toolTipLogOut.SetToolTip(buttonLogOut, "LogOut");
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
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

            if (radioBttnAuthor.Checked)
            {
                //apel search cu filtru autor
            }
            else if (radioBttnTitle.Checked)
            {
                //apel search cu filtru titlu
            }
            else if (radioBttnGender.Checked)
            {
                //apel search cu filtru gen
            }
            else
            {
                //apel search fara filtru
            }

        }
            
       
        private void buttonBorrow_Click(object sender, EventArgs e)
        {
            //get selected book
            //creare cerere de imprumut carte daca aceasta nu este imprumutata deja
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            //get selected book
            //creare cerere de restituire carte
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to logout?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //log out
                //open login ui
            }
        }

        private void listBoxCartiImprumutate_SelectedIndexChanged(object sender, EventArgs e)
        {
            //getbookinfo and place it in bookInfo
            String bookInfo = "";
            richTextBoxDetails.Text = bookInfo;
        }

        private void listBoxCartiDisponibile_SelectedIndexChanged(object sender, EventArgs e)
        {
            //getbookinfo
            String bookInfo = "";
            richTextBoxDetails.Text = bookInfo;
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
