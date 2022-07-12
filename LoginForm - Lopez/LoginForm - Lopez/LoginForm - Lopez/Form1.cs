using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm___Lopez
{
    public partial class EDP : Form
    {
        public EDP()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Log in
            string tabName = "Information";
            string message = "Check the username and password if correct." + "\n\n\n" +
                             "Username: " + txtUsername.Text + "\n\n" +
                             "Password: " + txtPassword.Text;
            MessageBoxButtons click = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, tabName, click, MessageBoxIcon.Question);

            if(result == DialogResult.Yes){
                string title = "Greetings";
                string notif = "Welcome to the EDP!";
                MessageBoxButtons confirm = MessageBoxButtons.OK;
                MessageBox.Show(notif, title, confirm, MessageBoxIcon.Information);
            }
            else {
                string prob = "Error";
                string repeat = "Please try again.";
                MessageBoxButtons confirm = MessageBoxButtons.OK;
                MessageBox.Show(repeat, prob, confirm, MessageBoxIcon.Error);
            }
            
           // Application.Exit();
        }
    }
}
