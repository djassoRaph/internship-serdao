namespace RichTextController
{
    partial class UserControl1
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

        #region Code généré par le Concepteur de composants

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_size_plus = new System.Windows.Forms.ToolStripButton();
            this.tsb_size_minus = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_colors = new System.Windows.Forms.ToolStripDropDownButton();
            this.rougeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bleuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_bold = new System.Windows.Forms.ToolStripButton();
            this.tsb_italic = new System.Windows.Forms.ToolStripButton();
            this.tsb_underline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_text_left = new System.Windows.Forms.ToolStripButton();
            this.tsb_text_middle = new System.Windows.Forms.ToolStripButton();
            this.tsb_text_right = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_list_num = new System.Windows.Forms.ToolStripButton();
            this.tsb_list_dot = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.rtbx_1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.couperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_size_plus,
            this.tsb_size_minus,
            this.toolStripSeparator1,
            this.tsb_colors,
            this.toolStripSeparator2,
            this.tsb_bold,
            this.tsb_italic,
            this.tsb_underline,
            this.toolStripSeparator3,
            this.tsb_text_left,
            this.tsb_text_middle,
            this.tsb_text_right,
            this.toolStripSeparator4,
            this.tsb_list_num,
            this.tsb_list_dot,
            this.toolStripSeparator5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(361, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_size_plus
            // 
            this.tsb_size_plus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_size_plus.Image = global::RichTextController.Properties.Resources.increase_font;
            this.tsb_size_plus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_size_plus.Name = "tsb_size_plus";
            this.tsb_size_plus.Size = new System.Drawing.Size(24, 24);
            this.tsb_size_plus.Text = "toolStripButton1";
            this.tsb_size_plus.Click += new System.EventHandler(this.tsb_size_plus_Click);
            // 
            // tsb_size_minus
            // 
            this.tsb_size_minus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_size_minus.Image = global::RichTextController.Properties.Resources.decrease_font;
            this.tsb_size_minus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_size_minus.Name = "tsb_size_minus";
            this.tsb_size_minus.Size = new System.Drawing.Size(24, 24);
            this.tsb_size_minus.Text = "toolStripButton2";
            this.tsb_size_minus.Click += new System.EventHandler(this.tsb_size_minus_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tsb_colors
            // 
            this.tsb_colors.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_colors.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rougeToolStripMenuItem,
            this.vertToolStripMenuItem,
            this.bleuToolStripMenuItem,
            this.boirToolStripMenuItem});
            this.tsb_colors.Image = global::RichTextController.Properties.Resources.color;
            this.tsb_colors.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_colors.Name = "tsb_colors";
            this.tsb_colors.Size = new System.Drawing.Size(34, 24);
            this.tsb_colors.Text = "toolStripButton3";
            this.tsb_colors.Click += new System.EventHandler(this.tsb_colors_Click);
            // 
            // rougeToolStripMenuItem
            // 
            this.rougeToolStripMenuItem.Image = global::RichTextController.Properties.Resources.redsquare;
            this.rougeToolStripMenuItem.Name = "rougeToolStripMenuItem";
            this.rougeToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.rougeToolStripMenuItem.Text = "Rouge";
            this.rougeToolStripMenuItem.Click += new System.EventHandler(this.rougeToolStripMenuItem_Click);
            // 
            // vertToolStripMenuItem
            // 
            this.vertToolStripMenuItem.Image = global::RichTextController.Properties.Resources.greensquare;
            this.vertToolStripMenuItem.Name = "vertToolStripMenuItem";
            this.vertToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.vertToolStripMenuItem.Text = "Vert";
            this.vertToolStripMenuItem.Click += new System.EventHandler(this.vertToolStripMenuItem_Click);
            // 
            // bleuToolStripMenuItem
            // 
            this.bleuToolStripMenuItem.Image = global::RichTextController.Properties.Resources.bluesquare;
            this.bleuToolStripMenuItem.Name = "bleuToolStripMenuItem";
            this.bleuToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.bleuToolStripMenuItem.Text = "Bleu";
            this.bleuToolStripMenuItem.Click += new System.EventHandler(this.bleuToolStripMenuItem_Click);
            // 
            // boirToolStripMenuItem
            // 
            this.boirToolStripMenuItem.Image = global::RichTextController.Properties.Resources.blacksquare;
            this.boirToolStripMenuItem.Name = "boirToolStripMenuItem";
            this.boirToolStripMenuItem.Size = new System.Drawing.Size(127, 26);
            this.boirToolStripMenuItem.Text = "Noir";
            this.boirToolStripMenuItem.Click += new System.EventHandler(this.boirToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tsb_bold
            // 
            this.tsb_bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_bold.Image = global::RichTextController.Properties.Resources.bold;
            this.tsb_bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_bold.Name = "tsb_bold";
            this.tsb_bold.Size = new System.Drawing.Size(24, 24);
            this.tsb_bold.Text = "toolStripButton4";
            this.tsb_bold.Click += new System.EventHandler(this.tsb_bold_Click);
            // 
            // tsb_italic
            // 
            this.tsb_italic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_italic.Image = global::RichTextController.Properties.Resources.italic;
            this.tsb_italic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_italic.Name = "tsb_italic";
            this.tsb_italic.Size = new System.Drawing.Size(24, 24);
            this.tsb_italic.Text = "toolStripButton5";
            this.tsb_italic.Click += new System.EventHandler(this.tsb_italic_Click);
            // 
            // tsb_underline
            // 
            this.tsb_underline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_underline.Image = global::RichTextController.Properties.Resources.underscore;
            this.tsb_underline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_underline.Name = "tsb_underline";
            this.tsb_underline.Size = new System.Drawing.Size(24, 24);
            this.tsb_underline.Text = "toolStripButton6";
            this.tsb_underline.Click += new System.EventHandler(this.tsb_underline_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // tsb_text_left
            // 
            this.tsb_text_left.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_text_left.Image = global::RichTextController.Properties.Resources.lj;
            this.tsb_text_left.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_text_left.Name = "tsb_text_left";
            this.tsb_text_left.Size = new System.Drawing.Size(24, 24);
            this.tsb_text_left.Text = "toolStripButton7";
            this.tsb_text_left.Click += new System.EventHandler(this.tsb_text_left_Click);
            // 
            // tsb_text_middle
            // 
            this.tsb_text_middle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_text_middle.Image = global::RichTextController.Properties.Resources.cj;
            this.tsb_text_middle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_text_middle.Name = "tsb_text_middle";
            this.tsb_text_middle.Size = new System.Drawing.Size(24, 24);
            this.tsb_text_middle.Text = "toolStripButton8";
            this.tsb_text_middle.Click += new System.EventHandler(this.tsb_text_middle_Click);
            // 
            // tsb_text_right
            // 
            this.tsb_text_right.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_text_right.Image = global::RichTextController.Properties.Resources.rj;
            this.tsb_text_right.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_text_right.Name = "tsb_text_right";
            this.tsb_text_right.Size = new System.Drawing.Size(24, 24);
            this.tsb_text_right.Text = "toolStripButton9";
            this.tsb_text_right.Click += new System.EventHandler(this.tsb_text_right_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // tsb_list_num
            // 
            this.tsb_list_num.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_list_num.Image = global::RichTextController.Properties.Resources.ol;
            this.tsb_list_num.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_list_num.Name = "tsb_list_num";
            this.tsb_list_num.Size = new System.Drawing.Size(24, 24);
            this.tsb_list_num.Text = "toolStripButton10";
            this.tsb_list_num.Click += new System.EventHandler(this.tsb_list_num_Click);
            // 
            // tsb_list_dot
            // 
            this.tsb_list_dot.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_list_dot.Image = global::RichTextController.Properties.Resources.uol;
            this.tsb_list_dot.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_list_dot.Name = "tsb_list_dot";
            this.tsb_list_dot.Size = new System.Drawing.Size(24, 24);
            this.tsb_list_dot.Text = "toolStripButton11";
            this.tsb_list_dot.Click += new System.EventHandler(this.tsb_list_dot_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // rtbx_1
            // 
            this.rtbx_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbx_1.Location = new System.Drawing.Point(0, 27);
            this.rtbx_1.Name = "rtbx_1";
            this.rtbx_1.Size = new System.Drawing.Size(361, 183);
            this.rtbx_1.TabIndex = 1;
            this.rtbx_1.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.couperToolStripMenuItem,
            this.copierToolStripMenuItem,
            this.collerToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(127, 76);
            // 
            // couperToolStripMenuItem
            // 
            this.couperToolStripMenuItem.Name = "couperToolStripMenuItem";
            this.couperToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.couperToolStripMenuItem.Text = "Couper";
            this.couperToolStripMenuItem.Click += new System.EventHandler(this.couperToolStripMenuItem_Click);
            // 
            // copierToolStripMenuItem
            // 
            this.copierToolStripMenuItem.Name = "copierToolStripMenuItem";
            this.copierToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.copierToolStripMenuItem.Text = "Copier";
            this.copierToolStripMenuItem.Click += new System.EventHandler(this.copierToolStripMenuItem_Click);
            // 
            // collerToolStripMenuItem
            // 
            this.collerToolStripMenuItem.Name = "collerToolStripMenuItem";
            this.collerToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.collerToolStripMenuItem.Text = "Coller";
            this.collerToolStripMenuItem.Click += new System.EventHandler(this.collerToolStripMenuItem_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtbx_1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(361, 210);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_size_plus;
        private System.Windows.Forms.ToolStripButton tsb_size_minus;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton tsb_colors;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsb_bold;
        private System.Windows.Forms.ToolStripButton tsb_italic;
        private System.Windows.Forms.ToolStripButton tsb_underline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsb_text_left;
        private System.Windows.Forms.ToolStripButton tsb_text_middle;
        private System.Windows.Forms.ToolStripButton tsb_text_right;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsb_list_num;
        private System.Windows.Forms.ToolStripButton tsb_list_dot;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem rougeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bleuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boirToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem couperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collerToolStripMenuItem;
        public System.Windows.Forms.RichTextBox rtbx_1;
    }
}
