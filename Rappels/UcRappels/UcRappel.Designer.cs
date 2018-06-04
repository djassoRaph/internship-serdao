namespace UcRappels
{
    partial class UcRappel
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnltop = new System.Windows.Forms.Panel();
            this.ckbRappelProchain = new System.Windows.Forms.CheckBox();
            this.lblRappel = new System.Windows.Forms.Label();
            this.pnlgauche = new System.Windows.Forms.Panel();
            this.lblIDRAPPEL = new System.Windows.Forms.Label();
            this.cbxClient = new System.Windows.Forms.ComboBox();
            this.lblCommentaire = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtCommentaire = new System.Windows.Forms.TextBox();
            this.pnlcentre = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.clmId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmNom_Client = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm_Rappel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm_E_mail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clm_Tel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.pnltop.SuspendLayout();
            this.pnlgauche.SuspendLayout();
            this.pnlcentre.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnltop
            // 
            this.pnltop.Controls.Add(this.ckbRappelProchain);
            this.pnltop.Controls.Add(this.btnRefresh);
            this.pnltop.Controls.Add(this.btnNew);
            this.pnltop.Controls.Add(this.lblRappel);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(1058, 65);
            this.pnltop.TabIndex = 0;
            // 
            // ckbRappelProchain
            // 
            this.ckbRappelProchain.AutoSize = true;
            this.ckbRappelProchain.Location = new System.Drawing.Point(382, 22);
            this.ckbRappelProchain.Name = "ckbRappelProchain";
            this.ckbRappelProchain.Size = new System.Drawing.Size(295, 21);
            this.ckbRappelProchain.TabIndex = 8;
            this.ckbRappelProchain.Text = "Afficher uniquement les prochains rappels";
            this.ckbRappelProchain.UseVisualStyleBackColor = true;
            this.ckbRappelProchain.CheckedChanged += new System.EventHandler(this.ckbRappelProchain_CheckedChanged);
            // 
            // lblRappel
            // 
            this.lblRappel.AutoSize = true;
            this.lblRappel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRappel.ForeColor = System.Drawing.Color.Blue;
            this.lblRappel.Location = new System.Drawing.Point(13, 13);
            this.lblRappel.Name = "lblRappel";
            this.lblRappel.Size = new System.Drawing.Size(176, 25);
            this.lblRappel.TabIndex = 0;
            this.lblRappel.Text = "Liste des rappels";
            // 
            // pnlgauche
            // 
            this.pnlgauche.Controls.Add(this.lblIDRAPPEL);
            this.pnlgauche.Controls.Add(this.cbxClient);
            this.pnlgauche.Controls.Add(this.lblCommentaire);
            this.pnlgauche.Controls.Add(this.dateTimePicker1);
            this.pnlgauche.Controls.Add(this.txtCommentaire);
            this.pnlgauche.Controls.Add(this.btnSave);
            this.pnlgauche.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlgauche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlgauche.ForeColor = System.Drawing.Color.Black;
            this.pnlgauche.Location = new System.Drawing.Point(0, 65);
            this.pnlgauche.Name = "pnlgauche";
            this.pnlgauche.Size = new System.Drawing.Size(382, 769);
            this.pnlgauche.TabIndex = 1;
            // 
            // lblIDRAPPEL
            // 
            this.lblIDRAPPEL.AutoSize = true;
            this.lblIDRAPPEL.ForeColor = System.Drawing.Color.Blue;
            this.lblIDRAPPEL.Location = new System.Drawing.Point(13, 17);
            this.lblIDRAPPEL.Name = "lblIDRAPPEL";
            this.lblIDRAPPEL.Size = new System.Drawing.Size(124, 25);
            this.lblIDRAPPEL.TabIndex = 9;
            this.lblIDRAPPEL.Text = "ID Rappel : 0";
            // 
            // cbxClient
            // 
            this.cbxClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxClient.Items.AddRange(new object[] {
            "Choisissez un client"});
            this.cbxClient.Location = new System.Drawing.Point(17, 59);
            this.cbxClient.Name = "cbxClient";
            this.cbxClient.Size = new System.Drawing.Size(335, 33);
            this.cbxClient.TabIndex = 3;
            // 
            // lblCommentaire
            // 
            this.lblCommentaire.AutoSize = true;
            this.lblCommentaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommentaire.ForeColor = System.Drawing.Color.Blue;
            this.lblCommentaire.Location = new System.Drawing.Point(13, 172);
            this.lblCommentaire.Name = "lblCommentaire";
            this.lblCommentaire.Size = new System.Drawing.Size(129, 25);
            this.lblCommentaire.TabIndex = 7;
            this.lblCommentaire.Text = "Commentaire";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(17, 117);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(335, 30);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // txtCommentaire
            // 
            this.txtCommentaire.Location = new System.Drawing.Point(18, 200);
            this.txtCommentaire.Multiline = true;
            this.txtCommentaire.Name = "txtCommentaire";
            this.txtCommentaire.Size = new System.Drawing.Size(334, 155);
            this.txtCommentaire.TabIndex = 5;
            // 
            // pnlcentre
            // 
            this.pnlcentre.Controls.Add(this.listView1);
            this.pnlcentre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlcentre.Location = new System.Drawing.Point(382, 65);
            this.pnlcentre.Name = "pnlcentre";
            this.pnlcentre.Size = new System.Drawing.Size(676, 769);
            this.pnlcentre.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmId,
            this.clmNom_Client,
            this.clm_date,
            this.clm_Rappel,
            this.clm_E_mail,
            this.clm_Tel});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(676, 769);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // clmId
            // 
            this.clmId.Text = "ID";
            this.clmId.Width = 46;
            // 
            // clmNom_Client
            // 
            this.clmNom_Client.Text = "Client";
            this.clmNom_Client.Width = 128;
            // 
            // clm_date
            // 
            this.clm_date.Text = "Date";
            this.clm_date.Width = 140;
            // 
            // clm_Rappel
            // 
            this.clm_Rappel.Text = "Description Rappel";
            this.clm_Rappel.Width = 790;
            // 
            // clm_E_mail
            // 
            this.clm_E_mail.Text = "E-mail";
            this.clm_E_mail.Width = 93;
            // 
            // clm_Tel
            // 
            this.clm_Tel.Text = "Téléphone";
            this.clm_Tel.Width = 108;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::UcRappels.Properties.Resources.diskette1;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(117, 394);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 96);
            this.btnSave.TabIndex = 6;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::UcRappels.Properties.Resources.refresh;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Location = new System.Drawing.Point(795, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(65, 60);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnNew
            // 
            this.btnNew.AccessibleDescription = "";
            this.btnNew.BackgroundImage = global::UcRappels.Properties.Resources.add;
            this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNew.Location = new System.Drawing.Point(691, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(65, 60);
            this.btnNew.TabIndex = 1;
            this.btnNew.Tag = "";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // UcRappel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 834);
            this.Controls.Add(this.pnlcentre);
            this.Controls.Add(this.pnlgauche);
            this.Controls.Add(this.pnltop);
            this.Name = "UcRappel";
            this.Text = "UcRappel";
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            this.pnlgauche.ResumeLayout(false);
            this.pnlgauche.PerformLayout();
            this.pnlcentre.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.Panel pnlgauche;
        private System.Windows.Forms.Panel pnlcentre;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblRappel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtCommentaire;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblCommentaire;
        private System.Windows.Forms.ComboBox cbxClient;
        private System.Windows.Forms.ColumnHeader clmId;
        private System.Windows.Forms.ColumnHeader clm_date;
        private System.Windows.Forms.ColumnHeader clmNom_Client;
        private System.Windows.Forms.ColumnHeader clm_Rappel;
        private System.Windows.Forms.ColumnHeader clm_E_mail;
        private System.Windows.Forms.ColumnHeader clm_Tel;
        private System.Windows.Forms.Label lblIDRAPPEL;
        private System.Windows.Forms.CheckBox ckbRappelProchain;
    }
}

