using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Pacanele
{
    public partial class Pacanele : Form
    {
        //WindowsMediaPlayer player = new WindowsMediaPlayer();
        public Pacanele()
        {
            InitializeComponent();
            //player.controls.
           /// player.controls.play();
            // 3 de 7 + *5 bet
            // 4 de 7 + *7 bet
            // 5 de 7 + * 20 bet
            // la 2 nu pierzi nici nu castigi
            // boaba *2 *3 *7
            // portocala *3 *4 *9
            // lamaie *3 *4 *9
            // pepene *4 *5 *10
        }
        //string bet, Credits;
        int wins = 0, betMoney = 15, creditMoney = 500;
        Random rnd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (creditMoney == 0)
                {
                    MessageBox.Show("Ti.ai pierdut banii golane", "F , ai avut " + wins.ToString() + " win.uri", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    Application.Exit();
                }
                else if (Convert.ToInt32(Bet.Text) == 0)
                    MessageBox.Show("Mai Golane", "Vai Vai Vai", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                else if (Convert.ToInt32(Bet.Text) <= Convert.ToInt32(Credits.Text))
                    Spin();
                else
                {
                    MessageBox.Show("Your bet has to be lower or equal than your credits .\nYou have to lower the Bet !", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("ERROR", "Your bet has to be an number");
            }
        }

        private void Pacanele_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            betMoney = creditMoney;
            this.Bet.Text = betMoney.ToString();
        }

        /// <summary>
        /// %7 o sa fie 7
        /// %3 si nu cu 2 o sa fie portocala
        /// %3 si la %2 o sa fie lamaie
        /// %4 pepene
        /// </summary>
        void Spin()
        {    
            int l1, l2, l3, l4, l5;
            l1 = rnd.Next(0, 5);
            l2 = rnd.Next(0, 5);
            l3 = rnd.Next(0, 5);
            l4 = rnd.Next(0, 5);
            l5 = rnd.Next(0, 5);
            ///
            //l1 = 0; l2 = 0; l3 = 0;
            ///
            // pt l1
            switch (l1)
            {
                case 0:
                    this.pictureBox1.Image = Properties.Resources.tenor;
                    break;
                case 1:
                    this.pictureBox1.Image = Properties.Resources.Hangan;
                    break;
                case 2:
                    this.pictureBox1.Image = Properties.Resources.SSS;
                    break;
                case 3:
                    this.pictureBox1.Image = Properties.Resources.Oh_;
                    break;
                case 4:
                    this.pictureBox1.Image = Properties.Resources.PFFT;
                    break;               
            }
            // pt l2
            switch (l2)
            {
                case 0:
                    this.pictureBox2.Image = Properties.Resources.tenor;
                    break;
                case 1:
                    this.pictureBox2.Image = Properties.Resources.Hangan;
                    break;
                case 2:
                    this.pictureBox2.Image = Properties.Resources.SSS;
                    break;
                case 3:
                    this.pictureBox2.Image = Properties.Resources.Oh_;
                    break;
                case 4:
                    this.pictureBox2.Image = Properties.Resources.PFFT;
                    break;
            }
            //pt l3
            switch (l3)
            {
                case 0:
                    this.pictureBox3.Image = Properties.Resources.tenor;
                    break;
                case 1:
                    this.pictureBox3.Image = Properties.Resources.Hangan;
                    break;
                case 2:
                    this.pictureBox3.Image = Properties.Resources.SSS;
                    break;
                case 3:
                    this.pictureBox3.Image = Properties.Resources.Oh_;
                    break;
                case 4:
                    this.pictureBox3.Image = Properties.Resources.PFFT;
                    break;
            }
            // pt l4
            switch (l4)
            {
                case 0:
                    this.pictureBox4.Image = Properties.Resources.tenor;
                    break;
                case 1:
                    this.pictureBox4.Image = Properties.Resources.Hangan;
                    break;
                case 2:
                    this.pictureBox4.Image = Properties.Resources.SSS;
                    break;
                case 3:
                    this.pictureBox4.Image = Properties.Resources.Oh_;
                    break;
                case 4:
                    this.pictureBox4.Image = Properties.Resources.PFFT;
                    break;
            }
            // pt l5
            switch (l5)
            {
                case 0:
                    this.pictureBox5.Image = Properties.Resources.tenor;
                    break;
                case 1:
                    this.pictureBox5.Image = Properties.Resources.Hangan;
                    break;
                case 2:
                    this.pictureBox5.Image = Properties.Resources.SSS;
                    break;
                case 3:
                    this.pictureBox5.Image = Properties.Resources.Oh_;
                    break;
                case 4:
                    this.pictureBox5.Image = Properties.Resources.PFFT;
                    break;
            }
            // 7 7 7 7 7          
            if (l1 == 1 && l2 == 1 && l3 == 1 && l4 == 1 && l5 == 1)
            {
                creditMoney = creditMoney + betMoney * 7;
                this.Credits.Text = creditMoney.ToString();
                wins++;
                Win.Text = wins.ToString();
            }
            else if (l1 == l2 && l1 == l3 && l3 == l4 && l1 == l5)
            {
                creditMoney = creditMoney + betMoney * 5;
                this.Credits.Text = creditMoney.ToString();
                this.wins++;
                this.Win.Text = wins.ToString();
            }
            else if ((l1 == 1 && l2 == 1 && l3 == 1 && l4 == 1) || (l1 == 1 && l2 == 1 && l3 == 1 && l5 == 1) || (l1 == 1 && l2 == 1 && l5 == 1 && l4 == 1) || (l1 == 1 && l5 == 1 && l3 == 1 && l4 == 1) || (l5 == 1 && l2 == 1 && l3 == 1 && l4 == 1))
            {
                creditMoney = creditMoney + betMoney * 5;
                this.Credits.Text = creditMoney.ToString();
                this.wins++;
                Win.Text = wins.ToString();
            }
            else if ((l1 == l2 && l1 == l3 && l3 == l4) || (l1 == l2 && l1 == l3 && l3 == l5) || (l1 == l2 && l1 == l5 && l5 == l4) || (l1 == l5 && l1 == l3 && l3 == l4) || (l5 == l2 && l5 == l3 && l3 == l4))
            {
                creditMoney = creditMoney + betMoney * 3 + 30;
                this.Credits.Text = creditMoney.ToString();
                this.wins++;
                this.Win.Text = wins.ToString();
            }
            else if ((l1 == 1 && l2 == 1 && l3 == 1) || (l1 == 1 && l2 == 1 && l4 == 1) || (l1 == 1 && l2 == 1 && l5 == 1) || (l1 == 1 && l4 == 1 && l3 == 1) || (l1 == 1 && l5 == 1 && l3 == 1) || (l4 == 1 && l2 == 1 && l3 == 1) || (l1 == 1 && l4 == 1 && l5 == 1) || (l4 == 1 && l2 == 1 && l5 == 1) || (l4 == 1 && l3 == 1 && l5 == 1) || (l5 == 1 && l2 == 1 && l3 == 1))
            {
                creditMoney = creditMoney + betMoney * 3 + 25;
                this.Credits.Text = creditMoney.ToString();
                this.wins++;
                this.Win.Text = wins.ToString();
            }
            else if ((l1 == l2 && l1 == l3) || (l1 == l2 && l1 == l4) || (l1 == l2 && l1 == l5) || (l1 == l3 && l1 == l4) || (l1 == l3 && l1 == l5) || (l1 == l4 && l1 == l5) || (l2 == l3 && l2 == l4) || (l2 == l3 && l2 == l5) || (l3 == l4 && l3 == l5)) 
            {
                creditMoney = creditMoney + betMoney * 3/2 + 5;
                this.Credits.Text = creditMoney.ToString();
                this.wins++;
                this.Win.Text = wins.ToString();
            }
            else
            {              
                creditMoney = creditMoney - betMoney;
                this.Credits.Text = creditMoney.ToString();             
            }
        }
        
        private void Bet_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.betMoney = Convert.ToInt32(this.Bet.Text);
            }
            catch
            {

            }
        }
    }
}
