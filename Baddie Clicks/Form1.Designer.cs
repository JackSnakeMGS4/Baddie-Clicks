namespace Baddie_Clicks
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.enemiesHitLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.totalEnemiesLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.difficultyLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.difficultyProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.startGameLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.playerInstructionsLabel = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enemiesHitLabel,
            this.totalEnemiesLabel,
            this.difficultyLabel,
            this.difficultyProgressBar,
            this.startGameLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 656);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(704, 25);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // enemiesHitLabel
            // 
            this.enemiesHitLabel.Name = "enemiesHitLabel";
            this.enemiesHitLabel.Size = new System.Drawing.Size(116, 20);
            this.enemiesHitLabel.Text = "Baddies Destroyed: 0";
            // 
            // totalEnemiesLabel
            // 
            this.totalEnemiesLabel.Name = "totalEnemiesLabel";
            this.totalEnemiesLabel.Size = new System.Drawing.Size(121, 20);
            this.totalEnemiesLabel.Text = "# of Baddie Attacks: 0";
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(249, 20);
            this.difficultyLabel.Spring = true;
            this.difficultyLabel.Text = "Difficulty";
            this.difficultyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // difficultyProgressBar
            // 
            this.difficultyProgressBar.Maximum = 1500;
            this.difficultyProgressBar.Name = "difficultyProgressBar";
            this.difficultyProgressBar.Size = new System.Drawing.Size(100, 19);
            // 
            // startGameLabel
            // 
            this.startGameLabel.Font = new System.Drawing.Font("Old English Text MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGameLabel.Name = "startGameLabel";
            this.startGameLabel.Size = new System.Drawing.Size(101, 20);
            this.startGameLabel.Text = "Start Game!";
            this.startGameLabel.Click += new System.EventHandler(this.startGameLabel_Click);
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.BackColor = System.Drawing.Color.Transparent;
            this.gameOverLabel.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.gameOverLabel.Font = new System.Drawing.Font("Mistral", 80.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.gameOverLabel.Location = new System.Drawing.Point(117, 256);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(460, 127);
            this.gameOverLabel.TabIndex = 2;
            this.gameOverLabel.Text = "Game Over!";
            this.gameOverLabel.Visible = false;
            // 
            // playerInstructionsLabel
            // 
            this.playerInstructionsLabel.AutoSize = true;
            this.playerInstructionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerInstructionsLabel.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.playerInstructionsLabel.Font = new System.Drawing.Font("Mistral", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerInstructionsLabel.ForeColor = System.Drawing.Color.Gold;
            this.playerInstructionsLabel.Location = new System.Drawing.Point(120, 542);
            this.playerInstructionsLabel.Name = "playerInstructionsLabel";
            this.playerInstructionsLabel.Size = new System.Drawing.Size(466, 114);
            this.playerInstructionsLabel.TabIndex = 3;
            this.playerInstructionsLabel.Text = "Click or Die!";
            this.playerInstructionsLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(704, 681);
            this.Controls.Add(this.playerInstructionsLabel);
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.statusStrip1);
            this.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Baddie Clicks";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel enemiesHitLabel;
        private System.Windows.Forms.ToolStripStatusLabel totalEnemiesLabel;
        private System.Windows.Forms.ToolStripStatusLabel difficultyLabel;
        private System.Windows.Forms.ToolStripProgressBar difficultyProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel startGameLabel;
        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Label playerInstructionsLabel;
    }
}

