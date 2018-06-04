namespace UcHNO
{
    partial class Fo_HNO
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
            this.lblIntro = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.pnlright = new System.Windows.Forms.Panel();
            this.maListView = new System.Windows.Forms.ListView();
            this.colNTicket = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colmDateHEure = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNomClient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColLieu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColNomApp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColPanneDecl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColObserv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColTechnicienApp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnltop.SuspendLayout();
            this.pnlright.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnltop
            // 
            this.pnltop.Controls.Add(this.lblIntro);
            this.pnltop.Controls.Add(this.btnNew);
            this.pnltop.Controls.Add(this.btnOpen);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(1523, 100);
            this.pnltop.TabIndex = 0;
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntro.ForeColor = System.Drawing.Color.Blue;
            this.lblIntro.Location = new System.Drawing.Point(825, 33);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(218, 25);
            this.lblIntro.TabIndex = 2;
            this.lblIntro.Text = "Label text Info à remplir!";
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.Black;
            this.btnNew.Location = new System.Drawing.Point(1158, 18);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(153, 54);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Nouveau";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.ForeColor = System.Drawing.Color.Black;
            this.btnOpen.Location = new System.Drawing.Point(1328, 18);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(159, 54);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Ouvrir";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // pnlright
            // 
            this.pnlright.Controls.Add(this.maListView);
            this.pnlright.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlright.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlright.Location = new System.Drawing.Point(830, 100);
            this.pnlright.Name = "pnlright";
            this.pnlright.Size = new System.Drawing.Size(693, 614);
            this.pnlright.TabIndex = 1;
            // 
            // maListView
            // 
            this.maListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNTicket,
            this.colmDateHEure,
            this.colNomClient,
            this.ColLieu,
            this.ColNomApp,
            this.ColPhone,
            this.ColPanneDecl,
            this.ColObserv,
            this.ColTechnicienApp});
            this.maListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maListView.FullRowSelect = true;
            this.maListView.Location = new System.Drawing.Point(0, 0);
            this.maListView.Name = "maListView";
            this.maListView.Size = new System.Drawing.Size(693, 614);
            this.maListView.TabIndex = 0;
            this.maListView.UseCompatibleStateImageBehavior = false;
            this.maListView.View = System.Windows.Forms.View.Details;
            this.maListView.DoubleClick += new System.EventHandler(this.maListView_DoubleClick);
            // 
            // colNTicket
            // 
            this.colNTicket.Text = "Numéro de ticket";
            this.colNTicket.Width = 192;
            // 
            // colmDateHEure
            // 
            this.colmDateHEure.Text = "Date et heure appel";
            this.colmDateHEure.Width = 196;
            // 
            // colNomClient
            // 
            this.colNomClient.Text = "Société Client";
            this.colNomClient.Width = 187;
            // 
            // ColLieu
            // 
            this.ColLieu.Text = "Site concerné / Adresse";
            this.ColLieu.Width = 191;
            // 
            // ColNomApp
            // 
            this.ColNomApp.Text = "Nom de l\'appelant";
            this.ColNomApp.Width = 207;
            // 
            // ColPhone
            // 
            this.ColPhone.Text = "N° de téléphone de l\'appelant";
            this.ColPhone.Width = 252;
            // 
            // ColPanneDecl
            // 
            this.ColPanneDecl.Text = "Panne déclarée par le client";
            this.ColPanneDecl.Width = 264;
            // 
            // ColObserv
            // 
            this.ColObserv.Text = "Observations";
            this.ColObserv.Width = 260;
            // 
            // ColTechnicienApp
            // 
            this.ColTechnicienApp.Text = "Technicien appelé";
            this.ColTechnicienApp.Width = 296;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 100);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(828, 614);
            this.pnlLeft.TabIndex = 2;
            // 
            // Fo_HNO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1523, 714);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlright);
            this.Controls.Add(this.pnltop);
            this.Name = "Fo_HNO";
            this.Text = "UcHNO";
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            this.pnlright.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.Panel pnlright;
        private System.Windows.Forms.ListView maListView;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.ColumnHeader colmDateHEure;
        private System.Windows.Forms.ColumnHeader colNTicket;
        private System.Windows.Forms.ColumnHeader colNomClient;
        private System.Windows.Forms.ColumnHeader ColLieu;
        private System.Windows.Forms.ColumnHeader ColNomApp;
        private System.Windows.Forms.ColumnHeader ColPhone;
        private System.Windows.Forms.ColumnHeader ColPanneDecl;
        private System.Windows.Forms.ColumnHeader ColTechnicienApp;
        private System.Windows.Forms.ColumnHeader ColObserv;
        private System.Windows.Forms.Panel pnlLeft;
    }
}

