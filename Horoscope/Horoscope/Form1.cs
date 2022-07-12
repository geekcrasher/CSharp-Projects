using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horoscope
{
    public partial class zodiacSign : Form
    {
        public zodiacSign()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void horoscope_Load(object sender, EventArgs e)
        {

        }

        private void showHoroscope_Click(object sender, EventArgs e)
        {   
            int bMonth = calendar.Value.Date.Month;
            int bDay = calendar.Value.Date.Day;
            string tabName = "Zodiac Sign";
            MessageBoxButtons btn = MessageBoxButtons.OK;


            if ((bMonth==1 && bDay>=20)||(bMonth==2 && bDay<=18)) {
                MessageBox.Show("Your zodiac sign is Aquarius.", tabName, btn, MessageBoxIcon.Information);
            }
            else if ((bMonth==2 && bDay>=19)||(bMonth==3 && bDay<=20)) {
                MessageBox.Show("Your zodiac sign is Pisces.", tabName, btn, MessageBoxIcon.Information);
            }
            else if ((bMonth==3 && bDay>=21)||(bMonth==4 && bDay<=19)) {
                MessageBox.Show("Your zodiac sign is Aries.", tabName, btn, MessageBoxIcon.Information);
            }
            else if ((bMonth==4 && bDay>=20)||(bMonth==5 && bDay<=20)) {
                MessageBox.Show("Your zodiac sign is Taurus.", tabName, btn, MessageBoxIcon.Information);
            }
            else if ((bMonth==5 && bDay>=21)||(bMonth==6 && bDay<=20)) {
                MessageBox.Show("Your zodiac sign is Gemini.", tabName, btn, MessageBoxIcon.Information);
            }
            else if ((bMonth==6 && bDay>=21)||(bMonth==7 && bDay<=22)) {
                MessageBox.Show("Your zodiac sign is Cancer.", tabName, btn, MessageBoxIcon.Information);
            }
            else if ((bMonth==7 && bDay>=23)||(bMonth==8 && bDay<=22)) {
                MessageBox.Show("Your zodiac sign is Leo.", tabName, btn, MessageBoxIcon.Information);
            }
            else if ((bMonth==8 && bDay>=23)||(bMonth==9 && bDay<=22)) {
                MessageBox.Show("Your zodiac sign is Virgo.", tabName, btn, MessageBoxIcon.Information);
            }
            else if ((bMonth==9 && bDay>=23) || (bMonth==10 && bDay<=22)) {
                MessageBox.Show("Your zodiac sign is Libra.", tabName, btn, MessageBoxIcon.Information);
            }
            else if ((bMonth==10 && bDay>=23) || (bMonth==11 && bDay<=21)) {
                MessageBox.Show("Your zodiac sign is Scorpio.", tabName, btn, MessageBoxIcon.Information);
            }
            else if ((bMonth==11 && bDay>=22)||(bMonth==12 && bDay<=21)) {
                MessageBox.Show("Your zodiac sign is SAgittarius", tabName, btn, MessageBoxIcon.Information);
            }
            else if ((bMonth==12 && bDay>=22) || (bMonth==1 && bDay<=19)) {
                MessageBox.Show("Your zodiac sign is Capricorn.", tabName, btn, MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("");
            }
            
        }

        private void calendar_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
