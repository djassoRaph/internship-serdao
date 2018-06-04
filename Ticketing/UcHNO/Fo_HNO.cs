using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UcHNO
{
    public partial class Fo_HNO : Form
    {
        public Fo_HNO()
        {
            Cursor.Current = Cursors.WaitCursor;
            InitializeComponent();
            ListViewRafraichir();
            Cursor.Current = Cursors.Default;
        }
        public void ListViewRafraichir()
        {
            DataTable table = null;
            string query = "SELECT * FROM `tbl_ineo_hno` ORDER BY NUM_TICK_FRONT_OFFICE DESC";
            table = BDD.SelectDT(query, "serdao");
            maListView.Items.Clear();

            foreach (DataRow dr in table.Rows)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = dr["NUM_TICK_FRONT_OFFICE"].ToString();
                string[] Mesdonnes = { dr["DATE_HEURE_APPEL"].ToString(), dr["NOM_CLIENT"].ToString(), dr["ADRESSE"].ToString(), dr["NOM_APPELANT"].ToString(), dr["TELEPHONE_O"].ToString(), dr["PANNE_DESC"].ToString(), dr["OBSERVATIONS"].ToString(), dr["TECH_APPELE"].ToString()};
                lvi.SubItems.AddRange(Mesdonnes);

                maListView.Items.Add(lvi);

            }

        }
        private void nouveau()
        {
            Fo_Demande frmDemande = new Fo_Demande(this);
            frmDemande.Show();

        }

        private void ouvrir()
        {
            try
            {
                Fo_Demande frmdemande = new Fo_Demande(this, maListView.SelectedItems[0].Text);
                frmdemande.Show();
            }
            catch (Exception ex)// SI Erreur de selection
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Veuillez bien choisir un élément de la liste.", "Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            nouveau();
        }


        private void btnOpen_Click(object sender, EventArgs e)
        {
            ouvrir();
        }

        private void maListView_DoubleClick(object sender, EventArgs e)
        {
            ouvrir();
        }
    }
}
