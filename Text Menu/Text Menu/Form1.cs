using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Menu
{
    public partial class textEditor : Form
    {
        public textEditor()
        {
            InitializeComponent();
        }

        private void textEditor_Load(object sender, EventArgs e)
        {
            boldButton.TabStop = italicButton.TabStop = underlineButton.TabStop = false;
            boldButton.FlatAppearance.BorderSize = 0;
            italicButton.FlatAppearance.BorderSize = 0;
            underlineButton.FlatAppearance.BorderSize = 0;

            foreach (FontFamily fStyle in FontFamily.Families)
            {
                cmbFontStyle.Items.Add(fStyle.Name.ToString());
            }
        }
      
        private void boldButton_Click(object sender, EventArgs e)
        {
            // check if the text box is empty or not

            if (string.IsNullOrEmpty(richText.Text)) 
            {
                MessageBox.Show("Text Box is Empty!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // To make the selected text turn into bold

            if (boldButton.BackColor == SystemColors.Control) 
            {
                boldButton.BackColor = SystemColors.ActiveBorder;
                richText.SelectionFont = new Font(richText.SelectionFont, FontStyle.Bold);
            }
            else 
            {
                boldButton.BackColor = SystemColors.Control;
                richText.SelectionFont = new Font(richText.SelectionFont, FontStyle.Regular);
            }


        }

        private void italicButton_Click(object sender, EventArgs e)
        {
            // check if the text box is empty or not

            if (string.IsNullOrEmpty(richText.Text))
            {
                MessageBox.Show("Text Box is Empty!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // To make the selected text turn into italic

            if (italicButton.BackColor == SystemColors.Control) 
            {
                italicButton.BackColor = SystemColors.ActiveBorder;
                richText.SelectionFont = new Font(richText.SelectionFont, FontStyle.Italic);
            }
            else {
                italicButton.BackColor = SystemColors.Control;
                richText.SelectionFont = new Font(richText.SelectionFont, FontStyle.Regular);
            }
            
        }

        private void underlineButton_Click(object sender, EventArgs e)
        {
            // check if the text box is empty or not

            if (string.IsNullOrEmpty(richText.Text))                                                           
            {
                MessageBox.Show("Text Box is Empty!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 

            // To make the selected text have an underline

            if (underlineButton.BackColor == SystemColors.Control) 
            {
                underlineButton.BackColor = SystemColors.ActiveBorder;
                richText.SelectionFont = new Font(richText.SelectionFont, FontStyle.Underline);
            }
            else 
            {
                underlineButton.BackColor = SystemColors.Control;
                richText.SelectionFont = new Font(richText.SelectionFont, FontStyle.Regular);
            }

        }
        private void cmbFontStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
             richText.SelectionFont = new Font(cmbFontStyle.Text, richText.Font.Size);

        }

        private void cmbFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
             int fontSize = Convert.ToInt32(cmbFontSize.Text);
             richText.SelectionFont = new Font(cmbFontStyle.Text, fontSize);

        }

        private void richText_TextChanged(object sender, EventArgs e)
        {

            if ((boldButton.BackColor == SystemColors.ActiveBorder) && (italicButton.BackColor == SystemColors.ActiveBorder)
                                                                    && (underlineButton.BackColor == SystemColors.ActiveBorder))
            {
                richText.SelectionFont = new Font(richText.Font, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            }
            else if ((boldButton.BackColor == SystemColors.ActiveBorder) && (italicButton.BackColor == SystemColors.ActiveBorder))
            {
                richText.SelectionFont = new Font(richText.Font, FontStyle.Bold | FontStyle.Italic);
            }
            else if ((boldButton.BackColor == SystemColors.ActiveBorder) && (underlineButton.BackColor == SystemColors.ActiveBorder))
            {
                richText.SelectionFont = new Font(richText.Font, FontStyle.Bold | FontStyle.Underline);
            }
            else if ((italicButton.BackColor == SystemColors.ActiveBorder) && (underlineButton.BackColor == SystemColors.ActiveBorder))
            {
                richText.SelectionFont = new Font(richText.Font, FontStyle.Italic | FontStyle.Underline);
            }


            // Added by Paulo
            // 11 - 30 - 21
            // Note1 #1: in case you choose a fontstyle and change the size and nothing happens, while the bold, italic, or underliined button
            //          is still activated, try to deactivate the said button, and after that try again.
            // Note #2: In case you you deactivate the button, italic, or underline button and change the font style and font size
            //          and still nothing happens, try to comment out this new added codes.

            /*
            else if (boldButton.BackColor == SystemColors.ActiveBorder)
            {
                richText.SelectionFont = new Font(richText.Font, FontStyle.Bold);
            }
            else if(italicButton.BackColor == SystemColors.ActiveBorder)
            {
                richText.SelectionFont = new Font(richText.Font, FontStyle.Italic);
            }
            else if (underlineButton.BackColor == SystemColors.ActiveBorder)
            {
                richText.SelectionFont = new Font(richText.Font, FontStyle.Underline);
            }
            */
        }

        private void clearAllMenu_Click(object sender, EventArgs e)
        {

            string tabName = "Warning";
            string message = "Are you sure you want to clear all the text?";
            MessageBoxButtons btn = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, tabName, btn, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                richText.Clear();
            }
            

        }
    }
}
