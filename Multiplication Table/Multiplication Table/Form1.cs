using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiplication_Table
{
    public partial class multiplicationTable : Form
    {
        public multiplicationTable()
        {
            InitializeComponent();
        }

        private void multiplicationTable_Load(object sender, EventArgs e)
        {
            cmbMultiplier.SelectedItem = null;
            cmbMultiplier.SelectedText = "   ---- Select ----";
            this.BackColor = Color.FromArgb(131, 223, 220);                         // changing the background color of Form
        }

        private void cmbMultiplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            int multiplier = Convert.ToInt32(cmbMultiplier.Text);
            Label label;
            int xHorizLabel = 95;
            int yHorizLabel = 145;
            int xVerticLabel = 95;
            int yVerticLabel = 190;

            for(int horizontalIndex = 0; horizontalIndex <= multiplier; horizontalIndex++)
            {
                label = new Label();                                                // create a new lable
                label.Text = (horizontalIndex).ToString();                          // The selected mutiplier will add 1
                label.Location = new Point(xHorizLabel, yHorizLabel);               // Location of Multiplier in the control/form
                label.Font = new Font("Calibri", 13, FontStyle.Bold);               // Changing the font style and size
                label.ForeColor = Color.White;                                      // Set the color of fonts to white
                label.BackColor = Color.Teal;                                       // set the background color to Darkcyan
                label.AutoSize = false;                                                             
                label.Size = new System.Drawing.Size(35, 30);                       // modifies the height and width of label multipliers
                this.Controls.Add(label);                                           // add the created label to the form/control
                
                switch (horizontalIndex)
                {
                    case int horizontalRange when (horizontalIndex >= 5 && horizontalIndex <= 20):
                        label.Size = new System.Drawing.Size(45, 30); 
                        break;
                /*
                    case 10: label.Size = new System.Drawing.Size(45, 30); break;
                    case 11: label.Size = new System.Drawing.Size(45, 30); break;
                    case 12: label.Size = new System.Drawing.Size(45, 30); break;
                    case 13: label.Size = new System.Drawing.Size(45, 30); break;
                    case 14: label.Size = new System.Drawing.Size(45, 30); break;
                    case 15: label.Size = new System.Drawing.Size(45, 30); break;
                    case 16: label.Size = new System.Drawing.Size(45, 30); break;
                    case 17: label.Size = new System.Drawing.Size(45, 30); break;
                    case 18: label.Size = new System.Drawing.Size(45, 30); break;
                    case 19: label.Size = new System.Drawing.Size(45, 30); break;
                    case 20: label.Size = new System.Drawing.Size(45, 30); break;
                */

                }

                xHorizLabel += (label.Width + 10);                                  // spacing for each multiplier
          
            }
            
            for (int verticalIndex = 1; verticalIndex <= multiplier; verticalIndex++)
            {
                label = new Label();                                                // create a new lable
                label.Text = (verticalIndex).ToString();                            // The selected mutiplier will add 1
                label.Location = new Point(xVerticLabel, yVerticLabel);             // Location of Multiplier in the control/form
                label.Font = new Font("Calibri", 13, FontStyle.Bold);               // Changing the font style and size
                label.ForeColor = Color.White;                                      // Set the color of fonts to white
                label.BackColor = Color.Teal;                                       // set the background color to Darkcyan
                label.AutoSize = false;
                label.Size = new System.Drawing.Size(35,30);                        // modifies the height and width of label multipliers
                this.Controls.Add(label);                                           // add the created label in form/control

                yVerticLabel += label.Width;                                        // spacing for each multiplier

            }

            int xHorLbl = 140;
            int yVerLbl = 190;

            for (int horizon = 1; horizon <= multiplier; horizon++)
            {
                label = new Label();
                label.Text = horizon.ToString();
                
                for (int vertical = 1; vertical <= multiplier; vertical++)
                {
                    label = new Label();
                    label.Text = (horizon * vertical).ToString();
                    label.Location = new Point(xHorLbl, yVerLbl);
                    label.Font = new Font("Calibri", 13, FontStyle.Bold);
                    label.ForeColor = Color.Black;
                    label.BackColor = Color.LightSeaGreen;
                    label.AutoSize = false;
                    label.Size = new System.Drawing.Size(35, 30);
                    this.Controls.Add(label);
                   
                    switch (vertical)
                    {
                        case int verticalRange when (vertical >= 5 && vertical <= 20):
                            label.Size = new System.Drawing.Size(45, 30); 
                            break;

                    /*
                        case 10: label.Size = new System.Drawing.Size(45, 30); break;
                        case 11: label.Size = new System.Drawing.Size(45, 30); break;
                        case 12: label.Size = new System.Drawing.Size(45, 30); break;
                        case 13: label.Size = new System.Drawing.Size(45, 30); break;
                        case 14: label.Size = new System.Drawing.Size(45, 30); break;
                        case 15: label.Size = new System.Drawing.Size(45, 30); break;
                        case 16: label.Size = new System.Drawing.Size(45, 30); break;
                        case 17: label.Size = new System.Drawing.Size(45, 30); break;
                        case 18: label.Size = new System.Drawing.Size(45, 30); break;
                        case 19: label.Size = new System.Drawing.Size(45, 30); break;
                        case 20: label.Size = new System.Drawing.Size(45, 30); break;
                    */
                            
                    }

                    xHorLbl += label.Width+10;

                }
                xHorLbl = 140;
                yVerLbl += label.Width-10;

            }

            cmbMultiplier.Enabled = false;

        }
    }
}


