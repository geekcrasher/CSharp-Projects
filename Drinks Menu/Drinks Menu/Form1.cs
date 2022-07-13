using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drinks_Menu
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void gtrdPlus_Click(object sender, EventArgs e)
        {
            // To add the quantity of Gatorade that the customer wanted to avail
            int gtrdCurrentQty = Convert.ToInt32(gtrdQty.Text);
            gtrdQty.Text = Convert.ToString(++gtrdCurrentQty);
           
        }

        private void gtrdMinus_Click(object sender, EventArgs e)
        {
            int gtrdCurrentQty = Convert.ToInt32(gtrdQty.Text);

            // To avoid having negative quantity in the product
            if (gtrdCurrentQty > 0){                                
                gtrdQty.Text = Convert.ToString(--gtrdCurrentQty); 
            }
        }

        private void cokePlus_Click(object sender, EventArgs e)
        {
            // To add the quantity of Coca Cola that the customer wanted to avail
            int cokeCurrentQty = Convert.ToInt32(cokeQty.Text);
            cokeQty.Text = Convert.ToString(++cokeCurrentQty);
        }

        private void cokeMinus_Click(object sender, EventArgs e)
        {
            int cokeCurrentQty = Convert.ToInt32(cokeQty.Text);
           
            // To avoid having negative quantity in the product
            if (cokeCurrentQty > 0) {
                cokeQty.Text = Convert.ToString(--cokeCurrentQty);
            }
        }

        private void pepsiPlus_Click(object sender, EventArgs e)
        {
            // To add the quantity of Pepsi that the customer wanted to avail
            int pepsiCurrentQty = Convert.ToInt32(pepsiQty.Text);
            pepsiQty.Text = Convert.ToString(++pepsiCurrentQty);
        }

        private void pepsiMinus_Click(object sender, EventArgs e)
        {
            int pepsiCurrentQty = Convert.ToInt32(pepsiQty.Text);

            // To avoid having negative quantity in the product
            if (pepsiCurrentQty > 0) {
                pepsiQty.Text = Convert.ToString(--pepsiCurrentQty);
            }
        }

        private void mirindaPlus_Click(object sender, EventArgs e)
        {
            // To add the quantity of Mirinda that the customer wanted to avail
            int mirindaCurrentQty = Convert.ToInt32(mirindaQty.Text);
            mirindaQty.Text = Convert.ToString(++mirindaCurrentQty);
        }

        private void mirindaMinus_Click(object sender, EventArgs e)
        {
            int mirindaCurrentQty = Convert.ToInt32(mirindaQty.Text);

            // To avoid having negative quantity in the product
            if (mirindaCurrentQty > 0){
                mirindaQty.Text = Convert.ToString(--mirindaCurrentQty);
            }
        }

        private void mtndewPlus_Click(object sender, EventArgs e)
        {
            // To add the quantity of Mountain Dew that the customer wanted to avail
            int mtndewCurrentQty = Convert.ToInt32(mtndewQty.Text);
            mtndewQty.Text = Convert.ToString(++mtndewCurrentQty);
        }

        private void mtndewMinus_Click(object sender, EventArgs e)
        {
            int mtndewCurrentQty = Convert.ToInt32(mtndewQty.Text);
            
            // To avoid having negative quantity in the product
            if (mtndewCurrentQty > 0) {
                mtndewQty.Text = Convert.ToString(--mtndewCurrentQty);
            }
        }

        private void totalAmount_Click(object sender, EventArgs e)
        {
            const double vat = 0.12;                            // Current vat is 0.12
            const double gtrdPrice = 38.75;                     // Price of Gatorade per bottle
            const double cokePrice = 23.25;                     // Price of Coca Cola per bottle
            const double pepsiPrice = 21.50;                    // Price of Pepsi per bottle
            const double mirindaPrice = 22.25;                  // Price of Mirinda per bottle
            const double mtndewPrice = 21.75;                   // Price of mtndew per bottle

            // Final Price of Gatorade
            int gtrdCurrentQty = Convert.ToInt32(gtrdQty.Text);
            double gtrdTotalAmount = gtrdPrice * gtrdCurrentQty;
            gtrdTotalAmount = gtrdTotalAmount + (gtrdTotalAmount * vat);

            // Final Price of Coca Cola
            int cokeCurrentQty = Convert.ToInt32(cokeQty.Text);
            double cokeTotalAmount = cokePrice * cokeCurrentQty;
            cokeTotalAmount = cokeTotalAmount + (cokeTotalAmount * 0.12);

            // Final Price of Pepsi
            int pepsiCurrentQty = Convert.ToInt32(pepsiQty.Text);
            double pepsiTotalAmount = pepsiPrice * pepsiCurrentQty;
            pepsiTotalAmount = pepsiTotalAmount + (pepsiTotalAmount * 0.12);

            // Final Price of Mirinda
            int mirindaCurrentQty = Convert.ToInt32(mirindaQty.Text);
            double mirindaTotalAmount = mirindaPrice * mirindaCurrentQty;
            mirindaTotalAmount = mirindaTotalAmount + (mirindaTotalAmount * 0.12);

            // Final Price of Mountain Dew
            int mtndewCurrentQty = Convert.ToInt32(mtndewQty.Text);
            double mtndewTotalAmount = mtndewPrice * mtndewCurrentQty;
            mtndewTotalAmount = mtndewTotalAmount + (mtndewTotalAmount * 0.12);

           
            // To display the Total Amount in the label
            double drinksFinalPrice = gtrdTotalAmount + cokeTotalAmount + pepsiTotalAmount +
                                                        mirindaTotalAmount + mtndewTotalAmount;


           // double billOfDrinks = Convert.ToDouble(finalPrice.Text);
            double drinksPriceList = drinksFinalPrice;
            finalPrice.Text = Convert.ToString(drinksPriceList);
        
            // Display the output
            string title = "Your bill.";
            string inform = "Total Amount to be paid: " + (gtrdTotalAmount
                                                        + cokeTotalAmount
                                                        + pepsiTotalAmount
                                                        + mirindaTotalAmount
                                                        + mtndewTotalAmount); 
            MessageBoxButtons click = MessageBoxButtons.OK;
            MessageBox.Show(inform, title, click, MessageBoxIcon.Information);
        }

    }
}
