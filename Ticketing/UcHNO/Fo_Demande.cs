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
    public partial class Fo_Demande : Form
    {
        public Fo_HNO maDemande;
        public string NUTicket;
        DataTable DTtickets;

        public Fo_Demande(Fo_HNO hNO_suivi)
        {
            Cursor.Current = Cursors.WaitCursor;
            maDemande = hNO_suivi;
            InitializeComponent();
            NUTicket = "0";
            Cursor.Current = Cursors.Default;
        }

        public Fo_Demande(Fo_HNO hNO_suivi, string NTticket)
        {
            Cursor.Current = Cursors.WaitCursor;
            maDemande = hNO_suivi;
            InitializeComponent();
            NUTicket = NTticket;
            remplirLesChamps(NTticket);
            Cursor.Current = Cursors.Default;

        }

       

        public void InsertintoSQL()
        {
            string query = "INSERT INTO tbl_ineo_hno (DATE_HEURE_APPEL,NUM_TICK_FRONT_OFFICE,NOM_CLIENT,ADRESSE,NOM_APPELANT,TELEPHONE_O,PANNE_DESC,TECH_APPELE,OBSERVATIONS)";
            query += " VALUES ('" + DateTime.Now.ToString("dd/MM/yyyy HH:mm") + "','"+ txtNumTicket.Text.Replace("'", "''") + "','" + txtNClient.Text.Replace("'", "''") + "','" +txtAdresse.Text.Replace("'","''")+"','"+ txtNappelant.Text.Replace("'", "''") + "','" + txtTelephone.Text.Replace("'", "''") + "','" + txtTypeDePanne.Text.Replace("'", "''") + "','" + txtTechApple.Text.Replace("'", "''") + "','" + txtObs.Text.Replace("'", "''") + "')";


            BDD.InsertOrUpdate(query, "serdao");
        }


        public void updateTicket()
        {

            string query = "UPDATE tbl_ineo_hno SET NUM_TICK_FRONT_OFFICE='"+txtNumTicket.Text.Replace("'", "''") + "', NOM_CLIENT='" + txtNClient.Text.Replace("'", "''") + "',ADRESSE='"+txtAdresse.Text.Replace("'", "''") + "',NOM_APPELANT='"+txtNappelant.Text.Replace("'", "''") + "',TELEPHONE_O='"+txtTelephone.Text.Replace("'", "''") + "',PANNE_DESC='"+txtTypeDePanne.Text.Replace("'", "''") + "',TECH_APPELE ='"+txtTechApple.Text.Replace("'", "''") + "',OBSERVATIONS='"+txtObs.Text.Replace("'", "''") + "'  WHERE NUM_TICK_FRONT_OFFICE = '" + NUTicket + "'";
            BDD.InsertOrUpdate(query, "serdao");
            txtNumTicket.ReadOnly = true;

        }


        private void remplirLesChamps(string NUTicket)
        {
        
            txtNumTicket.Text = NUTicket;
            DTtickets = BDD.SelectDT("SELECT * FROM tbl_ineo_hno WHERE NUM_TICK_FRONT_OFFICE ='" + NUTicket + "';", "serdao");
           

           

            txtNClient.Text = DTtickets.Rows[0]["NOM_CLIENT"].ToString();
            txtNappelant.Text = DTtickets.Rows[0]["NOM_APPELANT"].ToString();
            txtTelephone.Text = DTtickets.Rows[0]["TELEPHONE_O"].ToString();
            txtTypeDePanne.Text = DTtickets.Rows[0]["PANNE_DESC"].ToString();
            txtTechApple.Text = DTtickets.Rows[0]["TECH_APPELE"].ToString();
            txtAdresse.Text = DTtickets.Rows[0]["ADRESSE"].ToString();
            txtObs.Text = DTtickets.Rows[0]["OBSERVATIONS"].ToString();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Make sure text box are filled. 
            if (txtTelephone.Text.Equals("") || txtObs.Text.Equals("") || txtTypeDePanne.Text.Equals("") || txtNClient.Text.Equals("") || txtNappelant.Text.Equals("")|| txtTechApple.Text.Equals("") || txtAdresse.Text.Equals(""))
            {
                MessageBox.Show("Vous n'avez pas saisie tous les champs nécessaire", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                if (NUTicket.Equals("0"))
                {
                    InsertintoSQL();
                }
                else
                {
                    updateTicket();
                }
                maDemande.ListViewRafraichir();
                this.Dispose();
            }

            

        }



       



    }
}
