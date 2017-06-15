namespace PongGame
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
            this.components = new System.ComponentModel.Container();
            this.gameArea = new System.Windows.Forms.Panel();
            this.brick10 = new System.Windows.Forms.PictureBox();
            this.brick4 = new System.Windows.Forms.PictureBox();
            this.brick3 = new System.Windows.Forms.PictureBox();
            this.brick9 = new System.Windows.Forms.PictureBox();
            this.brick8 = new System.Windows.Forms.PictureBox();
            this.brick5 = new System.Windows.Forms.PictureBox();
            this.brick6 = new System.Windows.Forms.PictureBox();
            this.brick2 = new System.Windows.Forms.PictureBox();
            this.brick1 = new System.Windows.Forms.PictureBox();
            this.brick7 = new System.Windows.Forms.PictureBox();
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.scoresLabel = new System.Windows.Forms.Label();
            this.board = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gameArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brick10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.board)).BeginInit();
            this.SuspendLayout();
            // 
            // gameArea
            // 
            this.gameArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gameArea.Controls.Add(this.brick10);
            this.gameArea.Controls.Add(this.brick4);
            this.gameArea.Controls.Add(this.brick3);
            this.gameArea.Controls.Add(this.brick9);
            this.gameArea.Controls.Add(this.brick8);
            this.gameArea.Controls.Add(this.brick5);
            this.gameArea.Controls.Add(this.brick6);
            this.gameArea.Controls.Add(this.brick2);
            this.gameArea.Controls.Add(this.brick1);
            this.gameArea.Controls.Add(this.brick7);
            this.gameArea.Controls.Add(this.gameOverLabel);
            this.gameArea.Controls.Add(this.pointsLabel);
            this.gameArea.Controls.Add(this.ball);
            this.gameArea.Controls.Add(this.scoresLabel);
            this.gameArea.Controls.Add(this.board);
            this.gameArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameArea.Location = new System.Drawing.Point(0, 0);
            this.gameArea.Name = "gameArea";
            this.gameArea.Size = new System.Drawing.Size(617, 500);
            this.gameArea.TabIndex = 0;
            // 
            // brick10
            // 
            this.brick10.BackColor = System.Drawing.Color.ForestGreen;
            this.brick10.Location = new System.Drawing.Point(195, 3);
            this.brick10.Name = "brick10";
            this.brick10.Size = new System.Drawing.Size(100, 50);
            this.brick10.TabIndex = 14;
            this.brick10.TabStop = false;
            // 
            // brick4
            // 
            this.brick4.BackColor = System.Drawing.Color.ForestGreen;
            this.brick4.Location = new System.Drawing.Point(295, 3);
            this.brick4.Name = "brick4";
            this.brick4.Size = new System.Drawing.Size(100, 50);
            this.brick4.TabIndex = 13;
            this.brick4.TabStop = false;
            // 
            // brick3
            // 
            this.brick3.BackColor = System.Drawing.Color.ForestGreen;
            this.brick3.Location = new System.Drawing.Point(195, 50);
            this.brick3.Name = "brick3";
            this.brick3.Size = new System.Drawing.Size(100, 50);
            this.brick3.TabIndex = 12;
            this.brick3.TabStop = false;
            // 
            // brick9
            // 
            this.brick9.BackColor = System.Drawing.Color.ForestGreen;
            this.brick9.Location = new System.Drawing.Point(99, 3);
            this.brick9.Name = "brick9";
            this.brick9.Size = new System.Drawing.Size(100, 50);
            this.brick9.TabIndex = 11;
            this.brick9.TabStop = false;
            // 
            // brick8
            // 
            this.brick8.BackColor = System.Drawing.Color.ForestGreen;
            this.brick8.Location = new System.Drawing.Point(0, 3);
            this.brick8.Name = "brick8";
            this.brick8.Size = new System.Drawing.Size(100, 50);
            this.brick8.TabIndex = 10;
            this.brick8.TabStop = false;
            // 
            // brick5
            // 
            this.brick5.BackColor = System.Drawing.Color.ForestGreen;
            this.brick5.Location = new System.Drawing.Point(0, 100);
            this.brick5.Name = "brick5";
            this.brick5.Size = new System.Drawing.Size(100, 50);
            this.brick5.TabIndex = 9;
            this.brick5.TabStop = false;
            // 
            // brick6
            // 
            this.brick6.BackColor = System.Drawing.Color.ForestGreen;
            this.brick6.Location = new System.Drawing.Point(0, 50);
            this.brick6.Name = "brick6";
            this.brick6.Size = new System.Drawing.Size(100, 50);
            this.brick6.TabIndex = 8;
            this.brick6.TabStop = false;
            // 
            // brick2
            // 
            this.brick2.BackColor = System.Drawing.Color.ForestGreen;
            this.brick2.Location = new System.Drawing.Point(99, 100);
            this.brick2.Name = "brick2";
            this.brick2.Size = new System.Drawing.Size(100, 50);
            this.brick2.TabIndex = 7;
            this.brick2.TabStop = false;
            // 
            // brick1
            // 
            this.brick1.BackColor = System.Drawing.Color.ForestGreen;
            this.brick1.Location = new System.Drawing.Point(0, 146);
            this.brick1.Name = "brick1";
            this.brick1.Size = new System.Drawing.Size(100, 50);
            this.brick1.TabIndex = 6;
            this.brick1.TabStop = false;
            // 
            // brick7
            // 
            this.brick7.BackColor = System.Drawing.Color.ForestGreen;
            this.brick7.Location = new System.Drawing.Point(99, 50);
            this.brick7.Name = "brick7";
            this.brick7.Size = new System.Drawing.Size(100, 50);
            this.brick7.TabIndex = 5;
            this.brick7.TabStop = false;
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gameOverLabel.Font = new System.Drawing.Font("Papyrus", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.gameOverLabel.Location = new System.Drawing.Point(163, 170);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(232, 58);
            this.gameOverLabel.TabIndex = 4;
            this.gameOverLabel.Text = "Game Over";
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.Font = new System.Drawing.Font("Papyrus", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointsLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.pointsLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pointsLabel.Location = new System.Drawing.Point(533, 9);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(41, 51);
            this.pointsLabel.TabIndex = 3;
            this.pointsLabel.Text = "0";
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Red;
            this.ball.Location = new System.Drawing.Point(32, 202);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(17, 17);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // scoresLabel
            // 
            this.scoresLabel.AutoSize = true;
            this.scoresLabel.Font = new System.Drawing.Font("Papyrus", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoresLabel.ForeColor = System.Drawing.Color.Purple;
            this.scoresLabel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.scoresLabel.Location = new System.Drawing.Point(401, 9);
            this.scoresLabel.Name = "scoresLabel";
            this.scoresLabel.Size = new System.Drawing.Size(150, 51);
            this.scoresLabel.TabIndex = 2;
            this.scoresLabel.Text = "Scores: ";
            // 
            // board
            // 
            this.board.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.board.Location = new System.Drawing.Point(127, 398);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(300, 10);
            this.board.TabIndex = 0;
            this.board.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 500);
            this.Controls.Add(this.gameArea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.gameArea.ResumeLayout(false);
            this.gameArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brick10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brick7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.board)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gameArea;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox board;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.Label scoresLabel;
        private System.Windows.Forms.PictureBox brick8;
        private System.Windows.Forms.PictureBox brick5;
        private System.Windows.Forms.PictureBox brick6;
        private System.Windows.Forms.PictureBox brick2;
        private System.Windows.Forms.PictureBox brick1;
        private System.Windows.Forms.PictureBox brick7;
        private System.Windows.Forms.PictureBox brick4;
        private System.Windows.Forms.PictureBox brick3;
        private System.Windows.Forms.PictureBox brick9;
        private System.Windows.Forms.PictureBox brick10;
    }
}

