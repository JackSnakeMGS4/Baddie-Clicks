using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baddie_Clicks
{
    public partial class Form1 : Form
    {        
        public bool enemyDestroyed = false;
        public PictureBox[] myPictureBox = new PictureBox[100];
        //public PictureBox myPictureBox = new PictureBox();

        public Form1()
        {
            InitializeComponent();
        }      

        private void startGameLabel_Click(object sender, EventArgs e)
        {
            timer1.Start();               
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            for (int i = 0; i < myPictureBox.Length; i++)
            {
                await Task.Delay(1500);
                myPictureBox[i] = new PictureBox();
                myPictureBox[i].Image = Properties.Resources.eyebot2;
                myPictureBox[i].SizeMode = PictureBoxSizeMode.AutoSize;
                myPictureBox[i].Visible = false;
                Controls.Add(myPictureBox[i]);
                Random random = new Random();
                int x = random.Next(0, 685);
                int y = random.Next(0, 630);
                myPictureBox[i].Location = new Point(x, y);
                myPictureBox[i].Visible = true;
                //foreach (PictureBox item in myPictureBox)
                //{
                //    this.myPictureBox[i].Click += new EventHandler(this.myPictureBox_Click);
                //}

                myPictureBox[i].Click += myPictureBox_Click;
                //myPictureBox[i].Tag = i;

                //await Task.Delay(1500);
                //myPictureBox = new PictureBox();
                //myPictureBox.Image = Properties.Resources.eyebot2;
                //myPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
                //myPictureBox.Visible = false;
                //Controls.Add(myPictureBox);
                //Random random = new Random();
                //int x = random.Next(0, 685);
                //int y = random.Next(0, 630);
                //myPictureBox.Location = new Point(x, y);
                //myPictureBox.Visible = true;
                //myPictureBox.Click += new EventHandler(myPictureBox_Click);

            }
        }

        private void myPictureBox_Click(object sender, EventArgs e)
        {
            PictureBox theBox = (PictureBox)sender;
            //int i = (int)theBox.Tag;
            theBox.Visible = false;

            enemyDestroyed = true;

            //if (i != null)
            //{
            //    theBox.Visible = false;
            //}
        }
    }          
}
