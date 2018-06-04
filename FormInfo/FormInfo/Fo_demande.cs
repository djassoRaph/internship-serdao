using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormInfo
{
    public partial class Fo_demande : Form
    {
        
        public Fo_suiviastea monsuiviastea;
        public string nuticket;
        DataTable DTtickets;

        public Fo_demande(Fo_suiviastea suiviastea)
        {
            Cursor.Current = Cursors.WaitCursor;
            monsuiviastea = suiviastea;
            InitializeComponent();
            nuticket = "0";
            Cursor.Current = Cursors.Default;
        }

        public Fo_demande(Fo_suiviastea suiviastea, string nticket)
        {
            monsuiviastea = suiviastea;
            InitializeComponent();
            nuticket = nticket;
            remplirLesChamps(nuticket);

        }
        private static int StringintoInt(string nuticket)
        {

            string temp = nuticket;
            string StringIhave = temp.Substring(3);
            int intIwant = Convert.ToInt32(StringIhave);
            return intIwant;
        }


        public void remplirLesChamps(string nuticket)
        {
            int intIwant = StringintoInt(nuticket);

            if (intIwant == 0) return;


            DTtickets = BDD.SelectDT("SELECT * FROM tbl_suiviastea WHERE NTICKET ='" + nuticket + "';", "sogetrel");
            // Erreur on avait pris selectedText au lieu de SelectedItem.
            cbxAffaire.SelectedItem = DTtickets.Rows[0]["AFFAIRE"].ToString();
            cbxCateg.SelectedItem = DTtickets.Rows[0]["CATEGORIE"].ToString();
            cbxCloture.SelectedItem = DTtickets.Rows[0]["CLOTURE"].ToString();
            cbxCriti.SelectedItem = DTtickets.Rows[0]["CRITICITE"].ToString();
            cbxFormat.SelectedItem = DTtickets.Rows[0]["FORMATDEMANDE"].ToString();
            cbxNiveauR.SelectedItem = DTtickets.Rows[0]["NIVEAUDERESOLUTION"].ToString();
            cbxProfil.SelectedItem = DTtickets.Rows[0]["PROFIL"].ToString();
            lblTicket.Text = nuticket;
            txtDescription.Text = DTtickets.Rows[0]["DESCRIPTION"].ToString();
            txtEmail.Text = DTtickets.Rows[0]["EMAIL"].ToString();
            txtNom.Text = DTtickets.Rows[0]["NOM"].ToString();
            txtRefClient.Text = DTtickets.Rows[0]["REFERENCECLIENT"].ToString();
            txtTelephone.Text = DTtickets.Rows[0]["TELEPHONE"].ToString();
            txtAction.Text = DTtickets.Rows[0]["ACTION"].ToString();



            string dateetheurederesolution = DTtickets.Rows[0]["DATEDERESOLUTION"].ToString() + " " + DTtickets.Rows[0]["HEUREDERESOLUTION"].ToString();



            if (dateetheurederesolution.Equals("   ") == false)
            {
                dtp1.Value = DateTime.ParseExact(dateetheurederesolution, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
                lblDate.Visible = true;
                dtp1.Visible = true;
            }

        }


        public void updateTicket()
        {

            // Check if Resolu ou non. 
            string heureResolution;
            string dateResolution;
            string delaisResolution;

            if (cbxCloture.Text.Contains("Oui"))
            {
                string dateetheuredecreation = DTtickets.Rows[0]["DATECREATION"].ToString() + " " + DTtickets.Rows[0]["HEUREDECREATION"].ToString();

                heureResolution = dtp1.Value.ToString("HH:mm");

                dateResolution = dtp1.Value.ToString("dd/MM/yyyy");
                DateTime fin = dtp1.Value;
                DateTime Debut = DateTime.ParseExact(dateetheuredecreation, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
                int heures = Convert.ToInt32(fin.Subtract(Debut).TotalMinutes) / 60;
                delaisResolution = heures.ToString() + ":" + (fin.Subtract(Debut).TotalMinutes - (heures * 60)).ToString();
            }
            else
            {

                heureResolution = " ";
                dateResolution = " ";
                delaisResolution = " ";
            }

            string query = "UPDATE tbl_suiviastea SET FORMATDEMANDE='" + cbxFormat.Text + "',NOM='" + txtNom.Text.Replace("'", "''") + "',TELEPHONE='" + txtTelephone.Text.Replace("'", "''") + "',EMAIL='" + txtEmail.Text.Replace("'", "''") + "',REFERENCECLIENT='" + txtRefClient.Text.Replace("'", "''") + "',PROFIL='" + cbxProfil.Text + "',AFFAIRE='" + cbxAffaire.Text + "',CATEGORIE='" + cbxCateg.Text + "',CRITICITE='" + cbxCriti.Text + "',DESCRIPTION='" + txtDescription.Text.Replace("'", "''") + "',NIVEAUDERESOLUTION='" + cbxNiveauR.Text + "',ACTION='" + txtAction.Text.Replace("'", "''") + "',DATEDERESOLUTION='" + dateResolution + "',HEUREDERESOLUTION='" + heureResolution + "',DELAISDERESOLUTION='" + delaisResolution + "',CLOTURE='" + cbxCloture.Text + "'";
            query += " WHERE NTICKET = '" + nuticket + "'";
            BDD.InsertOrUpdate(query, "sogetrel");

            monsuiviastea.ListViewRafraichir();
            this.Dispose();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            // Si un des combobox sont encore avec l'info "selectionez alors message"
            if (cbxCriti.SelectedIndex == -1 || cbxNiveauR.SelectedIndex == -1 || cbxFormat.SelectedIndex == -1 || cbxProfil.SelectedIndex == -1 || cbxProfil.SelectedIndex == -1 || cbxCloture.SelectedIndex == -1 || cbxAffaire.SelectedIndex == -1)
            {
                MessageBox.Show("Vous n'avez pas choisi une ou plusieurs des listes déroulantes", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                if (nuticket.Equals("0"))
                {
                    InsertintoSQL();
                }
                else
                {
                    updateTicket();
                }
                this.Dispose();
            }

        }

        public static string NumeroProchainTicket()
        {
            DataTable DTDernierTicket = BDD.SelectDT("SELECT NTICKET FROM tbl_suiviastea ORDER BY NTICKET DESC LIMIT 1", "sogetrel");
            if (DTDernierTicket.Rows.Count > 0)
            {
                string dernierticket = DTDernierTicket.Rows[0][0].ToString();
                if (dernierticket.Substring(3, 8).Contains(DateTime.Now.ToString("yyyyMMdd")))
                {
                    int Numero = int.Parse(dernierticket.Substring(11, 2)); // error if the string is too short must place an extra zer on the thingy 

                    Numero++;
                    string NumeroToString = Numero.ToString("D2"); // fixed with ToString("00") OR "D2"
                    return "CNM" + DateTime.Now.ToString("yyyyMMdd") + NumeroToString;
                }
                else
                {

                    return "CNM" + DateTime.Now.ToString("yyyyMMdd") + "00";
                }
            }
            else
            {
                return "CNM" + DateTime.Now.ToString("yyyyMMdd") + "00";
            }
        }

        public void InsertintoSQL()
        {
            string numeroticket = NumeroProchainTicket();
            int week = ((DateTime.Now.DayOfYear / 7) + 1);

            // Check if Resolu ou non. 
            string heureResolution;
            string dateResolution;
            string delaisResolution;

            if (cbxCloture.Text.Contains("Oui"))
            {
                heureResolution = DateTime.Now.ToString("HH:mm");
                dateResolution = DateTime.Now.ToString("dd/MM/yyyy");
                delaisResolution = "00:10";
            }
            else
            {

                heureResolution = " ";
                dateResolution = " ";
                delaisResolution = " ";
            }


            string query = "INSERT INTO tbl_suiviastea (NTICKET,HOTLINER,DATECREATION,HEUREDECREATION,SEMAINE,MOIS,ANNEE,FORMATDEMANDE,NOM,TELEPHONE,EMAIL,REFERENCECLIENT,PROFIL,AFFAIRE,CATEGORIE,CRITICITE,DESCRIPTION,CLOTURE,NIVEAUDERESOLUTION,ACTION,DATEDERESOLUTION,HEUREDERESOLUTION,DELAISDERESOLUTION)";
            query += " VALUES ('" + numeroticket + "','hotliner1', '" + DateTime.Now.ToString("dd/MM/yyyy") + "','" + DateTime.Now.AddMinutes(-10).ToString("HH:mm") + "','" + week.ToString() + "',";
            query += "'" + DateTime.Now.Month.ToString() + "','" + DateTime.Now.Year.ToString() + "','" + cbxFormat.Text + "','" + txtNom.Text.Replace("'", "''") + "','" + txtTelephone.Text.Replace("'", "''") + "','" + txtEmail.Text.Replace("'", "''") + "','" + txtRefClient.Text.Replace("'", "''") + "','" + cbxProfil.Text + "','" + cbxAffaire.Text;
            query += "','" + cbxCateg.Text + "','" + cbxCriti.Text + "','" + txtDescription.Text.Replace("'", "''")+"','" + cbxCloture.Text + "','" + cbxNiveauR.Text;
            query += "','" + txtAction.Text.Replace("'", "''");
            query += "','" + dtp1.Value.Date.ToString("dd/MM/yyyy");
            query += "','" + dtp1.Value.ToString("HH:mm");
            query += "','" + delaisResolution + "')";

            BDD.InsertOrUpdate(query, "sogetrel");

            monsuiviastea.ListViewRafraichir();

        }

        private void cbxCloture_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxCloture.Text.Contains("Oui"))
            {
                lblDate.Visible = true;
                dtp1.Visible = true;

            }
            else
            {
                lblDate.Visible = false;
                dtp1.Visible = false;
            }
        }

        private void Fo_demande_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Dispose();
            }
        }

        private void cbxFormat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void cbxFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxFormat.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cbxProfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxProfil.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cbxNiveauR_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxNiveauR.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cbxCloture_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxCloture.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cbxAffaire_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxAffaire.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cbxCateg_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxCateg.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cbxCriti_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxCriti.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            Regex mRegxExpression;
            if (txtEmail.Text.Trim() != string.Empty)
            {
                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                if (!mRegxExpression.IsMatch(txtEmail.Text.Trim()))
                {
                    MessageBox.Show("Le format de l'e-mail n'est pas correct.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Focus();
                }

            }
        }

       
    }
}
