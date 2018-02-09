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
        //public PictureBox[] enemy = new PictureBox[1000];
        //public PictureBox myPictureBox = new PictureBox();
        //public int spawn = 1500;
        public Timer enemyTimer = new Timer();
        public BaddieKills kills = new BaddieKills();
        public SoundPlayer battleMusic = new SoundPlayer();
        //public WindowsMediaPlayer music = new WindowsMediaPlayer();
        public int enemyCount = 0;
        public int enemySpawnRate = 1500; 

        public Form1()
        {
            InitializeComponent();
            enemyTimer.Tick += EnemyTimer_Tick;
            enemyTimer.Interval = enemySpawnRate;           
        }

        private void EnemyTimer_Tick(object sender, EventArgs e)
        {
            playerInstructionsLabel.Visible = false;
            AddEnemy();
        }

        private void AddEnemy()
        {
            ///<summary>
            ///creates a new picture box object and sets all the properties of each one. Each control will then be added
            ///to the Controls collection which starts of with 8 controls that are not picture boxes. 
            ///the game over code contains a for loop contains the control count as the value of i. The reason for the - 1 is 
            ///because collections are zero based. Not having the - 1 would result in a IndexOutOfRange exception.
            ///The if statement within the for loop checks if the control is a picture box and disposes of it and placing that 
            ///picture box up for garbage collection which is fine. At my current skill level, I believe this is acceptable
            /// despite knowing that the for loop is only feasible due to the small number of controls. I am aware that having
            /// a lot of controls will impact performance for the worse.
            ///</summary>
            PictureBox enemy = new PictureBox();
            enemy.Image = Properties.Resources.eyebot2;
            enemy.SizeMode = PictureBoxSizeMode.AutoSize;
            System.Drawing.Drawing2D.GraphicsPath graphics = new System.Drawing.Drawing2D.GraphicsPath();
            graphics.AddEllipse(0, 0, enemy.Width - 1.97f, enemy.Height - 0.855f);
            Region region = new Region(graphics);
            enemy.Region = region;
            enemy.Visible = false;
            Controls.Add(enemy);

            //regarding the graphics path, that code is giving me the capability of changing the look of the enemy picturebox to that of an 
            //actual circle. The region just sets the window of the picture box to match the code the for graphics.
            

            kills.Update(false);
            totalEnemiesLabel.Text = "# of Baddie Attacks: " + kills.totalAttacks;

            Random random = new Random();
            int x = random.Next(0, 685);
            int y = random.Next(0, 630);
            enemy.Location = new Point(x, y);
            enemy.Visible = true;
            enemyCount++;

            if (enemyCount > 100)
            {
                enemyTimer.Stop();
                battleMusic.Stop();          
                gameOverLabel.Visible = true;
                enemyCount = 0;

                for (int i = Controls.Count - 1; i >= 0; i--)
                {
                    if (Controls[i] is PictureBox)
                    {
                        Controls[i].Dispose();
                    }
                }

                startGameLabel.Enabled = true;
            }

            enemy.Click += Enemy_Click; 
        }

        private void Enemy_Click(object sender, EventArgs e)
        {
            PictureBox theBox = (PictureBox)sender;
            //declares the enemy picture box that raises this event as theBox which then allows me manipulate bellow.
           
            if (theBox.Visible == true)
            {
                //enemyDestroyed = true;
                //ActiveForm.Refresh();               
                theBox.Dispose();
                //theBox.Visible = false;

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
                if (enemyTimer.Interval > 300)
                {
                    enemyTimer.Interval -= 20;
                }
                if (enemyTimer.Interval > 50)
                {
                    enemyTimer.Interval -= 10;
                }

                difficultyProgressBar.Value = 1500 - enemyTimer.Interval;
                enemyCount--;
                kills.Update(true);
            }
            
            enemiesHitLabel.Text = "Baddies Destroyed: " + kills.killCount;
            
        }

        private void startGameLabel_Click(object sender, EventArgs e)
        {           
            gameOverLabel.Visible = false;
            enemyTimer.Interval = enemySpawnRate;
            difficultyProgressBar.Value = 0;  
            
            kills.totalAttacks = 0;
            totalEnemiesLabel.Text = "# of Baddie Attacks: " + kills.totalAttacks;

            kills.killCount = 0;
            enemiesHitLabel.Text = "Baddies Destroyed: " + kills.killCount;

            playerInstructionsLabel.Visible = true;           
            enemyTimer.Start();
            startGameLabel.Enabled = false;

            battleMusic = new SoundPlayer(Properties.Resources.Juhani_Junkala_Level_1);//I GOT IT! THIS GETS THE LOCALIZED RESOURCE!!!
            //sound.SoundLocation = Properties.Resources.Juhani_Junkala_Level_1.ToString(); //This was me trying to do the above. 
            battleMusic.PlayLooping();
            //music.URL = @"C:\Users\jaime\Downloads\Assets for game creation\Music\BGM\Juhani Junkala Level 1.wav";            
            //music.controls.play();
            //music.settings.setMode("Loop", true);        
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
