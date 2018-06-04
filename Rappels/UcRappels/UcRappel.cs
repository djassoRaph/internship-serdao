using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace UcRappels
{
    public partial class UcRappel : Form
    {
        string idrappel;

        public UcRappel()
        {
            InitializeComponent();
            cbxClient.SelectedIndex = 0;
            ListViewCombobox();
            idrappel = "0";
            ListViewRafraichir();

        }


        public void ListViewCombobox()
        {
            DataTable DTclient = BDD.SelectDT("SELECT * FROM tbl_clients", "serdao");
            //ajout de la ligne choisissez
            DataRow dr = DTclient.NewRow();
            string[] Mesdonnes = { "0", "Sélectionnez le client.", " ", " ", " " };
            dr.ItemArray = Mesdonnes;
            DTclient.Rows.InsertAt(dr, 0);
            //on remplit le cbx
            cbxClient.DataSource = DTclient;
            cbxClient.DisplayMember = "NOM_CLIENT";
            cbxClient.ValueMember = "ID_CLIENT";
        }
        public void ListViewRafraichir()
        {




            DataTable table = null;
            string query = "SELECT * FROM `tbl_rappel` ORDER BY id_rappel DESC";
            table = BDD.SelectDT(query, "serdao");
            listView1.Items.Clear();
            // How do I recuperate from one side the phone numbers and the email? That doesn't show in the 



            foreach (DataRow dr in table.Rows)
            {



                ListViewItem lvi = new ListViewItem();
                lvi.Text = dr["id_rappel"].ToString();
                string[] Mesdonnes = { dr["nom_client"].ToString(), dr["date"].ToString(), dr["commentaire"].ToString(), dr["email"].ToString(), dr["telephone"].ToString() };
                lvi.SubItems.AddRange(Mesdonnes);



                DateTime HeureDuRappel = DateTime.ParseExact(dr["date"].ToString(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
                //Variable DateTime.Now aussi.
                if (ckbRappelProchain.Checked)
                {
                    if (HeureDuRappel.CompareTo(DateTime.Now) > 0)
                    {
                        listView1.Items.Add(lvi);
                    }
                }
                else
                {
                    listView1.Items.Add(lvi);
                }


            }
        }

        private void saveinfo()
        {
            if (cbxClient.SelectedItem.ToString() != "Choisissez un client")
                try
                {

                    DataTable DTclient = BDD.SelectDT("SELECT * FROM tbl_clients WHERE ID_CLIENT = '" + cbxClient.SelectedValue.ToString() + "'", "serdao");


                    string localtelephone = DTclient.Rows[0]["TELEPHONE"].ToString();
                    string localemail = DTclient.Rows[0]["EMAIL"].ToString();


                    if (cbxClient.ValueMember != "0")
                    {
                        if (idrappel.Equals("0"))
                        {
                            // Decouverte de l'oublie "txtCommentaire.Replace("'", "''") 
                            string query = "INSERT INTO tbl_rappel (nom_client,date,telephone,email,commentaire) VALUES ('" + cbxClient.Text + "','" + dateTimePicker1.Value.ToString("dd/MM/yyyy HH:mm") + "','" + localtelephone.Replace("'", "''") + "','" + localemail.Replace("'", "''") + "','" + txtCommentaire.Text.Replace("'", "''") + "')";
                            BDD.InsertOrUpdate(query, "serdao");

                        }
                        else
                        {

                            string query = "UPDATE tbl_rappel SET nom_client='" + cbxClient.Text.Replace("'", "''") + "',date='" + dateTimePicker1.Value.ToString("dd/MM/yyyy HH:mm") + "',telephone='" + localtelephone.Replace("'", "''") + "',email ='" + localemail.Replace("'", "''") + "',commentaire='" + txtCommentaire.Text.Replace("'", "''") + "' WHERE id_rappel = '" + idrappel + "' ";
                            BDD.InsertOrUpdate(query, "serdao");

                        }
                        ListViewRafraichir();
                    }
                }
                catch
                {
                    MessageBox.Show("Veuillez bien choisir un élément de la liste.", "Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
        }

        private void mettreAzero()
        {
            cbxClient.SelectedIndex = 0;
            dateTimePicker1.Value = DateTime.Now;
            txtCommentaire.Text = "";
            lblIDRAPPEL.Text = "Nouveau rappel";
            idrappel = "0";

        }






        private void btnNew_Click(object sender, EventArgs e)
        {
            mettreAzero();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveinfo();
            mettreAzero();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ListViewRafraichir();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count < 1) return; // Securité pour empecher d'aller a 0 parceque sinon ca bug!!! ca peur arrivé d'etre inferieur a 1.

            string nom = listView1.SelectedItems[0].SubItems[1].Text;

            DataTable DTidclient = BDD.SelectDT("Select ID_CLIENT FROM tbl_clients WHERE NOM_CLIENT ='" + nom + "'", "serdao");



            cbxClient.SelectedValue = DTidclient.Rows[0][0].ToString();
            string time = listView1.SelectedItems[0].SubItems[2].Text;
            dateTimePicker1.Value = DateTime.ParseExact(time, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            txtCommentaire.Text = listView1.SelectedItems[0].SubItems[3].Text;
            lblIDRAPPEL.Text = "ID rappel : " + listView1.SelectedItems[0].Text;
            idrappel = listView1.SelectedItems[0].Text;
        }

        private void ckbRappelProchain_CheckedChanged(object sender, EventArgs e)
        {
            ListViewRafraichir();
        }
    }
}
