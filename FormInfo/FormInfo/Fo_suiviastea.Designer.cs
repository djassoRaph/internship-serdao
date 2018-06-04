namespace FormInfo
{
    partial class Fo_suiviastea
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
            this.components = new System.ComponentModel.Container();
            this.lblHotliner = new System.Windows.Forms.Label();
            this.maListView = new System.Windows.Forms.ListView();
            this.clnmhd_numero_ticket = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnhd_emailPrise_en_Compte = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnhd_emailTransfere = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnmhd_EmailCloture = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnmhd_hotliner = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnmhd_date_de_creation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnmhd_format_demande = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnmhd_nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnmhd_telephone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnmhd_e_mail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnmhd_ref = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnmhd_profil = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnmhd_affaire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnmhd_cat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnmhd_crit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnmhd_Niv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnhd_action = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnhd_date_resou = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnhd_heure = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnhd_delais = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmnhd_cloture = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envoiMailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envoiMailDeTransferTechnicienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envoiMailDeClôtureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHotliner
            // 
            this.lblHotliner.AutoSize = true;
            this.lblHotliner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHotliner.ForeColor = System.Drawing.Color.Blue;
            this.lblHotliner.Location = new System.Drawing.Point(12, 13);
            this.lblHotliner.Name = "lblHotliner";
            this.lblHotliner.Size = new System.Drawing.Size(426, 25);
            this.lblHotliner.TabIndex = 27;
            this.lblHotliner.Text = "Hotline SOGETREL, XXXXXXXX, Bonjour!";
            // 
            // maListView
            // 
            this.maListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnmhd_numero_ticket,
            this.clmnhd_emailPrise_en_Compte,
            this.clmnhd_emailTransfere,
            this.clnmhd_EmailCloture,
            this.clnmhd_hotliner,
            this.clnmhd_date_de_creation,
            this.clnmhd_format_demande,
            this.clnmhd_nom,
            this.clnmhd_telephone,
            this.clnmhd_e_mail,
            this.clnmhd_ref,
            this.clnmhd_profil,
            this.clnmhd_affaire,
            this.clnmhd_cat,
            this.clnmhd_crit,
            this.columnHeader2,
            this.clnmhd_Niv,
            this.clmnhd_action,
            this.clmnhd_date_resou,
            this.clmnhd_heure,
            this.clmnhd_delais,
            this.clmnhd_cloture});
            this.maListView.ContextMenuStrip = this.contextMenuStrip1;
            this.maListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maListView.FullRowSelect = true;
            this.maListView.Location = new System.Drawing.Point(0, 0);
            this.maListView.MultiSelect = false;
            this.maListView.Name = "maListView";
            this.maListView.Size = new System.Drawing.Size(1054, 208);
            this.maListView.TabIndex = 26;
            this.maListView.UseCompatibleStateImageBehavior = false;
            this.maListView.View = System.Windows.Forms.View.Details;
            this.maListView.DoubleClick += new System.EventHandler(this.maListView_DoubleClick);
            // 
            // clnmhd_numero_ticket
            // 
            this.clnmhd_numero_ticket.Text = "N° Ticket";
            this.clnmhd_numero_ticket.Width = 121;
            // 
            // clmnhd_emailPrise_en_Compte
            // 
            this.clmnhd_emailPrise_en_Compte.Text = "Email PEC";
            this.clmnhd_emailPrise_en_Compte.Width = 80;
            // 
            // clmnhd_emailTransfere
            // 
            this.clmnhd_emailTransfere.Text = "Email Transfer";
            this.clmnhd_emailTransfere.Width = 99;
            // 
            // clnmhd_EmailCloture
            // 
            this.clnmhd_EmailCloture.Text = "Email Cloture";
            this.clnmhd_EmailCloture.Width = 94;
            // 
            // clnmhd_hotliner
            // 
            this.clnmhd_hotliner.Text = "Hotliner";
            // 
            // clnmhd_date_de_creation
            // 
            this.clnmhd_date_de_creation.Text = "Date de Création";
            this.clnmhd_date_de_creation.Width = 121;
            // 
            // clnmhd_format_demande
            // 
            this.clnmhd_format_demande.Text = "Format demande ";
            this.clnmhd_format_demande.Width = 127;
            // 
            // clnmhd_nom
            // 
            this.clnmhd_nom.Text = "Nom";
            this.clnmhd_nom.Width = 106;
            // 
            // clnmhd_telephone
            // 
            this.clnmhd_telephone.Text = "Telephone";
            this.clnmhd_telephone.Width = 89;
            // 
            // clnmhd_e_mail
            // 
            this.clnmhd_e_mail.Text = "E-mail";
            this.clnmhd_e_mail.Width = 151;
            // 
            // clnmhd_ref
            // 
            this.clnmhd_ref.Text = "Référence Client";
            this.clnmhd_ref.Width = 144;
            // 
            // clnmhd_profil
            // 
            this.clnmhd_profil.Text = "Profil";
            this.clnmhd_profil.Width = 164;
            // 
            // clnmhd_affaire
            // 
            this.clnmhd_affaire.Text = "Affaire";
            this.clnmhd_affaire.Width = 159;
            // 
            // clnmhd_cat
            // 
            this.clnmhd_cat.Text = "Catégorie";
            this.clnmhd_cat.Width = 154;
            // 
            // clnmhd_crit
            // 
            this.clnmhd_crit.Text = "Criticité";
            this.clnmhd_crit.Width = 126;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 152;
            // 
            // clnmhd_Niv
            // 
            this.clnmhd_Niv.Text = "Niveau de résolution";
            this.clnmhd_Niv.Width = 152;
            // 
            // clmnhd_action
            // 
            this.clmnhd_action.Text = "Action";
            // 
            // clmnhd_date_resou
            // 
            this.clmnhd_date_resou.Text = "Date de résolution";
            this.clmnhd_date_resou.Width = 138;
            // 
            // clmnhd_heure
            // 
            this.clmnhd_heure.Text = "Heure de résolution";
            this.clmnhd_heure.Width = 143;
            // 
            // clmnhd_delais
            // 
            this.clmnhd_delais.Text = "Delais de résolution";
            this.clmnhd_delais.Width = 154;
            // 
            // clmnhd_cloture
            // 
            this.clmnhd_cloture.Text = "Clôture";
            this.clmnhd_cloture.Width = 116;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem,
            this.ouvrirToolStripMenuItem,
            this.envoiMailToolStripMenuItem,
            this.envoiMailDeTransferTechnicienToolStripMenuItem,
            this.envoiMailDeClôtureToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(298, 152);
            // 
            // nouveauToolStripMenuItem
            // 
            this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
            this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(297, 24);
            this.nouveauToolStripMenuItem.Text = "Nouveau";
            this.nouveauToolStripMenuItem.Click += new System.EventHandler(this.nouveauToolStripMenuItem_Click);
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(297, 24);
            this.ouvrirToolStripMenuItem.Text = "Ouvrir";
            this.ouvrirToolStripMenuItem.Click += new System.EventHandler(this.ouvrirToolStripMenuItem_Click);
            // 
            // envoiMailToolStripMenuItem
            // 
            this.envoiMailToolStripMenuItem.Name = "envoiMailToolStripMenuItem";
            this.envoiMailToolStripMenuItem.Size = new System.Drawing.Size(297, 24);
            this.envoiMailToolStripMenuItem.Text = "Envoi Mail de Prise en Compte";
            this.envoiMailToolStripMenuItem.Click += new System.EventHandler(this.envoiMailToolStripMenuItem_Click);
            // 
            // envoiMailDeTransferTechnicienToolStripMenuItem
            // 
            this.envoiMailDeTransferTechnicienToolStripMenuItem.Name = "envoiMailDeTransferTechnicienToolStripMenuItem";
            this.envoiMailDeTransferTechnicienToolStripMenuItem.Size = new System.Drawing.Size(297, 24);
            this.envoiMailDeTransferTechnicienToolStripMenuItem.Text = "Envoi Mail de Transfer Technicien";
            this.envoiMailDeTransferTechnicienToolStripMenuItem.Click += new System.EventHandler(this.envoiMailDeTransferTechnicienToolStripMenuItem_Click);
            // 
            // envoiMailDeClôtureToolStripMenuItem
            // 
            this.envoiMailDeClôtureToolStripMenuItem.Name = "envoiMailDeClôtureToolStripMenuItem";
            this.envoiMailDeClôtureToolStripMenuItem.Size = new System.Drawing.Size(297, 24);
            this.envoiMailDeClôtureToolStripMenuItem.Text = "Envoi Mail de Clôture";
            this.envoiMailDeClôtureToolStripMenuItem.Click += new System.EventHandler(this.envoiMailDeClôtureToolStripMenuItem_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(735, 13);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(147, 41);
            this.btnOpen.TabIndex = 24;
            this.btnOpen.Text = "Ouvrir";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnNouveau
            // 
            this.btnNouveau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNouveau.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNouveau.Location = new System.Drawing.Point(555, 13);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(163, 41);
            this.btnNouveau.TabIndex = 25;
            this.btnNouveau.Text = "Nouveau";
            this.btnNouveau.UseVisualStyleBackColor = true;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSendEmail);
            this.panel1.Controls.Add(this.btnNouveau);
            this.panel1.Controls.Add(this.lblHotliner);
            this.panel1.Controls.Add(this.btnOpen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1054, 87);
            this.panel1.TabIndex = 28;
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendEmail.Location = new System.Drawing.Point(889, 13);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(145, 41);
            this.btnSendEmail.TabIndex = 28;
            this.btnSendEmail.Text = "Envoi Mail";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.maListView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1054, 208);
            this.panel2.TabIndex = 29;
            // 
            // Fo_suiviastea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 295);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Fo_suiviastea";
            this.Text = "SOGETREL HOTLINE SERVICE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHotliner;
        private System.Windows.Forms.ListView maListView;
        private System.Windows.Forms.ColumnHeader clnmhd_numero_ticket;
        private System.Windows.Forms.ColumnHeader clnmhd_hotliner;
        private System.Windows.Forms.ColumnHeader clnmhd_date_de_creation;
        private System.Windows.Forms.ColumnHeader clnmhd_format_demande;
        private System.Windows.Forms.ColumnHeader clnmhd_nom;
        private System.Windows.Forms.ColumnHeader clnmhd_telephone;
        private System.Windows.Forms.ColumnHeader clnmhd_e_mail;
        private System.Windows.Forms.ColumnHeader clnmhd_ref;
        private System.Windows.Forms.ColumnHeader clnmhd_profil;
        private System.Windows.Forms.ColumnHeader clnmhd_affaire;
        private System.Windows.Forms.ColumnHeader clnmhd_cat;
        private System.Windows.Forms.ColumnHeader clnmhd_crit;
        private System.Windows.Forms.ColumnHeader clnmhd_Niv;
        private System.Windows.Forms.ColumnHeader clmnhd_action;
        private System.Windows.Forms.ColumnHeader clmnhd_date_resou;
        private System.Windows.Forms.ColumnHeader clmnhd_heure;
        private System.Windows.Forms.ColumnHeader clmnhd_delais;
        private System.Windows.Forms.ColumnHeader clmnhd_cloture;
        private System.Windows.Forms.ColumnHeader clmnhd_emailPrise_en_Compte;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.ToolStripMenuItem envoiMailToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader clmnhd_emailTransfere;
        private System.Windows.Forms.ColumnHeader clnmhd_EmailCloture;
        private System.Windows.Forms.ToolStripMenuItem envoiMailDeTransferTechnicienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envoiMailDeClôtureToolStripMenuItem;
    }
}

