using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using WMPLib;

namespace Baddie_Clicks
{
    public partial class Form1 : Form
    {        
        //public bool enemyDestroyed = false;
        //public PictureBox[] myPictureBox = new PictureBox[1000];
        //public PictureBox myPictureBox = new PictureBox();
        //public int spawn = 1500;
        public Timer enemyTimer = new Timer();
        public BaddieKills kills = new BaddieKills();
        //public SoundPlayer sound = new SoundPlayer();
        public WMPLib.WindowsMediaPlayer music = new WindowsMediaPlayer();

        public Form1()
        {
            InitializeComponent();
            enemyTimer.Tick += EnemyTimer_Tick;
            enemyTimer.Interval = 1500;           
        }

        private void EnemyTimer_Tick(object sender, EventArgs e)
        {
            AddEnemy();
        }

        private void AddEnemy()
        {
            PictureBox enemy = new PictureBox();
            enemy.Image = Properties.Resources.eyebot2;
            enemy.SizeMode = PictureBoxSizeMode.AutoSize;
            enemy.Visible = false;
            Controls.Add(enemy);
            Random random = new Random();
            int x = random.Next(0, 685);
            int y = random.Next(0, 630);
            enemy.Location = new Point(x, y);
            enemy.Visible = true;

            enemy.Click += Enemy_Click;

            if (enemy.Controls.Count > 10)
            {            
                gameOverLabel.Visible = true;
                enemyTimer.Stop();
            }
        }

        private void Enemy_Click(object sender, EventArgs e)
        {
            PictureBox theBox = (PictureBox)sender;
           
            if (theBox.Visible == true)
            {
                //enemyDestroyed = true;
                //ActiveForm.Refresh();
                theBox.Visible = false;

                if (enemyTimer.Interval > 1200)
                {
                    enemyTimer.Interval -= 50;
                }
                if (enemyTimer.Interval > 900)
                {
                    enemyTimer.Interval -= 40;
                }
                if (enemyTimer.Interval > 600)
                {
                    enemyTimer.Interval -= 30;
                }
                if (enemyTimer.Interval > 300 || enemyTimer.Interval < 300)
                {
                    enemyTimer.Interval -= 20;
                }

                difficultyProgressBar.Value = 1500 - enemyTimer.Interval;
                kills.Update(true);
            }
            else
            {
                kills.Update(false);
            }

            enemiesHitLabel.Text = "Baddies Destroyed: " + kills.killCount;
            totalEnemiesLabel.Text = "# of Baddie Attacks: " + kills.totalAttacks;
        }

        private void startGameLabel_Click(object sender, EventArgs e)
        {
            enemyTimer.Start();
            gameOverLabel.Visible = false;
            //sound = new SoundPlayer(@"C:\Users\jaime\Downloads\Assets for game creation\Music\BGM\DST-TowerDefenseTheme.mp3");
            //sound.PlayLooping();
            music.URL = @"C:\Users\jaime\Downloads\Assets for game creation\Music\BGM\DST-TowerDefenseTheme.mp3";            
            music.controls.play();
        }



        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    //timer1.Stop();            
        //    //for (int i = 0; i < myPictureBox.Length; i++)
        //    //{
        //    //    await Task.Delay(spawn);
        //    //    myPictureBox[i] = new PictureBox();
        //    //    myPictureBox[i].Image = Properties.Resources.eyebot2;
        //    //    myPictureBox[i].SizeMode = PictureBoxSizeMode.AutoSize;
        //    //    myPictureBox[i].Visible = false;
        //    //    Controls.Add(myPictureBox[i]);
        //    //    Random random = new Random();
        //    //    int x = random.Next(0, 685);
        //    //    int y = random.Next(0, 630);
        //    //    myPictureBox[i].Location = new Point(x, y);
        //    //    myPictureBox[i].Visible = true;
        //    //    //foreach (PictureBox item in myPictureBox)
        //    //    //{
        //    //    //    this.myPictureBox[i].Click += new EventHandler(this.myPictureBox_Click);
        //    //    //}

        //    //    myPictureBox[i].Click += myPictureBox_Click;
        //    //    //myPictureBox[i].Tag = i;              
        //    //}

        //    //await Task.Delay(1500);
        //    //myPictureBox = new PictureBox();
        //    //myPictureBox.Image = Properties.Resources.eyebot2;
        //    //myPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
        //    //myPictureBox.Visible = false;
        //    //Controls.Add(myPictureBox);
        //    //Random random = new Random();
        //    //int x = random.Next(0, 685);
        //    //int y = random.Next(0, 630);
        //    //myPictureBox.Location = new Point(x, y);
        //    //myPictureBox.Visible = true;
        //    //myPictureBox.Click += myPictureBox_Click;
        //}

        //private void myPictureBox_Click(object sender, EventArgs e)
        //{
        //    PictureBox theBox = (PictureBox)sender;
        //    //int i = (int)theBox.Tag;
        //    theBox.Visible = false;

        //    enemyDestroyed = true;

        //    //if (i != null)
        //    //{
        //    //    theBox.Visible = false;
        //    //}
        //}
    }          
}
