using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace russain_roullete_assiment
{
    public partial class Finalplay : Form
    {
        public Finalplay()
        {
            InitializeComponent();
        }
        Random spinrand = new Random();
        make maker = new make();
        private void Loaderbtn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\ishwa\Desktop\russain roullete assiment\res\load.jpg");



            spinnerbtn .Enabled = true;
            Loaderbtn .Enabled = false;
        }

        private void spinnerbtn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\ishwa\Desktop\russain roullete assiment\res\spin.jpg");

            maker.loader = spinrand.Next(1, 6);//place the bullete in one of 6 chamber

            Shooterbtn .Enabled = true;
            spinnerbtn .Enabled = false;
        }

        private void Shooterbtn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\ishwa\Desktop\russain roullete assiment\res\shoot.jpg");

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\ishwa\Desktop\russain roullete assiment\res\3.wav");
            player.Play();//plays the sound
            if (maker.total > 0 && maker.loader == 1)
            {

                MessageBox.Show("Shoot");
                MessageBox.Show("You Loose");

                Shooterbtn .Enabled = false;
                Missbtn .Enabled = false;
                spinnerbtn .Enabled = false;
                Loaderbtn .Enabled = false;



            }
            else if (maker.total > 0 && maker.loader != 1)
            {
                maker.total = maker.total - 1;
                maker.loader = loderchanger(maker.loader);
                MessageBox.Show("Saved");

            }
        }
        public int loderchanger(int Bullete)
        {
            if (Bullete == 6)
            {
                Bullete = 1;//bullete is 1
            }
            else
            {
                Bullete++;//increase the value of bullete
            }
            return Bullete;
        }
        private void Missbtn_Click(object sender, EventArgs e)
        {
            int track = maker.amissbullete();
            if (track == 10)
            {
                MessageBox.Show("Shoot");
                MessageBox.Show("won 1000");
                Shooterbtn.Enabled = false;
                Missbtn.Enabled = false;
                spinnerbtn.Enabled = false;
                Loaderbtn.Enabled = false;

            }
            if (track == 5)
            {
                MessageBox.Show("Shoot ");
                MessageBox.Show("won 500");
                Shooterbtn.Enabled = false;
                Missbtn.Enabled = false;
                spinnerbtn.Enabled = false;
                Loaderbtn.Enabled = false;
                if (track == 0)
                {

                    MessageBox.Show("saved");
                }
                if (maker.total == 0)
                {

                    MessageBox.Show("you are lost");
                    Shooterbtn.Enabled = false;


                }

            }
           
        }

        private void Retrybtn_Click(object sender, EventArgs e)
        {
            (new Finalplay()).Show();
            this.Hide();//relodes the games 
        }
    }
}
