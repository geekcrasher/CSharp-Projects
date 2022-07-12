using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TowerOfHanoi
{
    public partial class TowerOfHanoi : Form
    {
        public TowerOfHanoi()
        {
            InitializeComponent();
        }

        private void blueBar_MouseDown(object sender, MouseEventArgs e)
        {
            //var blueImg = blueBar.Image;
            //if (blueBar == null) return;
            //if (DoDragDrop(blueImg, DragDropEffects.Move) == DragDropEffects.Move){
            //    blueBar.Image = null;
            //}
        }

        private void blueBar_Click(object sender, EventArgs e)
        {
            int blueLoc = blueBar.Location.X;               // X coordinate of blue is stored in this variable
            int greenLoc = greenBar.Location.X;             // X coordinate of green is stored in this variable
            int redLoc = redBar.Location.X;                 // X coordinate of red is stored in this variable 
            int yBlue = blueBar.Location.Y;                 // Y coordinate of blue is stored in this variable
            int yGreen = greenBar.Location.Y;               // Y coordinate of green is stored in this variable 
            int yRed = redBar.Location.Y;                   // Y coordinate of red is stored in this variable

            // Movement Blue

            switch (blueLoc, greenLoc, redLoc)
            {
                case (130, 105, 85):
                    blueBar.Location = new Point(450, 445); break;
                case (450, 105, 85):
                    blueBar.Location = new Point(760, 445); break;
                case (760, 105, 85):
                    blueBar.Location = new Point(130, 375); break;
                case (450, 735, 85):
                    blueBar.Location = new Point(760, 410); break;
                case (760, 735, 85):
                    blueBar.Location = new Point(130, 410); break;
                case (130, 735, 85):
                    blueBar.Location = new Point(450, 445); break;
                case (760, 425, 85):
                    blueBar.Location = new Point(130, 410); break;
                case (130, 425, 85):
                    blueBar.Location = new Point(450, 410); break;
                case (450, 425, 85):
                    blueBar.Location = new Point(760, 445); break;
            }

            switch (blueLoc, greenLoc, redLoc)
            {

                case (450, 105, 400):
                    blueBar.Location = new Point(760, 445); break;
                case (760, 105, 400):
                    blueBar.Location = new Point(130, 410); break;
                case (130, 105, 400):
                    blueBar.Location = new Point(450, 410); break;
                case (130, 425, 400):
                    blueBar.Location = new Point(450, 375); break;
                case (450, 425, 400):
                    blueBar.Location = new Point(760, 445); break;
                case (760, 425, 400):
                    blueBar.Location = new Point(130, 445); break;
                case (760, 735, 400):
                    blueBar.Location = new Point(130, 445); break;
                case (130, 735, 400):
                    blueBar.Location = new Point(450, 410); break;
                case (450, 735, 400):
                    blueBar.Location = new Point(760, 410); break;
                case (130, 105, 715):
                    blueBar.Location = new Point(450, 445); break;
                case (450, 105, 715):
                    blueBar.Location = new Point(760, 410); break;
                case (760, 105, 715):
                    blueBar.Location = new Point(130, 410); break;
                case (450, 425, 715):
                    blueBar.Location = new Point(760, 410); break;
                case (760, 425, 715):
                    blueBar.Location = new Point(130, 445); break;
                case (130, 425, 715):
                    blueBar.Location = new Point(450, 410); break;
                case (130, 735, 715):
                    blueBar.Location = new Point(760, 375); break;
                case (450, 735, 715):
                    blueBar.Location = new Point(760, 375); break;
            }

            // A message box will appear if all the colors are successfully placed in the Tower 3

            string tabName = "Congratulations!";
            string message = "You successfully placed the 3 colors in the Tower 3.";
            MessageBoxButtons click = MessageBoxButtons.OK;

            if ((blueLoc == 760 && yBlue == 375) && (greenLoc == 735 && yGreen == 410)
                                                 && (redLoc == 715 && yRed == 445))
            {
                MessageBox.Show(message, tabName, click, MessageBoxIcon.Information);
            }

        }

        private void greenBar_Click(object sender, EventArgs e)
        {
            int blueLoc = blueBar.Location.X;          // X coordinate of blue is stored in this variable
            int greenLoc = greenBar.Location.X;        // X coordinate of green is stored in this variable 
            int redLoc = redBar.Location.X;            // X coordinate of redis stored in this variable 

            // Movement of Green

            switch (blueLoc, greenLoc, redLoc)
            {
                case (450, 105, 85):
                    greenBar.Location = new Point(735, 445); break;
                case (450, 735, 85):
                    greenBar.Location = new Point(105, 410); break;
                case (760, 105, 85):
                    greenBar.Location = new Point(425, 445); break;
                case (760, 425, 85):
                    greenBar.Location = new Point(105, 410); break;
                case (130, 735, 85):
                    greenBar.Location = new Point(425, 445); break;
                case (130, 425, 85):
                    greenBar.Location = new Point(735, 445); break;
                case (130, 735, 400):
                    greenBar.Location = new Point(425, 410); break;
                case (130, 425, 400):
                    greenBar.Location = new Point(735, 445); break;
                case (450, 735, 400):
                    greenBar.Location = new Point(105, 445); break;
                case (450, 105, 400):
                    greenBar.Location = new Point(735, 445); break;
                case (760, 425, 400):
                    greenBar.Location = new Point(105, 445); break;
                case (450, 105, 715):
                    greenBar.Location = new Point(735, 410); break;
                case (130, 425, 715):
                    greenBar.Location = new Point(735, 410); break;
            }

        }

        private void redBar_Click(object sender, EventArgs e)
        {
            int blueLoc = blueBar.Location.X;       // X coordinate of blue is stored in this variable
            int greenLoc = greenBar.Location.X;     // X coordinate of green is stored in this variable 
            int redLoc = redBar.Location.X;         // X coordinate of red is stored in this variable 

            // Movement Red

            switch (blueLoc, greenLoc, redLoc)
            {
                case (760, 735, 85):
                    redBar.Location = new Point(400, 445); break;
                case (450, 425, 85):
                    redBar.Location = new Point(715, 445); break;
                case (760, 735, 400):
                    redBar.Location = new Point(85, 445); break;
                case (130, 105, 400):
                    redBar.Location = new Point(715, 445); break;
            }

        }
    }
}


