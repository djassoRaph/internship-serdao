using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RichTextController
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();


        }
        float currentSize; // This is used to change the size of the current text; 
        Font currentFont;


        #region Externalcommands
        public string CollectTextintoRTF(string datagridviewtext)
        {
            return rtbx_1.Rtf = datagridviewtext;
        }
        public string rawTextForDatabase()
        {
            return rtbx_1.Rtf.ToString();
        }
        public string RTBtoDefault()
        {
            return rtbx_1.Rtf = "";
        }
        public string TexttoRTB(string text)
        {
           return rtbx_1.Text = text;
        }
        public string RtftexttoStringtoRtf(RichTextBox text)
        {
            return rtbx_1.Rtf = text.ToString();
        }
        #endregion

        #region Buttons
        #region Text size
        #region font size changing methods

        public void plus_font_size()
        {
            if (rtbx_1.SelectedText != null)
            {
                if (!string.IsNullOrEmpty(rtbx_1.SelectedText))
                {
                    currentSize = rtbx_1.SelectionFont.SizeInPoints;
                    currentSize += 2.0F;
                    rtbx_1.SelectionFont = new Font(rtbx_1.Font.Name, currentSize,
                        rtbx_1.Font.Style, rtbx_1.Font.Unit);
                }
            }
        }

        public void minus_font_size()
        {

            if (rtbx_1.SelectedText != null)
            {
                if (!string.IsNullOrEmpty(rtbx_1.SelectedText))
                {
                    currentSize = rtbx_1.SelectionFont.SizeInPoints;
                    currentSize -= 1;
                    rtbx_1.SelectionFont = new Font(rtbx_1.Font.Name, currentSize,
                        rtbx_1.Font.Style);
                }

            }
        }
        #endregion
        private void tsb_size_plus_Click(object sender, EventArgs e)
        {
            plus_font_size();
        }

        private void tsb_size_minus_Click(object sender, EventArgs e)
        {
            minus_font_size();
        }
        #endregion
        #region Bold Italic Underline Method
        private void changeFontStyle(FontStyle style)
        { //takes a fontStyle as a parameter
            if (rtbx_1.TextLength > 0)
            {
                if (rtbx_1.SelectionLength > 0) //checks if any text is selected
                {
                    rtbx_1.SelectionFont = new System.Drawing.Font(rtbx_1.SelectionFont.Name, rtbx_1.SelectionFont.Size,
                        rtbx_1.SelectionFont.Style ^ style);
                } //sets the fontStyle to the value in the style variable
                else
                { //else change future text
                    rtbx_1.SelectionFont = new System.Drawing.Font(rtbx_1.SelectionFont.Name, rtbx_1.SelectionFont.Size,
                        rtbx_1.SelectionFont.Style ^ style);
                }
            }
        }

        public void change_bold(Font currentFont)
        {

            changeFontStyle(FontStyle.Bold);
        }
        public void change_italic(Font currentFont)
        {
            changeFontStyle(FontStyle.Italic);
        }
        public void change_underline(Font currentFont)
        {
            changeFontStyle(FontStyle.Underline);
        }

        private void tsb_bold_Click(object sender, EventArgs e)
        {
            Font font = rtbx_1.SelectionFont;
            change_bold(font);
        }

        private void tsb_italic_Click(object sender, EventArgs e)
        {
            Font font = rtbx_1.SelectionFont;
            change_italic(font);
        }

        private void tsb_underline_Click(object sender, EventArgs e)
        {
            Font font = rtbx_1.SelectionFont;
            change_underline(font);
        }

        #endregion
        #region Align text
        #region text align methods
        public void align_right()
        {


            rtbx_1.SelectionAlignment = HorizontalAlignment.Right;


        }
        public void align_center()
        {


            rtbx_1.SelectionAlignment = HorizontalAlignment.Center;


        }
        public void align_left()
        {


            rtbx_1.SelectionAlignment = HorizontalAlignment.Left;


        }
        #endregion
        private void tsb_text_left_Click(object sender, EventArgs e)
        {
            align_left();
        }

        private void tsb_text_middle_Click(object sender, EventArgs e)
        {
            align_center();
        }

        private void tsb_text_right_Click(object sender, EventArgs e)
        {

            align_right();
        }

        #endregion
        #region Listing of text
        #region LISTING TEXT METHODS
        public void bulletlistsimple()
        {
            rtbx_1.BulletIndent = 15;
            rtbx_1.SelectionBullet = true;
        }
        public void bulletlistnumbers()
        {
            string[] splitSelection = null;
            // If selection split selection else split everything
            if (this.rtbx_1.SelectionLength > 0)
            {
                splitSelection = this.rtbx_1.SelectedText.Replace("\r\n", "\n").Split("\n".ToCharArray());
            }
            else
            {
                splitSelection = this.rtbx_1.Text.Replace("\r\n", "\n").Split("\n".ToCharArray());
            }
            bool Exists = false;
            for (int i = 0; i < splitSelection.GetLength(0); i++)
            {
                // If Ordered List Allready exists in selection then remove else add
                if (!string.IsNullOrEmpty(splitSelection[i]))
                {
                    if (splitSelection[i].Substring(0, 2) == "1.") { Exists = true; }
                }
            }

            for (int i = 0; i < splitSelection.GetLength(0); i++)
            {
                int lineCount = (i + 1);
                if (Exists)
                {
                    this.rtbx_1.Text = this.rtbx_1.Text.Replace(Convert.ToString(lineCount) + ".  ", "");
                }
                else
                {
                    if (!string.IsNullOrEmpty(splitSelection[i]))
                    {
                        this.rtbx_1.Text = this.rtbx_1.Text.Replace(splitSelection[i], Convert.ToString(lineCount) + ".  " + splitSelection[i]);
                    }

                }
            }
        }
        #endregion
        private void tsb_list_num_Click(object sender, EventArgs e)
        {
            bulletlistnumbers();
        }

        private void tsb_list_dot_Click(object sender, EventArgs e)
        {
            bulletlistsimple();
        }
        #endregion
        #region Text Color choosing
        private void tsb_colors_Click(object sender, EventArgs e)
        {
            // Nothing
        }

        private void rougeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtbx_1.SelectedText != null)
            {
                if (!string.IsNullOrEmpty(rtbx_1.SelectedText))
                {

                    rtbx_1.SelectionColor = Color.Red;
                }
                else
                {

                }
            }
        }

        private void vertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtbx_1.SelectedText != null)
            {
                if (!string.IsNullOrEmpty(rtbx_1.SelectedText))
                {
                    rtbx_1.SelectionColor = Color.Black;
                }
            }
        }

        private void bleuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtbx_1.SelectedText != null)
            {
                if (!string.IsNullOrEmpty(rtbx_1.SelectedText))
                {
                    rtbx_1.SelectionColor = Color.Green;
                }
            }
        }

        private void boirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtbx_1.SelectedText != null)
            {
                if (!string.IsNullOrEmpty(rtbx_1.SelectedText))
                {
                    rtbx_1.SelectionColor = Color.Blue;
                }
            }
        }
        #endregion
        #region RightClicking elements
        private void couperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbx_1.Cut();
        }

        private void copierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbx_1.Copy();
        }

        private void collerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbx_1.Paste();
        }
        #endregion
        #endregion
    }
}
