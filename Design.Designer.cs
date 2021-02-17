
namespace SnakeMania
{
    partial class Design
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
            this.components = new System.ComponentModel.Container();
            this.mainGame = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.Label();
            this.Points = new System.Windows.Forms.Label();
            this.Tscore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblGameOver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainGame)).BeginInit();
            this.SuspendLayout();
            // 
            // mainGame
            // 
            this.mainGame.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.mainGame.Location = new System.Drawing.Point(21, 106);
            this.mainGame.Name = "mainGame";
            this.mainGame.Size = new System.Drawing.Size(906, 503);
            this.mainGame.TabIndex = 0;
            this.mainGame.TabStop = false;
            this.mainGame.Paint += new System.Windows.Forms.PaintEventHandler(this.mainGame_Paint);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score.Location = new System.Drawing.Point(239, 33);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(157, 51);
            this.Score.TabIndex = 1;
            this.Score.Text = "Score:";
            // 
            // Points
            // 
            this.Points.AutoSize = true;
            this.Points.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Points.Location = new System.Drawing.Point(751, 18);
            this.Points.Name = "Points";
            this.Points.Size = new System.Drawing.Size(0, 51);
            this.Points.TabIndex = 2;
            // 
            // Tscore
            // 
            this.Tscore.AutoSize = true;
            this.Tscore.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tscore.Location = new System.Drawing.Point(492, 33);
            this.Tscore.Name = "Tscore";
            this.Tscore.Size = new System.Drawing.Size(46, 51);
            this.Tscore.TabIndex = 3;
            this.Tscore.Text = "0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 200;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.Location = new System.Drawing.Point(263, 303);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(415, 82);
            this.lblGameOver.TabIndex = 4;
            this.lblGameOver.Text = "Game Over";
            this.lblGameOver.Visible = false;
            // 
            // Design
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(953, 649);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.Tscore);
            this.Controls.Add(this.Points);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.mainGame);
            this.Name = "Design";
            this.Text = "SnakeMania";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.mainGame)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainGame;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label Points;
        private System.Windows.Forms.Label Tscore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lblGameOver;
    }
}

