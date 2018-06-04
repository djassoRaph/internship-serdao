using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Win32;

namespace FormInfo
{
    public partial class Fo_suiviastea : Form
    {
        string MessageVoulu = null;
        public Fo_suiviastea()
        {
            Cursor.Current = Cursors.WaitCursor;
            InitializeComponent();
            ListViewRafraichir();
            Cursor.Current = Cursors.Default;
        }

        public void ListViewRafraichir()
        {
          DataTable table = null;
          string query = "SELECT * FROM `tbl_suiviastea` ORDER BY NTICKET DESC";
          table = BDD.SelectDT(query,"sogetrel");
            maListView.Items.Clear();
           
            foreach (DataRow dr in table.Rows)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = dr["NTICKET"].ToString();
                string[] Mesdonnes = {dr["EMAIL_PRISE_EN_COMPTE"].ToString(), dr["EMAIL_TRANSFER"].ToString(), dr["EMAIL_CLOTURE"].ToString(), dr["HOTLINER"].ToString(), dr["DATECREATION"].ToString()+ " "+ dr["HEUREDECREATION"].ToString(), dr["FORMATDEMANDE"].ToString(), dr["NOM"].ToString(), dr["TELEPHONE"].ToString() };
                lvi.SubItems.AddRange(Mesdonnes);

                    maListView.Items.Add(lvi);
         
            }
          
        }

        private void ouvrir()
        {
            try
            {
                Fo_demande frmdemande = new Fo_demande(this, maListView.SelectedItems[0].Text);
                frmdemande.Show();
            }
            catch // SI Erreur de selection
            {
                MessageBox.Show("Veuillez bien choisir un élément de la liste.", "Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void nouveau()
        {
            Fo_demande frmDemande = new Fo_demande(this);
            frmDemande.Show();

        }



        private void sendmail()
        {
            try
            {
                MessageBox.Show("Under construction.");
            }
            catch // SI Erreur de selection
            {
                MessageBox.Show("Veuillez bien choisir un élément de la liste.", "Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
           // //catégorie
           //string categorie = maListView.SelectedItems[0].SubItems[13].ToString();
           // //numéro ticket
           // string numeroticket = maListView.SelectedItems[0].Text;
           // //Recup mail du client
           // string emailclient = maListView.SelectedItems[0].SubItems[9].ToString();
           // string emailsogetrel = "hotline@sogetrel.fr";
           // string msgsogetrel = "msg.sogetrel.com";
           // string client.sogetrel.fr
           //     string proxy = > msg.sogetrel.com
            // If line selected Collect information from that line, use it into
            // if (dr[24].ToString().Contains("Fait")
            // do magic! 
            //if mail sent do not send mail

            // en fonction de la catégory donc il faut recuperé la catégory.   / Bug Majeur / Problem de connection 

            //which mail must be sent ; le premier mail c'est **prise en charge On a six truc possible a tenir dans son truc dans le pdf 
            // Mais il en met que quatre.** Compte utilisateur parametrage on envoi un mail de creation de ticket pour dire que ca va etre 
            //traiter demain a 7  Mail : support.app.dsi@sogetrel.fr Problème de Connexion Bug Majeu

            // Problem de connection bug majeur : => 

            //faut recupere les elements de la ligne 

            //pour chaque ticket dans tout les cas il faut envoyer un mail au client pour la creation de ticket

        }


        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ouvrir();
        }

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nouveau();
        }

        private void btnNouveau_Click_1(object sender, EventArgs e)
        {
            nouveau();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
           ouvrir();
        }

        private void envoiMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sendmail();
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            sendmail();
        }

        private void maListView_DoubleClick(object sender, EventArgs e)
        {
            ouvrir();
        }

        private void envoiMailDeTransferTechnicienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sendmail();
        }

        private void envoiMailDeClôtureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sendmail();
        }
    }
}
